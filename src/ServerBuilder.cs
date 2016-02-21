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
    public partial class ServerBuilder : Form {
        private List<SB_ServerData> servers = new List<SB_ServerData>();
        public static string cd = Directory.GetCurrentDirectory();
        private SB_ServerData selectedServer = new SB_ServerData();
        private int selectedIndex = 0;
        private bool updatingData = false;
        private SB_ExceptionManager exceptionManager = new SB_ExceptionManager();

        public ServerBuilder () {
            InitializeComponent();
        }

        private void ServerBuilder_Load (object sender, EventArgs e) {
            LoadServers();
            ReloadServerList();
        }

        private void ServerBuilder_FormClosing (object sender, FormClosingEventArgs e) {
            SaveServers();
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }

        //Loads server list
        private void LoadServers () {
            if (File.Exists(cd + "/serverlist.dat"))
                servers = SaveLoad.LoadFileXml<List<SB_ServerData>>(cd + "/serverlist.dat");
            if (servers == null)
                servers = new List<SB_ServerData>();
            SaveServers();
        }

        //Saves server list
        private void SaveServers () {
            SaveLoad.SaveFileXml(servers, cd + "/serverlist.dat");
        }

        //Reloads the listview with servers
        private void ReloadServerList () {
            updatingData = true;
            listViewServers.Items.Clear();
            listViewServers.SelectedIndices.Clear();
            selectedServer = new SB_ServerData();
            foreach (SB_ServerData server in servers) {
                ListViewItem lvi = new ListViewItem(server.serverName);
                listViewServers.Items.Add(lvi);
            }
            if (selectedIndex < servers.Count && selectedIndex > -1) {
                listViewServers.SelectedIndices.Add(selectedIndex);
                selectedServer = servers[selectedIndex];
            }
            SetInfoBox();
            updatingData = false;
        }

        //Sets the infobox for the selected server
        private void SetInfoBox () {
            updatingData = true;
            textBoxServerName.Text = selectedServer.serverName;
            textBoxServerVersion.Text = selectedServer.serverVersion;
            textBoxMcVersion.Text = selectedServer.mcVersion;
            textBoxSourceFolder.Text = selectedServer.sourceFolder;
            textBoxDestFolder.Text = selectedServer.destFolder;
            textBoxArguments.Text = selectedServer.arguments;
            checkBoxAddBackup.Checked = selectedServer.addBackup;
            updatingData = false;
        }

        //Selects a new server and reloads info box
        private void listViewServers_SelectedIndexChanged (object sender, EventArgs e) {
            if (!updatingData && listViewServers.SelectedIndices.Count > 0) {
                selectedIndex = listViewServers.SelectedIndices[0];
                selectedServer = servers[selectedIndex];
                SetInfoBox();
            }
        }

        //Add empty server to list
        private void buttonAddServer_Click (object sender, EventArgs e) {
            SB_ServerData newServer = new SB_ServerData();
            servers.Add(newServer);
            ReloadServerList();
        }

        //Remove selected server from list
        private void buttonRemoveServer_Click (object sender, EventArgs e) {
            if (selectedIndex >= 0) {
                servers.RemoveAt(selectedIndex);
                if (selectedIndex >= servers.Count)
                    selectedIndex -= 1;
                ReloadServerList();
            }
        }

        //Updates selected server name
        private void textBoxServerName_TextChanged (object sender, EventArgs e) {
            if (!updatingData) {
                selectedServer.serverName = textBoxServerName.Text;
                ReloadServerList();
            }
        }

        //Updates selected server output version
        private void textBoxServerVersion_TextChanged (object sender, EventArgs e) {
            if (!updatingData)
                selectedServer.serverVersion = textBoxServerVersion.Text;
        }

        //Updates selected server minecraft version
        private void textBoxMcVersion_TextChanged (object sender, EventArgs e) {
            if (!updatingData)
                selectedServer.mcVersion = textBoxMcVersion.Text;
        }

        //Updates selected server source folder
        private void textBoxSourceFolder_TextChanged (object sender, EventArgs e) {
            if (!updatingData)
                selectedServer.sourceFolder = textBoxSourceFolder.Text;
        }

        //Updates selected server destination folder
        private void textBoxDestFolder_TextChanged (object sender, EventArgs e) {
            if (!updatingData)
                selectedServer.destFolder = textBoxDestFolder.Text;
        }

        //Updates selected server startup arguments
        private void textBoxArguments_TextChanged (object sender, EventArgs e) {
            if (!updatingData)
                selectedServer.arguments = textBoxArguments.Text;
        }

        //Updates selected server add backup bool
        private void checkBoxAddBackup_CheckedChanged (object sender, EventArgs e) {
            if (!updatingData)
                selectedServer.addBackup = checkBoxAddBackup.Checked;
        }

        //Build server for slected server
        private void buttonBuildServer_Click (object sender, EventArgs e) {
            if (selectedServer.serverName != "NONE" && Directory.Exists(selectedServer.sourceFolder) && Directory.Exists(selectedServer.destFolder))
                selectedServer.BuildServer();
        }

        //Create server copy for slected server
        private void buttonCopyServer_Click (object sender, EventArgs e) {
            if (selectedServer.serverName != "NONE")
                selectedServer.CopyTestServer();
        }

        //Remove server copy for slected server
        private void buttonCleanCopy_Click (object sender, EventArgs e) {
            if (selectedServer.serverName != "NONE")
                selectedServer.ClearTestServer();
        }

        //Exports the server for slected server
        private void buttonExportServer_Click (object sender, EventArgs e) {
            if (selectedServer.serverName != "NONE")
                selectedServer.ExportServer();
        }

        //Opens the exception manager form
        private void buttonExceptionManager_Click (object sender, EventArgs e) {
            exceptionManager.ShowDialog();
        }
    }
}
