namespace Welder {
    partial class ServerBuilder {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerBuilder));
            this.listViewServers = new System.Windows.Forms.ListView();
            this.serverName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDestFolder = new System.Windows.Forms.TextBox();
            this.checkBoxAddBackup = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSourceFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.textBoxMcVersion = new System.Windows.Forms.TextBox();
            this.textBoxServerVersion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuildServer = new System.Windows.Forms.Button();
            this.buttonCopyServer = new System.Windows.Forms.Button();
            this.buttonExportServer = new System.Windows.Forms.Button();
            this.buttonCleanCopy = new System.Windows.Forms.Button();
            this.buttonAddServer = new System.Windows.Forms.Button();
            this.buttonRemoveServer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewServers
            // 
            this.listViewServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serverName});
            this.listViewServers.FullRowSelect = true;
            this.listViewServers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewServers.HideSelection = false;
            this.listViewServers.Location = new System.Drawing.Point(12, 12);
            this.listViewServers.MultiSelect = false;
            this.listViewServers.Name = "listViewServers";
            this.listViewServers.Size = new System.Drawing.Size(170, 499);
            this.listViewServers.TabIndex = 0;
            this.listViewServers.UseCompatibleStateImageBehavior = false;
            this.listViewServers.View = System.Windows.Forms.View.Details;
            this.listViewServers.SelectedIndexChanged += new System.EventHandler(this.listViewServers_SelectedIndexChanged);
            // 
            // serverName
            // 
            this.serverName.Text = "Server Name";
            this.serverName.Width = 165;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(188, 196);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(888, 373);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxDestFolder);
            this.groupBox1.Controls.Add(this.checkBoxAddBackup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSourceFolder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxServerName);
            this.groupBox1.Controls.Add(this.textBoxMcVersion);
            this.groupBox1.Controls.Add(this.textBoxServerVersion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Server Version:";
            // 
            // textBoxDestFolder
            // 
            this.textBoxDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestFolder.Location = new System.Drawing.Point(153, 123);
            this.textBoxDestFolder.Name = "textBoxDestFolder";
            this.textBoxDestFolder.Size = new System.Drawing.Size(729, 20);
            this.textBoxDestFolder.TabIndex = 9;
            this.textBoxDestFolder.TextChanged += new System.EventHandler(this.textBoxDestFolder_TextChanged);
            // 
            // checkBoxAddBackup
            // 
            this.checkBoxAddBackup.AutoSize = true;
            this.checkBoxAddBackup.Location = new System.Drawing.Point(153, 149);
            this.checkBoxAddBackup.Name = "checkBoxAddBackup";
            this.checkBoxAddBackup.Size = new System.Drawing.Size(174, 17);
            this.checkBoxAddBackup.TabIndex = 8;
            this.checkBoxAddBackup.Text = "Add backup code to startup file";
            this.checkBoxAddBackup.UseVisualStyleBackColor = true;
            this.checkBoxAddBackup.CheckedChanged += new System.EventHandler(this.checkBoxAddBackup_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Package Destination Folder:";
            // 
            // textBoxSourceFolder
            // 
            this.textBoxSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceFolder.Location = new System.Drawing.Point(153, 97);
            this.textBoxSourceFolder.Name = "textBoxSourceFolder";
            this.textBoxSourceFolder.Size = new System.Drawing.Size(729, 20);
            this.textBoxSourceFolder.TabIndex = 6;
            this.textBoxSourceFolder.TextChanged += new System.EventHandler(this.textBoxSourceFolder_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modpack Source Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minecraft Version:";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerName.Location = new System.Drawing.Point(153, 19);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(729, 20);
            this.textBoxServerName.TabIndex = 3;
            this.textBoxServerName.TextChanged += new System.EventHandler(this.textBoxServerName_TextChanged);
            // 
            // textBoxMcVersion
            // 
            this.textBoxMcVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMcVersion.Location = new System.Drawing.Point(153, 71);
            this.textBoxMcVersion.Name = "textBoxMcVersion";
            this.textBoxMcVersion.Size = new System.Drawing.Size(729, 20);
            this.textBoxMcVersion.TabIndex = 2;
            this.textBoxMcVersion.TextChanged += new System.EventHandler(this.textBoxMcVersion_TextChanged);
            // 
            // textBoxServerVersion
            // 
            this.textBoxServerVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerVersion.Location = new System.Drawing.Point(153, 45);
            this.textBoxServerVersion.Name = "textBoxServerVersion";
            this.textBoxServerVersion.Size = new System.Drawing.Size(729, 20);
            this.textBoxServerVersion.TabIndex = 1;
            this.textBoxServerVersion.TextChanged += new System.EventHandler(this.textBoxServerVersion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // buttonBuildServer
            // 
            this.buttonBuildServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuildServer.Location = new System.Drawing.Point(1082, 12);
            this.buttonBuildServer.Name = "buttonBuildServer";
            this.buttonBuildServer.Size = new System.Drawing.Size(150, 30);
            this.buttonBuildServer.TabIndex = 3;
            this.buttonBuildServer.Text = "Build Server";
            this.buttonBuildServer.UseVisualStyleBackColor = true;
            this.buttonBuildServer.Click += new System.EventHandler(this.buttonBuildServer_Click);
            // 
            // buttonCopyServer
            // 
            this.buttonCopyServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyServer.Location = new System.Drawing.Point(1082, 48);
            this.buttonCopyServer.Name = "buttonCopyServer";
            this.buttonCopyServer.Size = new System.Drawing.Size(150, 30);
            this.buttonCopyServer.TabIndex = 4;
            this.buttonCopyServer.Text = "Create Copy for Testing";
            this.buttonCopyServer.UseVisualStyleBackColor = true;
            this.buttonCopyServer.Click += new System.EventHandler(this.buttonCopyServer_Click);
            // 
            // buttonExportServer
            // 
            this.buttonExportServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportServer.Location = new System.Drawing.Point(1082, 120);
            this.buttonExportServer.Name = "buttonExportServer";
            this.buttonExportServer.Size = new System.Drawing.Size(150, 30);
            this.buttonExportServer.TabIndex = 5;
            this.buttonExportServer.Text = "Package Server";
            this.buttonExportServer.UseVisualStyleBackColor = true;
            this.buttonExportServer.Click += new System.EventHandler(this.buttonExportServer_Click);
            // 
            // buttonCleanCopy
            // 
            this.buttonCleanCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCleanCopy.Location = new System.Drawing.Point(1082, 84);
            this.buttonCleanCopy.Name = "buttonCleanCopy";
            this.buttonCleanCopy.Size = new System.Drawing.Size(150, 30);
            this.buttonCleanCopy.TabIndex = 7;
            this.buttonCleanCopy.Text = "Remove Copy";
            this.buttonCleanCopy.UseVisualStyleBackColor = true;
            this.buttonCleanCopy.Click += new System.EventHandler(this.buttonCleanCopy_Click);
            // 
            // buttonAddServer
            // 
            this.buttonAddServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddServer.Location = new System.Drawing.Point(12, 517);
            this.buttonAddServer.Name = "buttonAddServer";
            this.buttonAddServer.Size = new System.Drawing.Size(170, 23);
            this.buttonAddServer.TabIndex = 8;
            this.buttonAddServer.Text = "Add Server";
            this.buttonAddServer.UseVisualStyleBackColor = true;
            this.buttonAddServer.Click += new System.EventHandler(this.buttonAddServer_Click);
            // 
            // buttonRemoveServer
            // 
            this.buttonRemoveServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveServer.Location = new System.Drawing.Point(12, 546);
            this.buttonRemoveServer.Name = "buttonRemoveServer";
            this.buttonRemoveServer.Size = new System.Drawing.Size(170, 23);
            this.buttonRemoveServer.TabIndex = 9;
            this.buttonRemoveServer.Text = "Delete Server";
            this.buttonRemoveServer.UseVisualStyleBackColor = true;
            this.buttonRemoveServer.Click += new System.EventHandler(this.buttonRemoveServer_Click);
            // 
            // ServerBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 581);
            this.Controls.Add(this.buttonRemoveServer);
            this.Controls.Add(this.buttonAddServer);
            this.Controls.Add(this.buttonCleanCopy);
            this.Controls.Add(this.buttonExportServer);
            this.Controls.Add(this.buttonCopyServer);
            this.Controls.Add(this.buttonBuildServer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listViewServers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerBuilder";
            this.Text = "Server Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerBuilder_FormClosing);
            this.Load += new System.EventHandler(this.ServerBuilder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewServers;
        private System.Windows.Forms.ColumnHeader serverName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSourceFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.TextBox textBoxMcVersion;
        private System.Windows.Forms.TextBox textBoxServerVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAddBackup;
        private System.Windows.Forms.Button buttonBuildServer;
        private System.Windows.Forms.Button buttonCopyServer;
        private System.Windows.Forms.Button buttonExportServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDestFolder;
        private System.Windows.Forms.Button buttonCleanCopy;
        private System.Windows.Forms.Button buttonAddServer;
        private System.Windows.Forms.Button buttonRemoveServer;
    }
}