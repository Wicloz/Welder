using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace Welder {
    [Serializable]
    public class MM_ModData {
        private MM_SiteConfig siteConfig = new MM_SiteConfig();

        public string modslug = "NONE";
        public bool enabled = true;
        public string mcVersion = "NONE";
        public string modUid {
            get {
                return mcVersion + "-" + modslug + "-" + versionLocal;
            }
        }
        public string versionLocal = "NA";
        public string versionOnline = "NA";
        public string fileNumberOnline = "NA";
        public string fileNameOnline = "NA";
        public string releaseDateLatest = "NA";
        public string websiteCheck = "NONE";
        public string websiteDownload {
            get {
                return siteConfig.downloadSite
                    .Replace("%SITE%", websiteCheck)
                    .Replace("%FILENUMBER%", fileNumberOnline)
                    .Replace("%FILENAME%", fileNameOnline)
                    .Replace("%VERSION%", versionOnline);
            }
        }

        public string repoFolder = "NONE";
        public string downloadFolder {
            get {
                return ModManager.cd + "/downloads/" + modslug;
            }
        }
        public string downloadFile {
            get {
                return downloadFolder + "/mods/" + fileNameOnline;
            }
        }
        public string packedZipFile {
            get {
                return ModManager.cd + "/downloads/" + modslug + "-" + versionOnline + ".zip";
            }
        }
        public string repoZipFolder {
            get {
                return repoFolder + "/mods/" + modslug;
            }
        }
        public string repoTargetZip {
            get {
                return repoZipFolder + "/" + modslug + "-" + versionOnline + ".zip";
            }
        }
        public string notificationFile {
            get {
                return repoFolder + "/ChangedMods.txt";
            }
        }

        public bool _canUpdate = false;
        public bool canUpdate {
            get {
                return _canUpdate;
            }
            set {
                _canUpdate = value;
                if (_canUpdate)
                    Directory.CreateDirectory(Path.GetDirectoryName(downloadFile));
                else if (Directory.Exists(downloadFolder)) {
                    Directory.Delete(downloadFolder, true);
                    MiscFunctions.RemoveEmptyFolders(downloadFolder + "/..", true);
                }
            }
        }
        public bool updateList = false;
        public string sitemode {
            get {
                return siteConfig.name;
            }
        }
        public string urlState {
            get {
                if (websiteCheck == "NONE") {
                    return "";
                }
                else if (websiteDownload != "NONE") {
                    return "Automatic";
                }
                else if (sitemode != "NONE") {
                    return "Manual";
                }
                else {
                    return "Unsupported";
                }
            }
        }
        public string actionState {
            get {
                if (queuedCheck) {
                    return "Checking for Update ...";
                }
                else if (queuedFind) {
                    return "Searching for Website ...";
                }
                else if (queuedUpdate && progress != 0) {
                    return "Downloading: " + progress + "%";
                }
                else if (queuedUpdate) {
                    return "Awaiting Download ...";
                }
                else if (canUpdate) {
                    return "Update Available";
                }
                else {
                    return "";
                }
            }
        }

        //Action status tracking
        public int progress = 0;
        private int findMode = 0;
        public bool queuedUpdate = false;
        public bool queuedCheck = false;
        public bool queuedFind = false;
        public bool busyUpdate = false;
        public bool busyCheck = false;
        public bool busyFind = false;
        public bool isWorking {
            get {
                return (busyUpdate || busyCheck || busyFind);
            }
        }

        //Extra debug websites
        public string website1 = "";
        public string website2 = "";
        public string website3 = "";
        public string website4 = "";
        public string website5 = "";

        public MM_ModData () {
            siteConfig = new MM_SiteConfig();
        }
        //Initialises the moddata
        public void Initialise () {
            UpdateSiteConfig();
            SetLocalVersion();
        }

        //Sets the siteconfig to what it should be
        public void UpdateSiteConfig () {
            if (websiteCheck == "")
                websiteCheck = "NONE";
            siteConfig = MiscFunctions.GetSiteConfig(websiteCheck);
        }

        //Updates the local version
        public void SetLocalVersion () {
            if (Directory.Exists(repoZipFolder) && Directory.GetFiles(repoZipFolder).Length > 0)
                versionLocal = MiscFunctions.VersionFromRepoMod(Path.GetFileName(Directory.GetFiles(repoZipFolder)[0]), modslug);
            else
                versionLocal = "NA";
        }

        //Start an attempt to find a version check website
        public void FindWebsiteUrl () {
            busyFind = true;
            WebClient client1 = new WebClient();
            client1.DownloadStringCompleted += new DownloadStringCompletedEventHandler(findCurseCompleted);
            WebClient client2 = new WebClient();
            client2.DownloadStringCompleted += new DownloadStringCompletedEventHandler(findGoogleCompleted);
            WebClient client3 = new WebClient();
            client3.DownloadStringCompleted += new DownloadStringCompletedEventHandler(findYahooCompleted);
            progress = 0;
            findMode++;

            switch (findMode) {
                case 1:
                    websiteCheck = "NONE"; //debug
                    client1.DownloadStringAsync(new Uri("http://minecraft.curseforge.com/search?search=" + modslug.Replace("-", "")));
                    break;
                case 2:
                    website1 = websiteCheck;
                    updateList = true; //debug
                    websiteCheck = "NONE"; //debug
                    client2.DownloadStringAsync(new Uri("https://www.google.nl/search?q=" + modslug.Replace("-", "+") + "+curseforge"));
                    break;
                case 3:
                    website2 = websiteCheck;
                    updateList = true; //debug
                    websiteCheck = "NONE"; //debug
                    client3.DownloadStringAsync(new Uri("https://search.yahoo.com/search?p=" + modslug.Replace("-", "+") + "+curseforge"));
                    break;
                case 4:
                    website3 = websiteCheck;
                    updateList = true; //debug
                    websiteCheck = "NONE"; //debug
                    client2.DownloadStringAsync(new Uri("https://www.google.nl/search?q=" + modslug.Replace("-", "+") + "+minecraft"));
                    break;
                case 5:
                    website4 = websiteCheck;
                    updateList = true; //debug
                    websiteCheck = "NONE"; //debug
                    client3.DownloadStringAsync(new Uri("https://search.yahoo.com/search?p=" + modslug.Replace("-", "+") + "+minecraft"));
                    break;

                default:
                    website5 = websiteCheck;
                    updateList = true; //debug
                    websiteCheck = "NONE"; //debug
                    if (website1 != "NONE") {
                        websiteCheck = website1;
                    }
                    else if (website2 != "NONE") {
                        websiteCheck = website2;
                    }
                    else if (website3 != "NONE") {
                        websiteCheck = website3;
                    }
                    else if (website4 != "NONE") {
                        websiteCheck = website4;
                    }
                    else if (website5 != "NONE") {
                        websiteCheck = website4;
                    }
                    website1 = website1.Replace(MiscFunctions.GetSiteIdentifier("Curse"), "").Replace(MiscFunctions.GetSiteIdentifier("Forum"), "").Replace("http://", "").Replace("www.", ""); //debug
                    website2 = website2.Replace(MiscFunctions.GetSiteIdentifier("Curse"), "").Replace(MiscFunctions.GetSiteIdentifier("Forum"), "").Replace("http://", "").Replace("www.", ""); //debug
                    website3 = website3.Replace(MiscFunctions.GetSiteIdentifier("Curse"), "").Replace(MiscFunctions.GetSiteIdentifier("Forum"), "").Replace("http://", "").Replace("www.", ""); //debug
                    website4 = website4.Replace(MiscFunctions.GetSiteIdentifier("Curse"), "").Replace(MiscFunctions.GetSiteIdentifier("Forum"), "").Replace("http://", "").Replace("www.", ""); //debug
                    website5 = website5.Replace(MiscFunctions.GetSiteIdentifier("Curse"), "").Replace(MiscFunctions.GetSiteIdentifier("Forum"), "").Replace("http://", "").Replace("www.", ""); //debug

                    UpdateSiteConfig();
                    StopFindWebsiteUrl();
                    break;
            }
        }

        //When a curse internal site has been downloaded
        private void findCurseCompleted (object sender, DownloadStringCompletedEventArgs e) {
            if (e != null && e.Error == null && !String.IsNullOrEmpty(e.Result)) {
                List<string> results = new List<string>();
                using (StringReader sr = new StringReader(e.Result)) {
                    string currentline = sr.ReadLine();
                    while (currentline != null) {
                        currentline = currentline.Trim();
                        if (currentline.Contains("<a href=\"/projects/")) {
                            results.Add(currentline);
                        }
                        currentline = sr.ReadLine();
                    }
                }
                foreach (string result in results) {
                    string foundModname = MiscFunctions.ExtractSection(result, "/projects/", "?");
                    if (MiscFunctions.CleanString(foundModname) == MiscFunctions.CleanString(modslug)) {
                        string section = MiscFunctions.ExtractSection(result, "=\"", "?");
                        websiteCheck = ParseCurseUrl("http://minecraft.curseforge.com" + section);
                        break;
                    }
                }

                UpdateSiteConfig();
                FindWebsiteUrl(); //debug
                return; //debug

                if (websiteCheck == "NONE")
                    FindWebsiteUrl();
                else
                    StopFindWebsiteUrl();
            }
            else
                FindWebsiteUrl();
        }

        //When a google search result site has been downloaded
        private void findGoogleCompleted (object sender, DownloadStringCompletedEventArgs e) {
            if (e != null && e.Error == null && !String.IsNullOrEmpty(e.Result)) {
                websiteCheck = GetWebsiteFromResults(e.Result, "<a href=\"", "q=", "&");
                UpdateSiteConfig();

                FindWebsiteUrl(); //debug
                return; //debug

                if (websiteCheck == "NONE")
                    FindWebsiteUrl();
                else
                    StopFindWebsiteUrl();
            }
            else
                FindWebsiteUrl();
        }

        //When a yahoo search result site has been downloaded
        private void findYahooCompleted (object sender, DownloadStringCompletedEventArgs e) {
            if (e != null && e.Error == null && !String.IsNullOrEmpty(e.Result)) {
                websiteCheck = GetWebsiteFromResults(e.Result, "href=\"", "", "\"");
                UpdateSiteConfig();

                FindWebsiteUrl(); //debug
                return; //debug

                if (websiteCheck == "NONE")
                    FindWebsiteUrl();
                else
                    StopFindWebsiteUrl();
            }
            else
                FindWebsiteUrl();
        }

        //Gets the first curse of forum link from a search engine result page
        private string GetWebsiteFromResults (string webpage, string delim, string start, string end) {
            List<string> results = new List<string>();
            using (StringReader sr = new StringReader(webpage)) {
                string currentLine = sr.ReadLine();
                while (currentLine != null) {
                    currentLine = currentLine.Trim();
                    if (currentLine.Contains(delim)) {
                        string[] delims = new string[] {delim};
                        results.AddRange(currentLine.Split(delims, StringSplitOptions.RemoveEmptyEntries));
                    }
                    currentLine = sr.ReadLine();
                }

                string curseLink = "NONE";
                string forumLink = "NONE";

                for (int i = 0; i < results.Count; i++) {
                    results[i] = MiscFunctions.ExtractSection(results[i], start, end).Replace("%2f", "/").Replace("%3a", ":");
                }

                for (int i = 0; i < results.Count; i++) {
                    //results[i] = MiscFunctions.ExtractSection(results[i], start, end).Replace("%2f", "/").Replace("%3a", ":");
                    string foundModname = MiscFunctions.ExtractSection(results[i], "/projects/", "/");
                    if (foundModname == "")
                        foundModname = MiscFunctions.ExtractSection(results[i], "/minecraft-mods/", "/");

                    if (curseLink == "NONE" && foundModname != "" && results[i].Contains(MiscFunctions.GetSiteIdentifier("Curse")) && MiscFunctions.PartialMatch(modslug, foundModname))
                        curseLink = ParseCurseUrl(results[i]);
                    if (forumLink == "NONE" && foundModname != "" && results[i].Contains(MiscFunctions.GetSiteIdentifier("Forum")) && MiscFunctions.PartialMatch(modslug, foundModname))
                        forumLink = ParseForumUrl(results[i]);
                }

                if (curseLink != "NONE")
                    return curseLink;
                else
                    return forumLink;
            }
        }

        //Returns the fixed version of a possibly found curse url
        private string ParseCurseUrl (string url) {
            if (!url.Contains(MiscFunctions.GetSiteIdentifier("Curse")) || url == "http://minecraft.curseforge.com/mc-mods/minecraft")
                url = "NONE";

            if (url.EndsWith("/files"))
                url = url.Replace("/files", "");
            else if (url.Contains("/files/")) {
                string garbage = "/files/" + MiscFunctions.ExtractSection(url, "files/", "");
                url = url.Replace(garbage, "");
            }

            return url;
        }

        //Returns the fixed version of a possibly found froum url
        private string ParseForumUrl (string url) {
            if (!url.Contains(MiscFunctions.GetSiteIdentifier("Forum")) || url == "http://www.minecraftforum.net/forums/mapping-and-modding/minecraft-mods")
                url = "NONE";

            if (url.Contains("?page="))
                url = MiscFunctions.ExtractSection(url, "", "?");

            return url;
        }

        //Atempts to find the newest version of the mod online
        public void CheckForUpdate () {
            if (sitemode != "NONE") {
                busyCheck = true;
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(checkDownloadCompleted);
                progress = 10;
                client.DownloadStringAsync(new Uri(websiteCheck));
            }
            else {
                versionOnline = "NA";
                fileNumberOnline = "NA";
                fileNameOnline = "NA";
                releaseDateLatest = "NA";
                StopCheckForUpdate ();
            }
        }

        //When the version check site has been downloaded
        private void checkDownloadCompleted (object sender, DownloadStringCompletedEventArgs e) {
            if (e != null && e.Error == null && !String.IsNullOrEmpty(e.Result)) {
                progress = 100;
                using (StringReader sr = new StringReader(e.Result)) {
                    versionOnline = "NA";
                    fileNumberOnline = "NA";
                    fileNameOnline = "NA";
                    releaseDateLatest = "NA";

                    string currentline = sr.ReadLine();
                    //Loop until the right minecraft version or until the end (in that case: end) 
                    while (true) {
                        if (currentline == null) {
                            versionOnline = "Not Found";
                            StopCheckForUpdate();
                            return;
                        }
                        else {
                            currentline = currentline.Trim();
                            if (currentline.Contains(siteConfig.mcLineId) && mcVersion.StartsWith(MiscFunctions.ExtractSection(currentline, siteConfig.mcLinePre, siteConfig.mcLinePost)))
                                break;
                            currentline = sr.ReadLine();
                        }
                    }

                    //Loop until the next minecraft version or the end
                    while (currentline != null && (!currentline.Contains(siteConfig.mcLineId) || mcVersion.StartsWith(MiscFunctions.ExtractSection(currentline, siteConfig.mcLinePre, siteConfig.mcLinePost)))) {
                        currentline = currentline.Trim();

                        if (releaseDateLatest == "NA" && currentline.Contains(siteConfig.dateLineId))
                            releaseDateLatest = MiscFunctions.ExtractSection(currentline, siteConfig.dateLinePre, siteConfig.dateLinePost);
                        if (fileNameOnline == "NA" && currentline.Contains(siteConfig.fileNameLineId))
                            fileNameOnline = MiscFunctions.ExtractSection(currentline, siteConfig.fileNameLinePre, siteConfig.fileNameLinePost);
                        if (fileNumberOnline == "NA" && currentline.Contains(siteConfig.fileNumLineId))
                            fileNumberOnline = MiscFunctions.ExtractSection(currentline, siteConfig.fileNumLinePre, siteConfig.fileNumLinePost);
                        if (versionOnline == "NA" && currentline.Contains(siteConfig.versionLineId))
                            versionOnline = MiscFunctions.VersionFromOnlineMod(MiscFunctions.ExtractSection(currentline, siteConfig.versionLinePre, siteConfig.versionLinePost), mcVersion);

                        currentline = sr.ReadLine();
                    }

                    if (!fileNameOnline.EndsWith(".zip") && !fileNameOnline.EndsWith(".jar"))
                        fileNameOnline += ".jar";

                    if (versionOnline != "NA" && versionLocal != versionOnline)
                        canUpdate = true;
                    else
                        canUpdate = false;
                }

                StopCheckForUpdate();
            }
            else {
                StopCheckForUpdate();
            }
        }

        //Attempts to download and repack the newest version of the mod
        public void UpdateMod () {
            if (Directory.Exists(downloadFolder) && Directory.GetFiles(downloadFolder, "*.*", SearchOption.AllDirectories).Length > 0) {
                busyUpdate = true;
                progress = 100;
                MoveModToRepo();
            }

            else if (urlState == "Automatic") {
                busyUpdate = true;
                if (Directory.Exists(downloadFolder))
                    Directory.Delete(downloadFolder, true);
                Directory.CreateDirectory(Path.GetDirectoryName(downloadFile));

                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(modDownloadCompleted);
                progress = 10;
                client.DownloadFileAsync(new Uri(websiteDownload), downloadFile);
            }

            else
                StopUpdateMod();
        }

        //After the mod has been downloaded
        private void modDownloadCompleted (object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
            if (File.Exists(downloadFile)) {
                progress = 100;
                MoveModToRepo();
            }
            else
                StopUpdateMod();
        }

        //Renames, packs, moves and creates output for a downloaded mod
        private void MoveModToRepo () {
            Directory.CreateDirectory(repoZipFolder);
            if (!File.Exists(repoTargetZip)) {
                //Rename all mod files to lower case
                foreach (string file in MiscFunctions.GetFiles(downloadFolder, "*.zip|*.jar", SearchOption.AllDirectories)) {
                    bool succes = false;
                    while (!succes) {
                        try {
                            File.Move(file, file.ToLower());
                            succes = true;
                        }
                        catch { }
                    }
                }

                //Create zipfile from root of the folder
                if (File.Exists(packedZipFile))
                    File.Delete(packedZipFile);
                ZipFile.CreateFromDirectory(downloadFolder, packedZipFile);

                //Copy zipfile to solder repo
                File.Move(packedZipFile, repoTargetZip);

                //Create line in notification file
                File.AppendAllText(notificationFile, "Mod Updated: " + modslug + " - " + versionOnline + "\n");
            }

            SetLocalVersion();
            if (Directory.Exists(downloadFolder))
                Directory.Delete(downloadFolder, true);
            canUpdate = false;
            StopUpdateMod();
        }

        //Handles the changing of the progress meter for downloads
        private void client_DownloadProgressChanged (object sender, DownloadProgressChangedEventArgs e) {
            progress = 10 + Convert.ToInt32(e.ProgressPercentage * 0.8);
        }

        //Ends the finding of the version check website
        public void StopFindWebsiteUrl () {
            progress = 0;
            findMode = 0;
            queuedFind = false;
            busyFind = false;
        }

        //Ends the checking of the online version
        public void StopCheckForUpdate () {
            progress = 0;
            queuedCheck = false;
            busyCheck = false;
        }

        //Ends the downloading of the mod
        public void StopUpdateMod () {
            progress = 0;
            queuedUpdate = false;
            busyUpdate = false;
        }
    }
}
