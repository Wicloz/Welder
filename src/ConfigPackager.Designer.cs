namespace Welder {
    partial class ConfigPackager {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigPackager));
            this.listViewPackages = new System.Windows.Forms.ListView();
            this.modpackName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.textBoxSourceFolder = new System.Windows.Forms.TextBox();
            this.textBoxPackageVersion = new System.Windows.Forms.TextBox();
            this.textBoxPackageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddPackage = new System.Windows.Forms.Button();
            this.buttonRemovePackage = new System.Windows.Forms.Button();
            this.listViewSelections = new System.Windows.Forms.ListView();
            this.subfolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wildcards = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBuildPackage = new System.Windows.Forms.Button();
            this.buttonAddSelection = new System.Windows.Forms.Button();
            this.textBoxSelSubfolder = new System.Windows.Forms.TextBox();
            this.buttonRemoveSelection = new System.Windows.Forms.Button();
            this.textBoxSelWildcards = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSaveSelection = new System.Windows.Forms.Button();
            this.buttonLoadDefaultSelection = new System.Windows.Forms.Button();
            this.checkBoxExclusion = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPackages
            // 
            this.listViewPackages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewPackages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modpackName});
            this.listViewPackages.FullRowSelect = true;
            this.listViewPackages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewPackages.HideSelection = false;
            this.listViewPackages.Location = new System.Drawing.Point(12, 12);
            this.listViewPackages.MultiSelect = false;
            this.listViewPackages.Name = "listViewPackages";
            this.listViewPackages.Size = new System.Drawing.Size(170, 499);
            this.listViewPackages.TabIndex = 0;
            this.listViewPackages.UseCompatibleStateImageBehavior = false;
            this.listViewPackages.View = System.Windows.Forms.View.Details;
            this.listViewPackages.SelectedIndexChanged += new System.EventHandler(this.listViewPackages_SelectedIndexChanged);
            // 
            // modpackName
            // 
            this.modpackName.Text = "Modpack Name";
            this.modpackName.Width = 165;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(718, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(358, 421);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxDestinationFolder);
            this.groupBox1.Controls.Add(this.textBoxSourceFolder);
            this.groupBox1.Controls.Add(this.textBoxPackageVersion);
            this.groupBox1.Controls.Add(this.textBoxPackageName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Package Destination Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modpack Folder:";
            // 
            // textBoxDestinationFolder
            // 
            this.textBoxDestinationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestinationFolder.Location = new System.Drawing.Point(153, 100);
            this.textBoxDestinationFolder.Name = "textBoxDestinationFolder";
            this.textBoxDestinationFolder.Size = new System.Drawing.Size(729, 20);
            this.textBoxDestinationFolder.TabIndex = 5;
            this.textBoxDestinationFolder.TextChanged += new System.EventHandler(this.textBoxDestinationFolder_TextChanged);
            // 
            // textBoxSourceFolder
            // 
            this.textBoxSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceFolder.Location = new System.Drawing.Point(153, 73);
            this.textBoxSourceFolder.Name = "textBoxSourceFolder";
            this.textBoxSourceFolder.Size = new System.Drawing.Size(729, 20);
            this.textBoxSourceFolder.TabIndex = 4;
            this.textBoxSourceFolder.TextChanged += new System.EventHandler(this.textBoxSourceFolder_TextChanged);
            // 
            // textBoxPackageVersion
            // 
            this.textBoxPackageVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPackageVersion.Location = new System.Drawing.Point(153, 46);
            this.textBoxPackageVersion.Name = "textBoxPackageVersion";
            this.textBoxPackageVersion.Size = new System.Drawing.Size(729, 20);
            this.textBoxPackageVersion.TabIndex = 3;
            this.textBoxPackageVersion.TextChanged += new System.EventHandler(this.textBoxPackageVersion_TextChanged);
            // 
            // textBoxPackageName
            // 
            this.textBoxPackageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPackageName.Location = new System.Drawing.Point(153, 19);
            this.textBoxPackageName.Name = "textBoxPackageName";
            this.textBoxPackageName.Size = new System.Drawing.Size(729, 20);
            this.textBoxPackageName.TabIndex = 2;
            this.textBoxPackageName.TextChanged += new System.EventHandler(this.textBoxPackageName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Package Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package Name:";
            // 
            // buttonAddPackage
            // 
            this.buttonAddPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddPackage.Location = new System.Drawing.Point(12, 517);
            this.buttonAddPackage.Name = "buttonAddPackage";
            this.buttonAddPackage.Size = new System.Drawing.Size(170, 23);
            this.buttonAddPackage.TabIndex = 5;
            this.buttonAddPackage.Text = "Add Package";
            this.buttonAddPackage.UseVisualStyleBackColor = true;
            this.buttonAddPackage.Click += new System.EventHandler(this.buttonAddPackage_Click);
            // 
            // buttonRemovePackage
            // 
            this.buttonRemovePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemovePackage.Location = new System.Drawing.Point(12, 546);
            this.buttonRemovePackage.Name = "buttonRemovePackage";
            this.buttonRemovePackage.Size = new System.Drawing.Size(170, 23);
            this.buttonRemovePackage.TabIndex = 6;
            this.buttonRemovePackage.Text = "Delete Package";
            this.buttonRemovePackage.UseVisualStyleBackColor = true;
            this.buttonRemovePackage.Click += new System.EventHandler(this.buttonRemovePackage_Click);
            // 
            // listViewSelections
            // 
            this.listViewSelections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewSelections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subfolder,
            this.wildcards});
            this.listViewSelections.FullRowSelect = true;
            this.listViewSelections.GridLines = true;
            this.listViewSelections.HideSelection = false;
            this.listViewSelections.Location = new System.Drawing.Point(188, 148);
            this.listViewSelections.MultiSelect = false;
            this.listViewSelections.Name = "listViewSelections";
            this.listViewSelections.Size = new System.Drawing.Size(524, 334);
            this.listViewSelections.TabIndex = 7;
            this.listViewSelections.UseCompatibleStateImageBehavior = false;
            this.listViewSelections.View = System.Windows.Forms.View.Details;
            this.listViewSelections.SelectedIndexChanged += new System.EventHandler(this.listViewSelections_SelectedIndexChanged);
            // 
            // subfolder
            // 
            this.subfolder.Text = "Subfolder";
            this.subfolder.Width = 356;
            // 
            // wildcards
            // 
            this.wildcards.Text = "Wildcards";
            this.wildcards.Width = 163;
            // 
            // buttonBuildPackage
            // 
            this.buttonBuildPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuildPackage.Location = new System.Drawing.Point(1082, 12);
            this.buttonBuildPackage.Name = "buttonBuildPackage";
            this.buttonBuildPackage.Size = new System.Drawing.Size(150, 35);
            this.buttonBuildPackage.TabIndex = 8;
            this.buttonBuildPackage.Text = "Create Package";
            this.buttonBuildPackage.UseVisualStyleBackColor = true;
            this.buttonBuildPackage.Click += new System.EventHandler(this.buttonBuildPackage_Click);
            // 
            // buttonAddSelection
            // 
            this.buttonAddSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddSelection.Location = new System.Drawing.Point(188, 517);
            this.buttonAddSelection.Name = "buttonAddSelection";
            this.buttonAddSelection.Size = new System.Drawing.Size(134, 23);
            this.buttonAddSelection.TabIndex = 9;
            this.buttonAddSelection.Text = "Add Selection";
            this.buttonAddSelection.UseVisualStyleBackColor = true;
            this.buttonAddSelection.Click += new System.EventHandler(this.buttonAddSelection_Click);
            // 
            // textBoxSelSubfolder
            // 
            this.textBoxSelSubfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSelSubfolder.Location = new System.Drawing.Point(391, 517);
            this.textBoxSelSubfolder.Name = "textBoxSelSubfolder";
            this.textBoxSelSubfolder.Size = new System.Drawing.Size(203, 20);
            this.textBoxSelSubfolder.TabIndex = 10;
            // 
            // buttonRemoveSelection
            // 
            this.buttonRemoveSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveSelection.Location = new System.Drawing.Point(188, 546);
            this.buttonRemoveSelection.Name = "buttonRemoveSelection";
            this.buttonRemoveSelection.Size = new System.Drawing.Size(134, 23);
            this.buttonRemoveSelection.TabIndex = 11;
            this.buttonRemoveSelection.Text = "Remove Selection";
            this.buttonRemoveSelection.UseVisualStyleBackColor = true;
            this.buttonRemoveSelection.Click += new System.EventHandler(this.buttonRemoveSelection_Click);
            // 
            // textBoxSelWildcards
            // 
            this.textBoxSelWildcards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSelWildcards.Location = new System.Drawing.Point(391, 546);
            this.textBoxSelWildcards.Name = "textBoxSelWildcards";
            this.textBoxSelWildcards.Size = new System.Drawing.Size(203, 20);
            this.textBoxSelWildcards.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Wildcards:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Subfolder:";
            // 
            // buttonSaveSelection
            // 
            this.buttonSaveSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveSelection.Location = new System.Drawing.Point(600, 517);
            this.buttonSaveSelection.Name = "buttonSaveSelection";
            this.buttonSaveSelection.Size = new System.Drawing.Size(112, 23);
            this.buttonSaveSelection.TabIndex = 15;
            this.buttonSaveSelection.Text = "Save Edits";
            this.buttonSaveSelection.UseVisualStyleBackColor = true;
            this.buttonSaveSelection.Click += new System.EventHandler(this.buttonSaveSelection_Click);
            // 
            // buttonLoadDefaultSelection
            // 
            this.buttonLoadDefaultSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadDefaultSelection.Location = new System.Drawing.Point(188, 488);
            this.buttonLoadDefaultSelection.Name = "buttonLoadDefaultSelection";
            this.buttonLoadDefaultSelection.Size = new System.Drawing.Size(524, 23);
            this.buttonLoadDefaultSelection.TabIndex = 16;
            this.buttonLoadDefaultSelection.Text = "Load Defaults";
            this.buttonLoadDefaultSelection.UseVisualStyleBackColor = true;
            this.buttonLoadDefaultSelection.Click += new System.EventHandler(this.buttonLoadDefaultSelection_Click);
            // 
            // checkBoxExclusion
            // 
            this.checkBoxExclusion.AutoSize = true;
            this.checkBoxExclusion.Location = new System.Drawing.Point(600, 548);
            this.checkBoxExclusion.Name = "checkBoxExclusion";
            this.checkBoxExclusion.Size = new System.Drawing.Size(64, 17);
            this.checkBoxExclusion.TabIndex = 17;
            this.checkBoxExclusion.Text = "Exclude";
            this.checkBoxExclusion.UseVisualStyleBackColor = true;
            this.checkBoxExclusion.CheckedChanged += new System.EventHandler(this.checkBoxExclusion_CheckedChanged);
            // 
            // ConfigPackager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 581);
            this.Controls.Add(this.checkBoxExclusion);
            this.Controls.Add(this.buttonLoadDefaultSelection);
            this.Controls.Add(this.buttonSaveSelection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSelWildcards);
            this.Controls.Add(this.buttonRemoveSelection);
            this.Controls.Add(this.textBoxSelSubfolder);
            this.Controls.Add(this.buttonAddSelection);
            this.Controls.Add(this.buttonBuildPackage);
            this.Controls.Add(this.listViewSelections);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonRemovePackage);
            this.Controls.Add(this.buttonAddPackage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewPackages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigPackager";
            this.Text = "Config Package Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigPackager_FormClosing);
            this.Load += new System.EventHandler(this.ConfigPackager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPackages;
        private System.Windows.Forms.ColumnHeader modpackName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddPackage;
        private System.Windows.Forms.Button buttonRemovePackage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDestinationFolder;
        private System.Windows.Forms.TextBox textBoxSourceFolder;
        private System.Windows.Forms.TextBox textBoxPackageVersion;
        private System.Windows.Forms.TextBox textBoxPackageName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewSelections;
        private System.Windows.Forms.Button buttonBuildPackage;
        private System.Windows.Forms.Button buttonAddSelection;
        private System.Windows.Forms.TextBox textBoxSelSubfolder;
        private System.Windows.Forms.Button buttonRemoveSelection;
        private System.Windows.Forms.TextBox textBoxSelWildcards;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSaveSelection;
        private System.Windows.Forms.Button buttonLoadDefaultSelection;
        private System.Windows.Forms.ColumnHeader subfolder;
        private System.Windows.Forms.ColumnHeader wildcards;
        private System.Windows.Forms.CheckBox checkBoxExclusion;
    }
}