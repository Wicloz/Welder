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
        private List<ModData> modlist = new List<ModData>();
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
            if (Directory.Exists(repoDir)) {

            }
        }

        //Loads the cached modlist
        void LoadModList () {
            modlist = new List<ModData>();
            if (Directory.Exists(repoDir))
                if (File.Exists(modlistFile))
                    SaveLoad.LoadFileBf<List<ModData>>(modlistFile);
            if (modlist == null) {
                modlist = new List<ModData>();
                MessageBox.Show("Error loading mod data file, restoring to empty list ...", "ERROR");
            }
            SaveModList();
        }

        //Saves the cached modlist
        void SaveModList () {
            if (Directory.Exists(repoDir))
                SaveLoad.SaveFileBf(modlist, modlistFile);
        }
    }
}
