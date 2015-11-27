using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Welder {
    public partial class ModManager : Form {
        private RepoData repo = new RepoData();
        private MM_Settings settings = new MM_Settings();
        public static string cd = Directory.GetCurrentDirectory();
        public static List<MM_SiteConfig> sites = new List<MM_SiteConfig>();

        public ModManager () {
            InitializeComponent();
        }

        private void ModManager_Load (object sender, EventArgs e) {
            LoadSettings();
            LoadSiteConfigs();
            UpdateRepoData();
        }

        private void ModManager_FormClosing (object sender, FormClosingEventArgs e) {
            SaveSettings();
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }

        //Loads settings
        private void LoadSettings () {
            if (File.Exists(cd + "/settings_mm.cfg"))
                settings = SaveLoad.LoadFileXml<MM_Settings>(cd + "/settings_mm.cfg");
            if (settings == null)
                settings = new MM_Settings();
            if (settings.repo == "") {
                MM_RepoAsker repoAsker = new MM_RepoAsker(settings.repo, settings.mainMcVersion);
                repoAsker.ShowDialog();
                settings.repo = repoAsker.repoLocation;
                settings.mainMcVersion = repoAsker.repoVersion;
            }
            SaveSettings();
            textBoxRepo.Text = settings.repo;
            textBoxRepoVersion.Text = settings.mainMcVersion;
        }

        //Saves settings
        private void SaveSettings () {
            SaveLoad.SaveFileXml(settings, cd + "/settings_mm.cfg");
        }

        //Loads site configurations
        private void LoadSiteConfigs () {
            sites = SaveLoad.LoadFileXml<List<MM_SiteConfig>>(cd + "/sites.cfg");
            if (sites == null)
                sites = new List<MM_SiteConfig>();
            //sites.Add(new MM_SiteConfig());
            //SaveLoad.SaveFileXml(sites, cd + "/sites.cfg");
        }

        //Updates repo location and repo itself
        private void buttonUpdateRepo_Click (object sender, EventArgs e) {
            settings.repo = textBoxRepo.Text;
            settings.mainMcVersion = textBoxRepoVersion.Text;
            UpdateRepoData();
        }

        //Loads the currently selected repo and reloads displays
        private void UpdateRepoData () {
            repo.LoadRepoFolder(settings.repo, settings.mainMcVersion);
        }
    }
}
