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
    public partial class ConfigPackager : Form {
        private List<CP_ConfigData> packages = new List<CP_ConfigData>();
        public static string cd = Directory.GetCurrentDirectory();
        private CP_ConfigData selectedPackage = new CP_ConfigData();
        private int selectedIndex = 0;
        private bool updatingData = false;
        private bool updatingSelectionData = false;

        public ConfigPackager () {
            InitializeComponent();
        }

        private void ConfigPackager_Load (object sender, EventArgs e) {
            LoadPackages();
            ReloadPackageList();
        }

        private void ConfigPackager_FormClosing (object sender, FormClosingEventArgs e) {
            SavePackages();
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }

        //Loads package list
        private void LoadPackages () {
            if (File.Exists(cd + "/packagelist.dat"))
                packages = SaveLoad.LoadFileXml<List<CP_ConfigData>>(cd + "/packagelist.dat");
            if (packages == null)
                packages = new List<CP_ConfigData>();
            SavePackages();
        }

        //Saves package list
        private void SavePackages () {
            SaveLoad.SaveFileXml(packages, cd + "/packagelist.dat");
        }

        //Reloads the listview with packages
        private void ReloadPackageList () {
            updatingData = true;
            listViewPackages.Items.Clear();
            listViewPackages.SelectedIndices.Clear();
            selectedPackage = new CP_ConfigData();
            foreach (CP_ConfigData package in packages) {
                ListViewItem lvi = new ListViewItem(package.packageName);
                listViewPackages.Items.Add(lvi);
            }
            if (selectedIndex < packages.Count && selectedIndex > -1) {
                listViewPackages.SelectedIndices.Add(selectedIndex);
                selectedPackage = packages[selectedIndex];
            }
            SetInfoBox();
            updatingData = false;
        }

        //Sets the infobox for the selected package
        private void SetInfoBox () {
            updatingData = true;
            textBoxPackageName.Text = selectedPackage.packageName;
            textBoxPackageVersion.Text = selectedPackage.packageVersion;
            textBoxSourceFolder.Text = selectedPackage.sourceFolder;
            textBoxDestinationFolder.Text = selectedPackage.destFolder;
            updatingData = false;
            ReloadSelectionList();
        }

        //Selects a new package and reloads info box
        private void listViewPackages_SelectedIndexChanged (object sender, EventArgs e) {
            if (!updatingData && listViewPackages.SelectedIndices.Count > 0) {
                selectedIndex = listViewPackages.SelectedIndices[0];
                selectedPackage = packages[selectedIndex];
                SetInfoBox();
            }
        }

        //Add empty package to list
        private void buttonAddPackage_Click (object sender, EventArgs e) {
            CP_ConfigData newPackage = new CP_ConfigData();
            packages.Add(newPackage);
            ReloadPackageList();
        }

        //Remove selected package from list
        private void buttonRemovePackage_Click (object sender, EventArgs e) {
            if (selectedIndex >= 0) {
                packages.RemoveAt(selectedIndex);
                if (selectedIndex >= packages.Count)
                    selectedIndex -= 1;
                ReloadPackageList();
            }
        }

        //Updates selected package name
        private void textBoxPackageName_TextChanged (object sender, EventArgs e) {
            if (!updatingData) {
                selectedPackage.packageName = textBoxPackageName.Text;
                ReloadPackageList();
            }
        }

        //Updates selected package version
        private void textBoxPackageVersion_TextChanged (object sender, EventArgs e) {
            if (!updatingData)
                selectedPackage.packageVersion = textBoxPackageVersion.Text;
        }

        //Updates selected package source folder
        private void textBoxSourceFolder_TextChanged (object sender, EventArgs e) {
            if (!updatingData)
                selectedPackage.sourceFolder = textBoxSourceFolder.Text;
        }

        //Updates selected package destination folder
        private void textBoxDestinationFolder_TextChanged (object sender, EventArgs e) {
            if (!updatingData)
                selectedPackage.destFolder = textBoxDestinationFolder.Text;
        }

        //Build the selected package with the current settings
        private void buttonBuildPackage_Click (object sender, EventArgs e) {
            if (Directory.Exists(selectedPackage.sourceFolder) && Directory.Exists(selectedPackage.destFolder))
                selectedPackage.BuildPackage();
        }

        //Reloads the listview with selections
        private void ReloadSelectionList () {
            updatingSelectionData = true;
            listViewSelections.Items.Clear();
            listViewSelections.SelectedIndices.Clear();
            for (int i = 0; i < selectedPackage.selectionFolder.Count; i++) {
                ListViewItem lvi = new ListViewItem(selectedPackage.selectionFolder[i]);
                lvi.SubItems.Add(selectedPackage.selectionWildcards[i]);
                listViewSelections.Items.Add(lvi);
            }
            if (selectedPackage.selectedSelection < selectedPackage.selectionFolder.Count && selectedPackage.selectedSelection > -1)
                listViewSelections.SelectedIndices.Add(selectedIndex);
            SetSelectionInfoBoxes();
            updatingSelectionData = false;
        }

        //Changes the selected index for the selection on the selected package
        private void listViewSelections_SelectedIndexChanged (object sender, EventArgs e) {
            if (!updatingSelectionData && listViewSelections.SelectedIndices.Count > 0) {
                selectedPackage.selectedSelection = listViewSelections.SelectedIndices[0];
                SetSelectionInfoBoxes();
            }
        }

        //Sets the info boxes for the selected selection
        private void SetSelectionInfoBoxes () {
            updatingSelectionData = true;
            if (selectedPackage.selectedSelection >= 0) {
                textBoxSelSubfolder.Text = selectedPackage.selectionFolder[selectedPackage.selectedSelection];
                textBoxSelWildcards.Text = selectedPackage.selectionWildcards[selectedPackage.selectedSelection];
            }
            updatingSelectionData = false;
        }

        //Adds a new selection on the selected package
        private void buttonAddSelection_Click (object sender, EventArgs e) {
            selectedPackage.selectionFolder.Add("");
            selectedPackage.selectionWildcards.Add("*.*");
            ReloadSelectionList();
        }

        //Removes the selected selection from the selected package
        private void buttonRemoveSelection_Click (object sender, EventArgs e) {
            if (selectedPackage.selectedSelection >= 0) {
                selectedPackage.selectionFolder.RemoveAt(selectedPackage.selectedSelection);
                selectedPackage.selectionWildcards.RemoveAt(selectedPackage.selectedSelection);
                if (selectedPackage.selectedSelection >= selectedPackage.selectionFolder.Count)
                    selectedPackage.selectedSelection -= 1;
                ReloadSelectionList();
            }
        }

        //Saves the settings for the selected selection
        private void buttonSaveSelection_Click (object sender, EventArgs e) {
            if (!updatingSelectionData && selectedPackage.selectedSelection >= 0) {
                selectedPackage.selectionFolder[selectedPackage.selectedSelection] = textBoxSelSubfolder.Text;
                selectedPackage.selectionWildcards[selectedPackage.selectedSelection] = textBoxSelWildcards.Text;
                ReloadSelectionList();
            }
        }

        //Loads the default selections on the selected package
        private void buttonLoadDefaultSelection_Click (object sender, EventArgs e) {
            selectedPackage.SetDefaultSelections();
            ReloadSelectionList();
        }
    }
}
