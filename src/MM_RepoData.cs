using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace Welder {
    class MM_RepoData {
        private string repoDir = "";
        private string repoMcVersion = "";
        private string solderUrl = "";
        public List<MM_ModData> modlist = new List<MM_ModData>();
        public bool mustReloadListView = false;
        private string modlistFile {
            get {
                return repoDir + "/WelderModlist.dat";
            }
        }

        //Saves the currently open repo and loads and updates the new one
        public void LoadRepoFolder (string repoLocation, string repoVersion) {
            SaveModList();
            repoDir = repoLocation;
            repoMcVersion = repoVersion;
            solderUrl = "";
            LoadModList();
            UpdateRepoData();
        }

        //Updates the moddata of the current repo
        private void UpdateRepoData () {
            if (Directory.Exists(repoDir)) {
                List<string> modSlugFolders = new List<string>(Directory.GetDirectories(repoDir + "/mods"));
                foreach (string folder in modSlugFolders) {
                    string slug = folder.Replace(repoDir + "/mods\\", "");
                    if (GetModWithSlug(slug) == null) {
                        MM_ModData mod = new MM_ModData();
                        mod.modslug = slug;
                        mod.mcVersion = repoMcVersion;
                        modlist.Add(mod);
                    }
                }
            }
            foreach (MM_ModData mod in modlist) {
                mod.repoFolder = repoDir;
                mod.Initialise();
            }
        }

        //Returns the first mod with modslug modslug, otherwise returns null
        private MM_ModData GetModWithSlug (string modslug) {
            foreach (MM_ModData mod in modlist) {
                if (mod.modslug == modslug)
                    return mod;
            }
            return null;
        }

        //Loads the cached modlist
        private void LoadModList () {
            modlist = new List<MM_ModData>();
            if (Directory.Exists(repoDir))
                if (File.Exists(modlistFile))
                    modlist = SaveLoad.LoadFileBf<List<MM_ModData>>(modlistFile);
            if (modlist == null) {
                modlist = new List<MM_ModData>();
                MessageBox.Show("Error loading mod data file, restoring to empty list ...", "ERROR");
            }
            SaveModList();
        }

        //Saves the cached modlist
        public void SaveModList () {
            if (Directory.Exists(repoDir))
                SaveLoad.SaveFileBf(modlist, modlistFile);
        }

        //Downlads the solder modlist and adds all missing mods
        public void UpdateListFromSolder (string link, string email, string password) {
            solderUrl = link;
            CookieAwareWebClient client = MiscFunctions.GetAuthenticatedWebClient(solderUrl, email, password);
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(solderDownloadCompleted);
            client.DownloadStringAsync(new Uri(solderUrl + "mod/list"));
        }

        //Adds all missing mods from the downloaded solder list
        private void solderDownloadCompleted (object sender, DownloadStringCompletedEventArgs e) {
            if (e != null && e.Error == null && !String.IsNullOrEmpty(e.Result)) {
                List<string> modslugs = new List<string>();
                List<int> modids = new List<int>();
                using (StringReader sr = new StringReader(e.Result)) {
                    string currentline = sr.ReadLine();
                    while (currentline != null) {
                        currentline = currentline.Trim();
                        if (currentline.Contains("<a href=\"" + solderUrl + "mod/view/")) {
                            modslugs.Add(MiscFunctions.ExtractSection(currentline, "</a> (", ")"));
                            modids.Add(Convert.ToInt32(MiscFunctions.ExtractSection(currentline, "/view/", "\"")));
                        }
                        currentline = sr.ReadLine();
                    }
                }
                for (int i = 0; i < modslugs.Count; i++) {
                    string slug = modslugs[i];
                    int id = modids[i];
                    if (slug != "") {
                        MM_ModData mod = GetModWithSlug(slug);
                        if (mod == null) {
                            MM_ModData newMod = new MM_ModData();
                            newMod.modslug = slug;
                            newMod.mcVersion = repoMcVersion;
                            newMod.repoFolder = repoDir;
                            newMod.solderID = id;
                            modlist.Add(newMod);
                        }
                        else
                            mod.solderID = id;
                    }
                }
            }
            mustReloadListView = true;
        }
    }
}
