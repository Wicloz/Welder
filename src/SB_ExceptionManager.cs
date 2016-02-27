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
    public partial class SB_ExceptionManager : Form {
        private static List<string> exceptions = new List<string>();
        private int selectedIndex = -1;
        private bool updatingData = false;

        public SB_ExceptionManager () {
            InitializeComponent();
            LoadExceptions();
            ReloadExceptionList();
        }

        private void SB_ExceptionManager_FormClosing (object sender, FormClosingEventArgs e) {
            SaveExceptions();
        }

        //Loads exception list
        private void LoadExceptions () {
            if (File.Exists(ServerBuilder.cd + "/server_exceptions.cfg"))
                exceptions = SaveLoad.LoadFilePlain(ServerBuilder.cd + "/server_exceptions.cfg");
            else
                exceptions = CreateDefaultList();
            if (exceptions == null)
                exceptions = new List<string>();
            SaveExceptions();
        }

        //Saves exception list
        private void SaveExceptions () {
            SaveLoad.SaveFilePlain(exceptions, ServerBuilder.cd + "/server_exceptions.cfg");
        }

        //Reloads the listview with exceptions
        private void ReloadExceptionList () {
            updatingData = true;
            listViewExceptions.Items.Clear();
            listViewExceptions.SelectedIndices.Clear();
            foreach (string mod in exceptions) {
                ListViewItem lvi = new ListViewItem(mod);
                listViewExceptions.Items.Add(lvi);
            }
            if (selectedIndex < exceptions.Count && selectedIndex > -1)
                listViewExceptions.SelectedIndices.Add(selectedIndex);
            SetInfoBox();
            updatingData = false;
        }

        //Sets the content of the textbox based on the selection
        private void SetInfoBox () {
            if (selectedIndex >= 0) {
                updatingData = true;
                textBoxName.Text = exceptions[selectedIndex];
                updatingData = false;
            }
        }

        //Marks a new exception as selected and reloads the info box
        private void listViewExceptions_SelectedIndexChanged (object sender, EventArgs e) {
            if (!updatingData) {
                if (listViewExceptions.SelectedIndices.Count > 0)
                    selectedIndex = listViewExceptions.SelectedIndices[0];
                else
                    selectedIndex = -1;
                SetInfoBox();
            }
        }

        //Changes the name of the currently selected esception
        private void textBoxName_TextChanged (object sender, EventArgs e) {
            if (!updatingData && selectedIndex >= 0) {
                exceptions[selectedIndex] = textBoxName.Text;
                ReloadExceptionList();
            }
        }

        //Adds a new exception with the current text
        private void buttonAdd_Click (object sender, EventArgs e) {
            exceptions.Add(textBoxName.Text);
            selectedIndex = exceptions.Count - 1;
            ReloadExceptionList();
        }

        //Removes the selected exception
        private void buttonRemove_Click (object sender, EventArgs e) {
            if (selectedIndex >= 0) {
                exceptions.RemoveAt(selectedIndex);
                if (selectedIndex >= exceptions.Count)
                    selectedIndex -= 1;
                ReloadExceptionList();
            }
        }

        //Returns a list with some deafault exceptions
        private List<string> CreateDefaultList () {
            List<string> list = new List<string>();
            list.Add("damageindicator");
            list.Add("bacr");
            list.Add("minimap");
            list.Add("inventorytweaks");
            list.Add("mapwriter");
            list.Add("dynamiclights");
            list.Add("shatter");
            list.Add("bettertitlescreen");
            list.Add("notenoughkeys");
            list.Add("optifine");
            list.Add("java7checker");
            list.Add("java8checker");
            list.Add("defaultkeys");
            list.Add("neat");
            list.Add("ding");
            list.Add("betterrain");
            list.Add("stellarsky");
            return list;
        }

        //Returns true when a mod should not be on a server
        public static bool IsException (string modname) {
            foreach (string exception in exceptions) {
                if (MiscFunctions.CleanString(modname).Contains(exception))
                    return true;
            }
            return false;
        }
    }
}
