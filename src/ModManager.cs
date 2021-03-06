﻿using System;
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
        private static ModManager acces;
        private MM_RepoData repo = new MM_RepoData();
        private MM_Settings settings = new MM_Settings();
        public static string cd = Directory.GetCurrentDirectory();
        public static List<MM_SiteConfig> sites = new List<MM_SiteConfig>();
        private MM_ModData selectedMod = new MM_ModData();
        private int selectedIndex = 0;
        private bool updatingData = false;

        public static string solderUrl {
            get {
                return acces.textBoxSolderUrl.Text;
            }
        }
        public static string solderEmail {
            get {
                return acces.textBoxSolderMail.Text;
            }
        }
        public static string solderPassword {
            get {
                return acces.textBoxSolderPass.Text;
            }
        }

        public ModManager () {
            InitializeComponent();
            acces = this;
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

        //Main loop for mod actions, excecutes every 100ms
        private void timer_Tick (object sender, EventArgs e) {
            if (repo.mustReloadListView) {
                repo.mustReloadListView = false;
                ReloadModList();
                return;
            }

            ActionStates state = ActionStates.idle;
            foreach (MM_ModData mod in repo.modlist) {
                if (mod.enabled) {
                    if ((int)state < 1 && mod.queuedUpdate)
                        state = ActionStates.update;
                    else if ((int)state < 2 && mod.queuedCheck)
                        state = ActionStates.check;
                    else if ((int)state < 3 && mod.queuedFind)
                        state = ActionStates.find;
                }
            }

            switch (state) {
                case ActionStates.find:
                    foreach (MM_ModData mod in repo.modlist) {
                        if (mod.enabled) {
                            if (mod.queuedFind && !mod.busyFind)
                                mod.FindWebsiteUrl();
                        }
                    }
                    break;

                case ActionStates.check:
                    foreach (MM_ModData mod in repo.modlist) {
                        if (mod.enabled) {
                            if (mod.enabled) {
                                if (mod.busyCheck)
                                    break;
                                else if (mod.queuedCheck) {
                                    mod.CheckForUpdate();
                                    break;
                                }
                            }
                        }
                    }
                    break;

                case ActionStates.update:
                    foreach (MM_ModData mod in repo.modlist) {
                        if (mod.enabled) {
                            if (mod.enabled) {
                                if (mod.busyUpdate)
                                    break;
                                else if (mod.queuedUpdate) {
                                    mod.UpdateMod();
                                    break;
                                }
                            }
                        }
                    }
                    break;
            }

            for (int i = 0; i < repo.modlist.Count; i++) {
                MM_ModData mod = repo.modlist[i];
                if (mod.updateList || mod.actionState != listViewMods.Items[i].SubItems[5].Text) {
                    mod.updateList = false;
                    ReloadModListAt(i);
                }
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
            textBoxSolderUrl.Text = settings.solderUrl;
            textBoxSolderMail.Text = settings.solderMail;
            textBoxSolderPass.Text = settings.solderPass;
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
            updatingData = true;
            listViewMods.Items.Clear();
            listViewMods.SelectedIndices.Clear();
            selectedMod = new MM_ModData();

            foreach (MM_ModData mod in repo.modlist) {
                ListViewItem lvi = new ListViewItem(mod.mcVersion);

                lvi.SubItems.Add(mod.modslug);
                lvi.SubItems.Add(mod.urlState);
                lvi.SubItems.Add(mod.versionLocal);
                lvi.SubItems.Add(mod.versionOnline);
                lvi.SubItems.Add(mod.actionState);
                lvi.SubItems.Add(mod.website1);
                lvi.SubItems.Add(mod.website2);
                lvi.SubItems.Add(mod.website3);
                lvi.SubItems.Add(mod.website4);
                lvi.SubItems.Add(mod.website5);

                lvi.Checked = mod.enabled;
                listViewMods.Items.Add(lvi);
            }

            if (selectedIndex < repo.modlist.Count && selectedIndex > -1) {
                listViewMods.SelectedIndices.Add(selectedIndex);
                selectedMod = repo.modlist[selectedIndex];
            }

            SetModInfoBox();
            updatingData = false;
        }

        //Reloads the line of the modlistview at a certain index
        private void ReloadModListAt (int index) {
            MM_ModData mod = repo.modlist[index];
            listViewMods.Items[index].SubItems[0].Text = mod.mcVersion;
            listViewMods.Items[index].SubItems[1].Text = mod.modslug;
            listViewMods.Items[index].SubItems[2].Text = mod.urlState;
            listViewMods.Items[index].SubItems[3].Text = mod.versionLocal;
            listViewMods.Items[index].SubItems[4].Text = mod.versionOnline;
            listViewMods.Items[index].SubItems[5].Text = mod.actionState;
            listViewMods.Items[index].SubItems[6].Text = mod.website1;
            listViewMods.Items[index].SubItems[7].Text = mod.website2;
            listViewMods.Items[index].SubItems[8].Text = mod.website3;
            listViewMods.Items[index].SubItems[9].Text = mod.website4;
            listViewMods.Items[index].SubItems[10].Text = mod.website5;
            if (index == selectedIndex)
                SetModInfoBox();
        }

        //Sets the currently selected mod info
        private void SetModInfoBox () {
            updatingData = true;
            if (selectedMod.modslug == "NONE") {
                textBoxModSlug.Text = "";
                textBoxModMcVersion.Text = "";
                textBoxModNewMcVersion.Text = "";
                textBoxModVsite.Text = "";
                textBoxModDsite.Text = "";
                labelSiteMode.Text = "Unsupported";
                checkBoxCanUpdate.Checked = false;
            }
            else {
                textBoxModSlug.Text = selectedMod.modslug;
                textBoxModMcVersion.Text = selectedMod.mcVersion;
                textBoxModNewMcVersion.Text = selectedMod.mcVersion;
                textBoxModVsite.Text = selectedMod.websiteCheck;
                textBoxModDsite.Text = selectedMod.websiteDownload;
                checkBoxCanUpdate.Checked = selectedMod.canUpdate;
                if (selectedMod.urlState == "")
                    labelSiteMode.Text = "No Site";
                else
                    labelSiteMode.Text = selectedMod.urlState;
            }
            updatingData = false;
        }

        //Selects a new mod and reloads information
        private void listViewMods_SelectedIndexChanged (object sender, EventArgs e) {
            if (!updatingData && listViewMods.SelectedIndices.Count > 0) {
                selectedIndex = listViewMods.SelectedIndices[0];
                selectedMod = repo.modlist[selectedIndex];
                SetModInfoBox();
            }
        }

        //Changes the enabled state of the checked mod
        private void listViewMods_ItemChecked (object sender, ItemCheckedEventArgs e) {
            if (!updatingData)
                repo.modlist[e.Item.Index].enabled = e.Item.Checked;
        }

        //Changes selected mod modslug
        private void textBoxModSlug_TextChanged (object sender, EventArgs e) {
            if (!updatingData) {
                selectedMod.modslug = textBoxModSlug.Text;
                listViewMods.Items[selectedIndex].SubItems[1].Text = selectedMod.modslug;
            }
        }

        //Updates selected mod mc version
        private void textBoxModMcVersion_TextChanged (object sender, EventArgs e) {
            if (!updatingData) {
                selectedMod.mcVersion = textBoxModMcVersion.Text;
                listViewMods.Items[selectedIndex].SubItems[0].Text = selectedMod.mcVersion;
            }
        }

        //Updates selected mod version site
        private void textBoxModVsite_TextChanged (object sender, EventArgs e) {
            if (!updatingData) {
                selectedMod.websiteCheck = textBoxModVsite.Text;
                selectedMod.UpdateSiteConfig();
                listViewMods.Items[selectedIndex].SubItems[2].Text = selectedMod.urlState;
            }
        }

        //Changes selected mod can update state
        private void checkBoxCanUpdate_CheckedChanged (object sender, EventArgs e) {
            if (!updatingData) {
                selectedMod.canUpdate = checkBoxCanUpdate.Checked;
                listViewMods.Items[selectedIndex].SubItems[5].Text = selectedMod.actionState;
            }
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
            MM_ModData newMod = new MM_ModData();
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

        //Add a new empty mod to the list
        private void buttonAddMod_Click (object sender, EventArgs e) {
            MM_ModData newMod = new MM_ModData();
            newMod.enabled = false;
            newMod.mcVersion = settings.mainMcVersion;
            newMod.repoFolder = settings.repo;
            repo.modlist.Add(newMod);
            ReloadModList();
        }

        //Set the queued state of update on the selected mod
        private void buttonOneUpdate_Click (object sender, EventArgs e) {
            selectedMod.queuedUpdate = true;
        }

        //Set the queued state of check on the selected mod
        private void buttonOneCheck_Click (object sender, EventArgs e) {
            selectedMod.queuedCheck = true;
        }

        //Set the queued state of find on the selected mod
        private void buttonOneFind_Click (object sender, EventArgs e) {
            selectedMod.queuedFind = true;
        }

        //Set the queued state of update on all mods
        private void buttonAllUpdate_Click (object sender, EventArgs e) {
            foreach (MM_ModData mod in repo.modlist) {
                if (mod.enabled && mod.canUpdate)
                    mod.queuedUpdate = true;
            }
        }

        //Set the queued state of check on all mods
        private void buttonAllCheck_Click (object sender, EventArgs e) {
            foreach (MM_ModData mod in repo.modlist) {
                if (mod.enabled)
                    mod.queuedCheck = true;
            }
        }

        //Set the queued state of find on all mods
        private void buttonAllFind_Click (object sender, EventArgs e) {
            foreach (MM_ModData mod in repo.modlist) {
                if (mod.enabled && mod.urlState == "")
                    mod.queuedFind = true;
            }
        }

        //Sets the link to the online solder list
        private void textBoxSolderUrl_TextChanged (object sender, EventArgs e) {
            settings.solderUrl = textBoxSolderUrl.Text;
        }

        //Sets the email addres for logging into solder
        private void textBoxSolderMail_TextChanged (object sender, EventArgs e) {
            settings.solderMail = textBoxSolderMail.Text;
        }

        //Sets the password for logging into solder
        private void textBoxSolderPass_TextChanged (object sender, EventArgs e) {
            settings.solderPass = textBoxSolderPass.Text;
        }

        //Downlads the solder modlist and adds all missing mods
        private void buttonSolderSync_Click (object sender, EventArgs e) {
            if (!settings.solderUrl.EndsWith("/")) {
                settings.solderUrl += "/";
                textBoxSolderUrl.Text = settings.solderUrl;
            }
            if (MiscFunctions.IsValidSite(settings.solderUrl))
                repo.UpdateListFromSolder(settings.solderUrl, settings.solderMail, settings.solderPass);
        }
    }
}
