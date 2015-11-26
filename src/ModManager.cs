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
        private static string cd = Directory.GetCurrentDirectory();

        public ModManager () {
            InitializeComponent();
        }

        private void ModManager_Load (object sender, EventArgs e) {
            LoadSettings();
        }

        private void ModManager_FormClosing (object sender, FormClosingEventArgs e) {
            SaveSettings();
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }

        private void LoadSettings () {
            if (File.Exists(cd + "/settings.cfg"))
                settings = SaveLoad.LoadFileXml<MM_Settings>(cd + "/settings.cfg");
            if (settings == null)
                settings = new MM_Settings();
            if (settings.repo == "") {
                MM_RepoAsker repoAsker = new MM_RepoAsker(settings.repo);
                repoAsker.ShowDialog();
                settings.repo = repoAsker.repoLocation;
            }
            SaveSettings();
            textBoxRepo.Text = settings.repo;
        }

        private void SaveSettings () {
            SaveLoad.SaveFileXml(settings, cd + "/settings.cfg");
        }

        private void buttonUpdateRepo_Click (object sender, EventArgs e) {
            settings.repo = textBoxRepo.Text;
        }
    }
}
