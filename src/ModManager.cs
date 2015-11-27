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
using System.Diagnostics;

namespace Welder {
    public partial class ModManager : Form {
        private RepoData repo = new RepoData();
        private MM_Settings settings = new MM_Settings();
        public static string cd = Directory.GetCurrentDirectory();
        public static List<MM_SiteConfig> sites = new List<MM_SiteConfig>();
        private ModData selectedMod = new ModData();
        private int selectedIndex = 0;
        private bool updatingList = false;

        public ModManager () {
            InitializeComponent();
            //Initiate timer
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Start();
        }

        private void ModManager_Load (object sender, EventArgs e) {
            LoadSettings();
            LoadSiteConfigs();
            UpdateRepoData();
        }

        private void ModManager_FormClosing (object sender, FormClosingEventArgs e) {
            SaveSettings();
            repo.SaveModList();
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }

        //Excecutes every 100ms
        private void timer_Tick (object sender, EventArgs e) {

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
            ReloadModList();
        }

        //Reloads the mod list view and selected mod info
        private void ReloadModList () {
            updatingList = true;
            listViewMods.Items.Clear();
            listViewMods.SelectedIndices.Clear();
            selectedMod = new ModData();

            foreach (ModData mod in repo.modlist) {
                ListViewItem lvi = new ListViewItem(mod.mcVersion);

                lvi.SubItems.Add(mod.modslug);
                lvi.SubItems.Add(mod.sitemode);
                lvi.SubItems.Add(mod.versionLocal);
                lvi.SubItems.Add(mod.versionOnline);
                lvi.SubItems.Add(mod.updateState);
                lvi.SubItems.Add(mod.website1);
                lvi.SubItems.Add(mod.website2);
                lvi.SubItems.Add(mod.website3);
                lvi.SubItems.Add(mod.website4);
                lvi.SubItems.Add(mod.website5);

                lvi.Checked = mod.enabled;
                listViewMods.Items.Add(lvi);
            }

            if (selectedIndex < repo.modlist.Count && selectedIndex > -1) {
                selectedMod = repo.modlist[selectedIndex];
            }

            SetModInfoBox();
            updatingList = false;
        }

        //Sets the currently selected mod info
        private void SetModInfoBox () {
            if (selectedMod.modslug == "NONE") {
                textBoxModSlug.Text = "";
                textBoxModMcVersion.Text = "";
                textBoxModNewMcVersion.Text = "";
                textBoxModVsite.Text = "";
                textBoxModDsite.Text = "";
            }
            else {
                textBoxModSlug.Text = selectedMod.modslug;
                textBoxModMcVersion.Text = selectedMod.mcVersion;
                textBoxModNewMcVersion.Text = selectedMod.mcVersion;
                textBoxModVsite.Text = selectedMod.websiteCheck;
                textBoxModDsite.Text = selectedMod.websiteDownload;
            }
        }

        //Selects a new mod and reloads information
        private void listViewMods_SelectedIndexChanged (object sender, EventArgs e) {
            if (listViewMods.SelectedIndices.Count > 0) {
                selectedIndex = listViewMods.SelectedIndices[0];
                selectedMod = repo.modlist[selectedIndex];
                SetModInfoBox();
            }
        }

        //Changes the enabled state of the checked mod
        private void listViewMods_ItemChecked (object sender, ItemCheckedEventArgs e) {
            if (!updatingList)
                repo.modlist[e.Item.Index].enabled = e.Item.Checked;
        }

        //Updates selecte mod mc version
        private void textBoxModMcVersion_TextChanged (object sender, EventArgs e) {
            selectedMod.mcVersion = textBoxModMcVersion.Text;
            listViewMods.Items[selectedIndex].SubItems[0].Text = selectedMod.mcVersion;
        }

        //Updates selected mod version site
        private void textBoxModVsite_TextChanged (object sender, EventArgs e) {
            selectedMod.websiteCheck = textBoxModVsite.Text;
            selectedMod.UpdateSiteConfig();
            listViewMods.Items[selectedIndex].SubItems[2].Text = selectedMod.sitemode;
        }

        //Opens google search on mod slug
        private void buttonOneGoogle_Click (object sender, EventArgs e) {
            Process.Start("https://www.google.com/?gws_rd=ssl#q=" + selectedMod.modslug.Replace("-", "+") + "+minecraft");
        }

        //Opens current version site
        private void buttonOneOpensite_Click (object sender, EventArgs e) {
            if (MiscFunctions.IsValidSite(selectedMod.websiteCheck))
                Process.Start(selectedMod.websiteCheck);
        }

        //Creates a duplicate of the currently selected mod with a nem mc version
        private void buttonOneDuplicate_Click (object sender, EventArgs e) {
            ModData newMod = new ModData();
            newMod.modslug = selectedMod.modslug;
            newMod.enabled = selectedMod.enabled;
            newMod.websiteCheck = selectedMod.websiteCheck;
            newMod.versionLocal = selectedMod.versionLocal;
            newMod.mcVersion = textBoxModNewMcVersion.Text;
            repo.modlist.Add(newMod);
            ReloadModList();
        }

        //Deletes the currently selected mod
        private void buttonDeleteMod_Click (object sender, EventArgs e) {
            repo.modlist.RemoveAt(selectedIndex);
            if (selectedIndex >= repo.modlist.Count)
                selectedIndex -= 1;
            ReloadModList();
        }
    }
}
