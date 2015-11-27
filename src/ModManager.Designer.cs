namespace Welder {
    partial class ModManager {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModManager));
            this.listViewMods = new System.Windows.Forms.ListView();
            this.slug = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siteMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionOnline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOneCheck = new System.Windows.Forms.Button();
            this.buttonOneFind = new System.Windows.Forms.Button();
            this.labelSiteMode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOneOpensite = new System.Windows.Forms.Button();
            this.buttonOneUpdate = new System.Windows.Forms.Button();
            this.textBoxModDsite = new System.Windows.Forms.TextBox();
            this.textBoxModVsite = new System.Windows.Forms.TextBox();
            this.textBoxModSlug = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOneGoogle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAllCheck = new System.Windows.Forms.Button();
            this.buttonAllUpdate = new System.Windows.Forms.Button();
            this.buttonAllFind = new System.Windows.Forms.Button();
            this.textBoxRepo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdateRepo = new System.Windows.Forms.Button();
            this.textBoxRepoVersion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModNewMcVersion = new System.Windows.Forms.TextBox();
            this.textBoxModMcVersion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonOneDuplicate = new System.Windows.Forms.Button();
            this.mcVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteMod = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMods
            // 
            this.listViewMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMods.CheckBoxes = true;
            this.listViewMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mcVersion,
            this.slug,
            this.siteMode,
            this.versionLocal,
            this.versionOnline,
            this.action,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewMods.FullRowSelect = true;
            this.listViewMods.GridLines = true;
            this.listViewMods.HideSelection = false;
            this.listViewMods.Location = new System.Drawing.Point(12, 198);
            this.listViewMods.MultiSelect = false;
            this.listViewMods.Name = "listViewMods";
            this.listViewMods.Size = new System.Drawing.Size(1224, 343);
            this.listViewMods.TabIndex = 0;
            this.listViewMods.UseCompatibleStateImageBehavior = false;
            this.listViewMods.View = System.Windows.Forms.View.Details;
            this.listViewMods.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewMods_ItemChecked);
            this.listViewMods.SelectedIndexChanged += new System.EventHandler(this.listViewMods_SelectedIndexChanged);
            // 
            // slug
            // 
            this.slug.Text = "Mod Slug";
            this.slug.Width = 139;
            // 
            // siteMode
            // 
            this.siteMode.Text = "Status Site";
            this.siteMode.Width = 86;
            // 
            // versionLocal
            // 
            this.versionLocal.Text = "Latest Local Version";
            this.versionLocal.Width = 113;
            // 
            // versionOnline
            // 
            this.versionOnline.Text = "Latest Online Version";
            this.versionOnline.Width = 116;
            // 
            // action
            // 
            this.action.Text = "Action";
            this.action.Width = 112;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonOneDuplicate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxModMcVersion);
            this.groupBox1.Controls.Add(this.textBoxModNewMcVersion);
            this.groupBox1.Controls.Add(this.buttonOneCheck);
            this.groupBox1.Controls.Add(this.buttonOneFind);
            this.groupBox1.Controls.Add(this.labelSiteMode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonOneOpensite);
            this.groupBox1.Controls.Add(this.buttonOneUpdate);
            this.groupBox1.Controls.Add(this.textBoxModDsite);
            this.groupBox1.Controls.Add(this.textBoxModVsite);
            this.groupBox1.Controls.Add(this.textBoxModSlug);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonOneGoogle);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Mod";
            // 
            // buttonOneCheck
            // 
            this.buttonOneCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneCheck.Location = new System.Drawing.Point(409, 123);
            this.buttonOneCheck.Name = "buttonOneCheck";
            this.buttonOneCheck.Size = new System.Drawing.Size(319, 25);
            this.buttonOneCheck.TabIndex = 11;
            this.buttonOneCheck.Text = "Check For Update";
            this.buttonOneCheck.UseVisualStyleBackColor = true;
            // 
            // buttonOneFind
            // 
            this.buttonOneFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneFind.Location = new System.Drawing.Point(734, 123);
            this.buttonOneFind.Name = "buttonOneFind";
            this.buttonOneFind.Size = new System.Drawing.Size(319, 25);
            this.buttonOneFind.TabIndex = 10;
            this.buttonOneFind.Text = "Find Website";
            this.buttonOneFind.UseVisualStyleBackColor = true;
            // 
            // labelSiteMode
            // 
            this.labelSiteMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSiteMode.AutoSize = true;
            this.labelSiteMode.Location = new System.Drawing.Point(975, 75);
            this.labelSiteMode.Name = "labelSiteMode";
            this.labelSiteMode.Size = new System.Drawing.Size(68, 13);
            this.labelSiteMode.TabIndex = 9;
            this.labelSiteMode.Text = "Unsupported";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Download Site:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Version Site:";
            // 
            // buttonOneOpensite
            // 
            this.buttonOneOpensite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneOpensite.Location = new System.Drawing.Point(894, 71);
            this.buttonOneOpensite.Name = "buttonOneOpensite";
            this.buttonOneOpensite.Size = new System.Drawing.Size(75, 20);
            this.buttonOneOpensite.TabIndex = 6;
            this.buttonOneOpensite.Text = "Open";
            this.buttonOneOpensite.UseVisualStyleBackColor = true;
            this.buttonOneOpensite.Click += new System.EventHandler(this.buttonOneOpensite_Click);
            // 
            // buttonOneUpdate
            // 
            this.buttonOneUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneUpdate.Location = new System.Drawing.Point(6, 123);
            this.buttonOneUpdate.Name = "buttonOneUpdate";
            this.buttonOneUpdate.Size = new System.Drawing.Size(397, 25);
            this.buttonOneUpdate.TabIndex = 5;
            this.buttonOneUpdate.Text = "Update Mod";
            this.buttonOneUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxModDsite
            // 
            this.textBoxModDsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModDsite.Location = new System.Drawing.Point(91, 97);
            this.textBoxModDsite.Name = "textBoxModDsite";
            this.textBoxModDsite.ReadOnly = true;
            this.textBoxModDsite.Size = new System.Drawing.Size(962, 20);
            this.textBoxModDsite.TabIndex = 4;
            // 
            // textBoxModVsite
            // 
            this.textBoxModVsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModVsite.Location = new System.Drawing.Point(91, 71);
            this.textBoxModVsite.Name = "textBoxModVsite";
            this.textBoxModVsite.Size = new System.Drawing.Size(797, 20);
            this.textBoxModVsite.TabIndex = 3;
            this.textBoxModVsite.TextChanged += new System.EventHandler(this.textBoxModVsite_TextChanged);
            // 
            // textBoxModSlug
            // 
            this.textBoxModSlug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModSlug.Location = new System.Drawing.Point(91, 19);
            this.textBoxModSlug.Name = "textBoxModSlug";
            this.textBoxModSlug.ReadOnly = true;
            this.textBoxModSlug.Size = new System.Drawing.Size(881, 20);
            this.textBoxModSlug.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mod Slug:";
            // 
            // buttonOneGoogle
            // 
            this.buttonOneGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneGoogle.Location = new System.Drawing.Point(978, 19);
            this.buttonOneGoogle.Name = "buttonOneGoogle";
            this.buttonOneGoogle.Size = new System.Drawing.Size(75, 20);
            this.buttonOneGoogle.TabIndex = 0;
            this.buttonOneGoogle.Text = "Google";
            this.buttonOneGoogle.UseVisualStyleBackColor = true;
            this.buttonOneGoogle.Click += new System.EventHandler(this.buttonOneGoogle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonAllCheck);
            this.groupBox2.Controls.Add(this.buttonAllUpdate);
            this.groupBox2.Controls.Add(this.buttonAllFind);
            this.groupBox2.Location = new System.Drawing.Point(1077, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // buttonAllCheck
            // 
            this.buttonAllCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllCheck.Location = new System.Drawing.Point(6, 70);
            this.buttonAllCheck.Name = "buttonAllCheck";
            this.buttonAllCheck.Size = new System.Drawing.Size(147, 36);
            this.buttonAllCheck.TabIndex = 1;
            this.buttonAllCheck.Text = "Check For Updates";
            this.buttonAllCheck.UseVisualStyleBackColor = true;
            // 
            // buttonAllUpdate
            // 
            this.buttonAllUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllUpdate.Location = new System.Drawing.Point(6, 19);
            this.buttonAllUpdate.Name = "buttonAllUpdate";
            this.buttonAllUpdate.Size = new System.Drawing.Size(147, 45);
            this.buttonAllUpdate.TabIndex = 0;
            this.buttonAllUpdate.Text = "Update Mods";
            this.buttonAllUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAllFind
            // 
            this.buttonAllFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllFind.Location = new System.Drawing.Point(6, 112);
            this.buttonAllFind.Name = "buttonAllFind";
            this.buttonAllFind.Size = new System.Drawing.Size(147, 36);
            this.buttonAllFind.TabIndex = 2;
            this.buttonAllFind.Text = "Find Missing Websites";
            this.buttonAllFind.UseVisualStyleBackColor = true;
            // 
            // textBoxRepo
            // 
            this.textBoxRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepo.Location = new System.Drawing.Point(98, 12);
            this.textBoxRepo.Name = "textBoxRepo";
            this.textBoxRepo.Size = new System.Drawing.Size(815, 20);
            this.textBoxRepo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Repo Location:";
            // 
            // buttonUpdateRepo
            // 
            this.buttonUpdateRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateRepo.Location = new System.Drawing.Point(1160, 12);
            this.buttonUpdateRepo.Name = "buttonUpdateRepo";
            this.buttonUpdateRepo.Size = new System.Drawing.Size(76, 20);
            this.buttonUpdateRepo.TabIndex = 5;
            this.buttonUpdateRepo.Text = "Update";
            this.buttonUpdateRepo.UseVisualStyleBackColor = true;
            this.buttonUpdateRepo.Click += new System.EventHandler(this.buttonUpdateRepo_Click);
            // 
            // textBoxRepoVersion
            // 
            this.textBoxRepoVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepoVersion.Location = new System.Drawing.Point(1054, 12);
            this.textBoxRepoVersion.Name = "textBoxRepoVersion";
            this.textBoxRepoVersion.Size = new System.Drawing.Size(100, 20);
            this.textBoxRepoVersion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(919, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Primary Minecraft Version:";
            // 
            // textBoxModNewMcVersion
            // 
            this.textBoxModNewMcVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModNewMcVersion.Location = new System.Drawing.Point(935, 45);
            this.textBoxModNewMcVersion.Name = "textBoxModNewMcVersion";
            this.textBoxModNewMcVersion.Size = new System.Drawing.Size(118, 20);
            this.textBoxModNewMcVersion.TabIndex = 12;
            // 
            // textBoxModMcVersion
            // 
            this.textBoxModMcVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModMcVersion.Location = new System.Drawing.Point(91, 45);
            this.textBoxModMcVersion.Name = "textBoxModMcVersion";
            this.textBoxModMcVersion.Size = new System.Drawing.Size(662, 20);
            this.textBoxModMcVersion.TabIndex = 13;
            this.textBoxModMcVersion.TextChanged += new System.EventHandler(this.textBoxModMcVersion_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "MC Version:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(840, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "With MC Version:";
            // 
            // buttonOneDuplicate
            // 
            this.buttonOneDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneDuplicate.Location = new System.Drawing.Point(759, 45);
            this.buttonOneDuplicate.Name = "buttonOneDuplicate";
            this.buttonOneDuplicate.Size = new System.Drawing.Size(75, 20);
            this.buttonOneDuplicate.TabIndex = 16;
            this.buttonOneDuplicate.Text = "Create New";
            this.buttonOneDuplicate.UseVisualStyleBackColor = true;
            this.buttonOneDuplicate.Click += new System.EventHandler(this.buttonOneDuplicate_Click);
            // 
            // mcVersion
            // 
            this.mcVersion.Text = "MC Version";
            this.mcVersion.Width = 68;
            // 
            // buttonDeleteMod
            // 
            this.buttonDeleteMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteMod.Location = new System.Drawing.Point(12, 547);
            this.buttonDeleteMod.Name = "buttonDeleteMod";
            this.buttonDeleteMod.Size = new System.Drawing.Size(1224, 23);
            this.buttonDeleteMod.TabIndex = 8;
            this.buttonDeleteMod.Text = "Delete Selected Mod";
            this.buttonDeleteMod.UseVisualStyleBackColor = true;
            this.buttonDeleteMod.Click += new System.EventHandler(this.buttonDeleteMod_Click);
            // 
            // ModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 582);
            this.Controls.Add(this.buttonDeleteMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRepoVersion);
            this.Controls.Add(this.buttonUpdateRepo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRepo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewMods);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModManager";
            this.Text = "Mod Version Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModManager_FormClosing);
            this.Load += new System.EventHandler(this.ModManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMods;
        private System.Windows.Forms.ColumnHeader slug;
        private System.Windows.Forms.ColumnHeader versionLocal;
        private System.Windows.Forms.ColumnHeader versionOnline;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAllFind;
        private System.Windows.Forms.Button buttonAllCheck;
        private System.Windows.Forms.Button buttonAllUpdate;
        private System.Windows.Forms.Label labelSiteMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOneOpensite;
        private System.Windows.Forms.Button buttonOneUpdate;
        private System.Windows.Forms.TextBox textBoxModDsite;
        private System.Windows.Forms.TextBox textBoxModVsite;
        private System.Windows.Forms.TextBox textBoxModSlug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOneGoogle;
        private System.Windows.Forms.Button buttonOneCheck;
        private System.Windows.Forms.Button buttonOneFind;
        private System.Windows.Forms.ColumnHeader siteMode;
        private System.Windows.Forms.ColumnHeader action;
        private System.Windows.Forms.TextBox textBoxRepo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdateRepo;
        private System.Windows.Forms.TextBox textBoxRepoVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOneDuplicate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxModMcVersion;
        private System.Windows.Forms.TextBox textBoxModNewMcVersion;
        private System.Windows.Forms.ColumnHeader mcVersion;
        private System.Windows.Forms.Button buttonDeleteMod;
    }
}