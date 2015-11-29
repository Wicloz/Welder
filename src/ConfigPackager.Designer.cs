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
            this.listViewModpacks = new System.Windows.Forms.ListView();
            this.modpackName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddPackage = new System.Windows.Forms.Button();
            this.buttonRemovePackage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewModpacks
            // 
            this.listViewModpacks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewModpacks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modpackName});
            this.listViewModpacks.FullRowSelect = true;
            this.listViewModpacks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewModpacks.HideSelection = false;
            this.listViewModpacks.Location = new System.Drawing.Point(12, 12);
            this.listViewModpacks.MultiSelect = false;
            this.listViewModpacks.Name = "listViewModpacks";
            this.listViewModpacks.Size = new System.Drawing.Size(170, 499);
            this.listViewModpacks.TabIndex = 0;
            this.listViewModpacks.UseCompatibleStateImageBehavior = false;
            this.listViewModpacks.View = System.Windows.Forms.View.Details;
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
            this.richTextBox1.Location = new System.Drawing.Point(188, 221);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(778, 348);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Information";
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
            // 
            // ConfigPackager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 581);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonRemovePackage);
            this.Controls.Add(this.buttonAddPackage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewModpacks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigPackager";
            this.Text = "Config Package Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigPackager_FormClosing);
            this.Load += new System.EventHandler(this.ConfigPackager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewModpacks;
        private System.Windows.Forms.ColumnHeader modpackName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddPackage;
        private System.Windows.Forms.Button buttonRemovePackage;
    }
}