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
            this.versionLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionOnline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAllUpdate = new System.Windows.Forms.Button();
            this.buttonAllCheck = new System.Windows.Forms.Button();
            this.buttonAllFind = new System.Windows.Forms.Button();
            this.buttonOneGoogle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModSlug = new System.Windows.Forms.TextBox();
            this.textBoxModVsite = new System.Windows.Forms.TextBox();
            this.textBoxModDsite = new System.Windows.Forms.TextBox();
            this.buttonOneUpdate = new System.Windows.Forms.Button();
            this.buttonOneOpensite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSiteMode = new System.Windows.Forms.Label();
            this.buttonOneFind = new System.Windows.Forms.Button();
            this.buttonOneCheck = new System.Windows.Forms.Button();
            this.action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siteMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxRepo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdateRepo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMods
            // 
            this.listViewMods.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMods.CheckBoxes = true;
            this.listViewMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.listViewMods.HoverSelection = true;
            this.listViewMods.Location = new System.Drawing.Point(12, 173);
            this.listViewMods.MultiSelect = false;
            this.listViewMods.Name = "listViewMods";
            this.listViewMods.Size = new System.Drawing.Size(1224, 397);
            this.listViewMods.TabIndex = 0;
            this.listViewMods.UseCompatibleStateImageBehavior = false;
            this.listViewMods.View = System.Windows.Forms.View.Details;
            // 
            // slug
            // 
            this.slug.Text = "Mod Slug";
            this.slug.Width = 97;
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
            this.groupBox1.Size = new System.Drawing.Size(1059, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Mod";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonAllCheck);
            this.groupBox2.Controls.Add(this.buttonAllUpdate);
            this.groupBox2.Controls.Add(this.buttonAllFind);
            this.groupBox2.Location = new System.Drawing.Point(1077, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // buttonAllUpdate
            // 
            this.buttonAllUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllUpdate.Location = new System.Drawing.Point(6, 19);
            this.buttonAllUpdate.Name = "buttonAllUpdate";
            this.buttonAllUpdate.Size = new System.Drawing.Size(147, 36);
            this.buttonAllUpdate.TabIndex = 0;
            this.buttonAllUpdate.Text = "Update Mods";
            this.buttonAllUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAllCheck
            // 
            this.buttonAllCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllCheck.Location = new System.Drawing.Point(6, 61);
            this.buttonAllCheck.Name = "buttonAllCheck";
            this.buttonAllCheck.Size = new System.Drawing.Size(147, 28);
            this.buttonAllCheck.TabIndex = 1;
            this.buttonAllCheck.Text = "Check For Updates";
            this.buttonAllCheck.UseVisualStyleBackColor = true;
            // 
            // buttonAllFind
            // 
            this.buttonAllFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllFind.Location = new System.Drawing.Point(6, 95);
            this.buttonAllFind.Name = "buttonAllFind";
            this.buttonAllFind.Size = new System.Drawing.Size(147, 28);
            this.buttonAllFind.TabIndex = 2;
            this.buttonAllFind.Text = "Find Missing Websites";
            this.buttonAllFind.UseVisualStyleBackColor = true;
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
            // textBoxModSlug
            // 
            this.textBoxModSlug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModSlug.Location = new System.Drawing.Point(91, 19);
            this.textBoxModSlug.Name = "textBoxModSlug";
            this.textBoxModSlug.Size = new System.Drawing.Size(881, 20);
            this.textBoxModSlug.TabIndex = 2;
            // 
            // textBoxModVsite
            // 
            this.textBoxModVsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModVsite.Location = new System.Drawing.Point(91, 45);
            this.textBoxModVsite.Name = "textBoxModVsite";
            this.textBoxModVsite.Size = new System.Drawing.Size(797, 20);
            this.textBoxModVsite.TabIndex = 3;
            // 
            // textBoxModDsite
            // 
            this.textBoxModDsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModDsite.Location = new System.Drawing.Point(91, 71);
            this.textBoxModDsite.Name = "textBoxModDsite";
            this.textBoxModDsite.Size = new System.Drawing.Size(962, 20);
            this.textBoxModDsite.TabIndex = 4;
            // 
            // buttonOneUpdate
            // 
            this.buttonOneUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneUpdate.Location = new System.Drawing.Point(6, 97);
            this.buttonOneUpdate.Name = "buttonOneUpdate";
            this.buttonOneUpdate.Size = new System.Drawing.Size(397, 26);
            this.buttonOneUpdate.TabIndex = 5;
            this.buttonOneUpdate.Text = "Update Mod";
            this.buttonOneUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonOneOpensite
            // 
            this.buttonOneOpensite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneOpensite.Location = new System.Drawing.Point(894, 45);
            this.buttonOneOpensite.Name = "buttonOneOpensite";
            this.buttonOneOpensite.Size = new System.Drawing.Size(75, 20);
            this.buttonOneOpensite.TabIndex = 6;
            this.buttonOneOpensite.Text = "Open";
            this.buttonOneOpensite.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Version Site:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Download Site:";
            // 
            // labelSiteMode
            // 
            this.labelSiteMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSiteMode.AutoSize = true;
            this.labelSiteMode.Location = new System.Drawing.Point(975, 49);
            this.labelSiteMode.Name = "labelSiteMode";
            this.labelSiteMode.Size = new System.Drawing.Size(68, 13);
            this.labelSiteMode.TabIndex = 9;
            this.labelSiteMode.Text = "Unsupported";
            // 
            // buttonOneFind
            // 
            this.buttonOneFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneFind.Location = new System.Drawing.Point(734, 97);
            this.buttonOneFind.Name = "buttonOneFind";
            this.buttonOneFind.Size = new System.Drawing.Size(319, 26);
            this.buttonOneFind.TabIndex = 10;
            this.buttonOneFind.Text = "Find Website";
            this.buttonOneFind.UseVisualStyleBackColor = true;
            // 
            // buttonOneCheck
            // 
            this.buttonOneCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneCheck.Location = new System.Drawing.Point(409, 97);
            this.buttonOneCheck.Name = "buttonOneCheck";
            this.buttonOneCheck.Size = new System.Drawing.Size(319, 26);
            this.buttonOneCheck.TabIndex = 11;
            this.buttonOneCheck.Text = "Check For Update";
            this.buttonOneCheck.UseVisualStyleBackColor = true;
            // 
            // action
            // 
            this.action.Text = "Action";
            this.action.Width = 112;
            // 
            // siteMode
            // 
            this.siteMode.Text = "Status Site";
            this.siteMode.Width = 86;
            // 
            // textBoxRepo
            // 
            this.textBoxRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepo.Location = new System.Drawing.Point(98, 12);
            this.textBoxRepo.Name = "textBoxRepo";
            this.textBoxRepo.Size = new System.Drawing.Size(1056, 20);
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
            this.buttonUpdateRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateRepo.Location = new System.Drawing.Point(1160, 12);
            this.buttonUpdateRepo.Name = "buttonUpdateRepo";
            this.buttonUpdateRepo.Size = new System.Drawing.Size(76, 20);
            this.buttonUpdateRepo.TabIndex = 5;
            this.buttonUpdateRepo.Text = "Update";
            this.buttonUpdateRepo.UseVisualStyleBackColor = true;
            this.buttonUpdateRepo.Click += new System.EventHandler(this.buttonUpdateRepo_Click);
            // 
            // ModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 582);
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
    }
}