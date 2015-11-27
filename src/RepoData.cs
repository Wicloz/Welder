using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Welder {
    class RepoData {
        private string repoDir = "";
        private string repoMcVersion = "";
        public List<ModData> modlist = new List<ModData>();
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
            LoadModList();
            UpdateRepoData();
        }

        //Updates the moddate of the current repo
        private void UpdateRepoData () {
            if (Directory.Exists(repoDir)) {
                List<string> modSlugFolders = new List<string>(Directory.GetDirectories(repoDir + "/mods"));
                foreach (string folder in modSlugFolders) {
                    string slug = folder.Replace(repoDir + "/mods\\", "");
                    if (GetModWithSlug(slug) == null) {
                        ModData mod = new ModData();
                        mod.modslug = slug;
                        mod.mcVersion = repoMcVersion;
                        modlist.Add(mod);
                    }
                    if (Directory.GetFiles(folder).Length > 0)
                        GetModWithSlug(slug).versionLocal = MiscFunctions.VersionFromRepoMod(Path.GetFileName(Directory.GetFiles(folder)[0]), slug);
                }
            }
        }

        //Returns the first mod with modslug modslug, otherwise returns null
        private ModData GetModWithSlug (string modslug) {
            foreach (ModData mod in modlist) {
                if (mod.modslug == modslug)
                    return mod;
            }
            return null;
        }

        //Loads the cached modlist
        private void LoadModList () {
            modlist = new List<ModData>();
            if (Directory.Exists(repoDir))
                if (File.Exists(modlistFile))
                    modlist = SaveLoad.LoadFileBf<List<ModData>>(modlistFile);
            if (modlist == null) {
                modlist = new List<ModData>();
                MessageBox.Show("Error loading mod data file, restoring to empty list ...", "ERROR");
            }
            SaveModList();
        }

        //Saves the cached modlist
        public void SaveModList () {
            if (Directory.Exists(repoDir))
                SaveLoad.SaveFileBf(modlist, modlistFile);
        }
    }
}
