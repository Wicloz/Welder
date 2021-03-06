﻿namespace Welder {
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
            this.mcVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.slug = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siteMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionOnline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCanUpdate = new System.Windows.Forms.CheckBox();
            this.buttonOneDuplicate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxModMcVersion = new System.Windows.Forms.TextBox();
            this.textBoxModNewMcVersion = new System.Windows.Forms.TextBox();
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
            this.buttonDeleteMod = new System.Windows.Forms.Button();
            this.buttonAddMod = new System.Windows.Forms.Button();
            this.textBoxSolderUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSolderSync = new System.Windows.Forms.Button();
            this.textBoxSolderPass = new System.Windows.Forms.TextBox();
            this.textBoxSolderMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.columnHeader4,
            this.columnHeader5});
            this.listViewMods.FullRowSelect = true;
            this.listViewMods.GridLines = true;
            this.listViewMods.HideSelection = false;
            this.listViewMods.Location = new System.Drawing.Point(12, 198);
            this.listViewMods.MultiSelect = false;
            this.listViewMods.Name = "listViewMods";
            this.listViewMods.Size = new System.Drawing.Size(1250, 287);
            this.listViewMods.TabIndex = 0;
            this.listViewMods.UseCompatibleStateImageBehavior = false;
            this.listViewMods.View = System.Windows.Forms.View.Details;
            this.listViewMods.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewMods_ItemChecked);
            this.listViewMods.SelectedIndexChanged += new System.EventHandler(this.listViewMods_SelectedIndexChanged);
            // 
            // mcVersion
            // 
            this.mcVersion.Text = "MC Version";
            this.mcVersion.Width = 68;
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
            this.action.Width = 191;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Website 1";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Website 2";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Website 3";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Website 4";
            this.columnHeader4.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Website 5";
            this.columnHeader5.Width = 85;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxCanUpdate);
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
            this.groupBox1.Size = new System.Drawing.Size(1085, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Mod";
            // 
            // checkBoxCanUpdate
            // 
            this.checkBoxCanUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCanUpdate.AutoSize = true;
            this.checkBoxCanUpdate.Location = new System.Drawing.Point(978, 128);
            this.checkBoxCanUpdate.Name = "checkBoxCanUpdate";
            this.checkBoxCanUpdate.Size = new System.Drawing.Size(107, 17);
            this.checkBoxCanUpdate.TabIndex = 17;
            this.checkBoxCanUpdate.Text = "Update Available";
            this.checkBoxCanUpdate.UseVisualStyleBackColor = true;
            this.checkBoxCanUpdate.CheckedChanged += new System.EventHandler(this.checkBoxCanUpdate_CheckedChanged);
            // 
            // buttonOneDuplicate
            // 
            this.buttonOneDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneDuplicate.Location = new System.Drawing.Point(785, 45);
            this.buttonOneDuplicate.Name = "buttonOneDuplicate";
            this.buttonOneDuplicate.Size = new System.Drawing.Size(75, 20);
            this.buttonOneDuplicate.TabIndex = 16;
            this.buttonOneDuplicate.Text = "Create New";
            this.buttonOneDuplicate.UseVisualStyleBackColor = true;
            this.buttonOneDuplicate.Click += new System.EventHandler(this.buttonOneDuplicate_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(866, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "With MC Version:";
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
            // textBoxModMcVersion
            // 
            this.textBoxModMcVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModMcVersion.Location = new System.Drawing.Point(91, 45);
            this.textBoxModMcVersion.Name = "textBoxModMcVersion";
            this.textBoxModMcVersion.Size = new System.Drawing.Size(688, 20);
            this.textBoxModMcVersion.TabIndex = 13;
            this.textBoxModMcVersion.TextChanged += new System.EventHandler(this.textBoxModMcVersion_TextChanged);
            // 
            // textBoxModNewMcVersion
            // 
            this.textBoxModNewMcVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModNewMcVersion.Location = new System.Drawing.Point(961, 45);
            this.textBoxModNewMcVersion.Name = "textBoxModNewMcVersion";
            this.textBoxModNewMcVersion.Size = new System.Drawing.Size(118, 20);
            this.textBoxModNewMcVersion.TabIndex = 12;
            // 
            // buttonOneCheck
            // 
            this.buttonOneCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneCheck.Location = new System.Drawing.Point(436, 123);
            this.buttonOneCheck.Name = "buttonOneCheck";
            this.buttonOneCheck.Size = new System.Drawing.Size(265, 25);
            this.buttonOneCheck.TabIndex = 11;
            this.buttonOneCheck.Text = "Check For Update";
            this.buttonOneCheck.UseVisualStyleBackColor = true;
            this.buttonOneCheck.Click += new System.EventHandler(this.buttonOneCheck_Click);
            // 
            // buttonOneFind
            // 
            this.buttonOneFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneFind.Location = new System.Drawing.Point(707, 123);
            this.buttonOneFind.Name = "buttonOneFind";
            this.buttonOneFind.Size = new System.Drawing.Size(265, 25);
            this.buttonOneFind.TabIndex = 10;
            this.buttonOneFind.Text = "Find Website";
            this.buttonOneFind.UseVisualStyleBackColor = true;
            this.buttonOneFind.Click += new System.EventHandler(this.buttonOneFind_Click);
            // 
            // labelSiteMode
            // 
            this.labelSiteMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSiteMode.AutoSize = true;
            this.labelSiteMode.Location = new System.Drawing.Point(1001, 75);
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
            this.buttonOneOpensite.Location = new System.Drawing.Point(920, 71);
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
            this.buttonOneUpdate.Size = new System.Drawing.Size(424, 25);
            this.buttonOneUpdate.TabIndex = 5;
            this.buttonOneUpdate.Text = "Update Mod";
            this.buttonOneUpdate.UseVisualStyleBackColor = true;
            this.buttonOneUpdate.Click += new System.EventHandler(this.buttonOneUpdate_Click);
            // 
            // textBoxModDsite
            // 
            this.textBoxModDsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModDsite.Location = new System.Drawing.Point(91, 97);
            this.textBoxModDsite.Name = "textBoxModDsite";
            this.textBoxModDsite.ReadOnly = true;
            this.textBoxModDsite.Size = new System.Drawing.Size(988, 20);
            this.textBoxModDsite.TabIndex = 4;
            // 
            // textBoxModVsite
            // 
            this.textBoxModVsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModVsite.Location = new System.Drawing.Point(91, 71);
            this.textBoxModVsite.Name = "textBoxModVsite";
            this.textBoxModVsite.Size = new System.Drawing.Size(823, 20);
            this.textBoxModVsite.TabIndex = 3;
            this.textBoxModVsite.TextChanged += new System.EventHandler(this.textBoxModVsite_TextChanged);
            // 
            // textBoxModSlug
            // 
            this.textBoxModSlug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModSlug.Location = new System.Drawing.Point(91, 19);
            this.textBoxModSlug.Name = "textBoxModSlug";
            this.textBoxModSlug.Size = new System.Drawing.Size(907, 20);
            this.textBoxModSlug.TabIndex = 2;
            this.textBoxModSlug.TextChanged += new System.EventHandler(this.textBoxModSlug_TextChanged);
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
            this.buttonOneGoogle.Location = new System.Drawing.Point(1004, 19);
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
            this.groupBox2.Location = new System.Drawing.Point(1103, 38);
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
            this.buttonAllCheck.Click += new System.EventHandler(this.buttonAllCheck_Click);
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
            this.buttonAllUpdate.Click += new System.EventHandler(this.buttonAllUpdate_Click);
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
            this.buttonAllFind.Click += new System.EventHandler(this.buttonAllFind_Click);
            // 
            // textBoxRepo
            // 
            this.textBoxRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepo.Location = new System.Drawing.Point(98, 12);
            this.textBoxRepo.Name = "textBoxRepo";
            this.textBoxRepo.Size = new System.Drawing.Size(841, 20);
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
            this.buttonUpdateRepo.Location = new System.Drawing.Point(1186, 12);
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
            this.textBoxRepoVersion.Location = new System.Drawing.Point(1080, 12);
            this.textBoxRepoVersion.Name = "textBoxRepoVersion";
            this.textBoxRepoVersion.Size = new System.Drawing.Size(100, 20);
            this.textBoxRepoVersion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(945, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Primary Minecraft Version:";
            // 
            // buttonDeleteMod
            // 
            this.buttonDeleteMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteMod.Location = new System.Drawing.Point(809, 491);
            this.buttonDeleteMod.Name = "buttonDeleteMod";
            this.buttonDeleteMod.Size = new System.Drawing.Size(453, 23);
            this.buttonDeleteMod.TabIndex = 8;
            this.buttonDeleteMod.Text = "Delete Selected Mod";
            this.buttonDeleteMod.UseVisualStyleBackColor = true;
            this.buttonDeleteMod.Click += new System.EventHandler(this.buttonDeleteMod_Click);
            // 
            // buttonAddMod
            // 
            this.buttonAddMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMod.Location = new System.Drawing.Point(12, 491);
            this.buttonAddMod.Name = "buttonAddMod";
            this.buttonAddMod.Size = new System.Drawing.Size(791, 23);
            this.buttonAddMod.TabIndex = 9;
            this.buttonAddMod.Text = "Add New Mod";
            this.buttonAddMod.UseVisualStyleBackColor = true;
            this.buttonAddMod.Click += new System.EventHandler(this.buttonAddMod_Click);
            // 
            // textBoxSolderUrl
            // 
            this.textBoxSolderUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSolderUrl.Location = new System.Drawing.Point(81, 520);
            this.textBoxSolderUrl.Name = "textBoxSolderUrl";
            this.textBoxSolderUrl.Size = new System.Drawing.Size(752, 20);
            this.textBoxSolderUrl.TabIndex = 10;
            this.textBoxSolderUrl.TextChanged += new System.EventHandler(this.textBoxSolderUrl_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Solder Link:";
            // 
            // buttonSolderSync
            // 
            this.buttonSolderSync.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSolderSync.Location = new System.Drawing.Point(12, 546);
            this.buttonSolderSync.Name = "buttonSolderSync";
            this.buttonSolderSync.Size = new System.Drawing.Size(1250, 23);
            this.buttonSolderSync.TabIndex = 12;
            this.buttonSolderSync.Text = "Update Modlist From Solder";
            this.buttonSolderSync.UseVisualStyleBackColor = true;
            this.buttonSolderSync.Click += new System.EventHandler(this.buttonSolderSync_Click);
            // 
            // textBoxSolderPass
            // 
            this.textBoxSolderPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSolderPass.Location = new System.Drawing.Point(1102, 520);
            this.textBoxSolderPass.Name = "textBoxSolderPass";
            this.textBoxSolderPass.PasswordChar = '•';
            this.textBoxSolderPass.Size = new System.Drawing.Size(160, 20);
            this.textBoxSolderPass.TabIndex = 13;
            this.textBoxSolderPass.TextChanged += new System.EventHandler(this.textBoxSolderPass_TextChanged);
            // 
            // textBoxSolderMail
            // 
            this.textBoxSolderMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSolderMail.Location = new System.Drawing.Point(874, 520);
            this.textBoxSolderMail.Name = "textBoxSolderMail";
            this.textBoxSolderMail.Size = new System.Drawing.Size(160, 20);
            this.textBoxSolderMail.TabIndex = 14;
            this.textBoxSolderMail.TextChanged += new System.EventHandler(this.textBoxSolderMail_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1040, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Password:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(839, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mail:";
            // 
            // ModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 581);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSolderMail);
            this.Controls.Add(this.textBoxSolderPass);
            this.Controls.Add(this.buttonSolderSync);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSolderUrl);
            this.Controls.Add(this.buttonAddMod);
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
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonAddMod;
        private System.Windows.Forms.CheckBox checkBoxCanUpdate;
        private System.Windows.Forms.TextBox textBoxSolderUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSolderSync;
        private System.Windows.Forms.TextBox textBoxSolderPass;
        private System.Windows.Forms.TextBox textBoxSolderMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}