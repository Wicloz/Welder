using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Welder {
    [Serializable]
    public class ModData {
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
        public string sitemode {
            get {
                return siteConfig.name;
            }
        }
        public bool canUpdate = false;
        public bool updateList = false;
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

        public ModData () {
            siteConfig = new MM_SiteConfig();
        }
        //Initialises the moddata
        public void Initialise () {
            UpdateSiteConfig();
        }

        //Sets the siteconfig to what it should be
        public void UpdateSiteConfig () {
            if (websiteCheck == "")
                websiteCheck = "NONE";
            siteConfig = MiscFunctions.GetSiteConfig(websiteCheck);
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

        //Stop the finding of the version check website
        public void StopFindWebsiteUrl () {
            progress = 0;
            findMode = 0;
            queuedFind = false;
            busyFind = false;
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
    }
}
