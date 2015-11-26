﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Welder {
    class RepoData {
        private string repoDir = "";
        private List<ModData> modlist = new List<ModData>();
        private string modlistFile {
            get {
                return repoDir + "/WelderModlist.dat";
            }
        }

        public void LoadRepoFolder (string repoLocation) {
            SaveModList();
            repoDir = repoLocation;
            LoadModList();
            if (Directory.Exists(repoDir)) {

            }
        }

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

        void SaveModList () {
            if (Directory.Exists(repoDir))
                SaveLoad.SaveFileBf(modlist, modlistFile);
        }
    }
}
