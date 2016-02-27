namespace Welder
{
    partial class Selector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selector));
            this.buttonModManager = new System.Windows.Forms.Button();
            this.buttonConfigPackager = new System.Windows.Forms.Button();
            this.buttonServerBuilder = new System.Windows.Forms.Button();
            this.buttonChangeLogBuilder = new System.Windows.Forms.Button();
            this.buttonForgeManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonModManager
            // 
            this.buttonModManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModManager.Location = new System.Drawing.Point(12, 79);
            this.buttonModManager.Name = "buttonModManager";
            this.buttonModManager.Size = new System.Drawing.Size(274, 61);
            this.buttonModManager.TabIndex = 0;
            this.buttonModManager.Text = "Mod Version Manager";
            this.buttonModManager.UseVisualStyleBackColor = true;
            this.buttonModManager.Click += new System.EventHandler(this.buttonModManager_Click);
            // 
            // buttonConfigPackager
            // 
            this.buttonConfigPackager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigPackager.Location = new System.Drawing.Point(12, 146);
            this.buttonConfigPackager.Name = "buttonConfigPackager";
            this.buttonConfigPackager.Size = new System.Drawing.Size(274, 61);
            this.buttonConfigPackager.TabIndex = 1;
            this.buttonConfigPackager.Text = "Config Package Manager";
            this.buttonConfigPackager.UseVisualStyleBackColor = true;
            this.buttonConfigPackager.Click += new System.EventHandler(this.buttonConfigPackager_Click);
            // 
            // buttonServerBuilder
            // 
            this.buttonServerBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServerBuilder.Location = new System.Drawing.Point(12, 213);
            this.buttonServerBuilder.Name = "buttonServerBuilder";
            this.buttonServerBuilder.Size = new System.Drawing.Size(274, 61);
            this.buttonServerBuilder.TabIndex = 2;
            this.buttonServerBuilder.Text = "Server Builder";
            this.buttonServerBuilder.UseVisualStyleBackColor = true;
            this.buttonServerBuilder.Click += new System.EventHandler(this.buttonServerBuilder_Click);
            // 
            // buttonChangeLogBuilder
            // 
            this.buttonChangeLogBuilder.Location = new System.Drawing.Point(12, 280);
            this.buttonChangeLogBuilder.Name = "buttonChangeLogBuilder";
            this.buttonChangeLogBuilder.Size = new System.Drawing.Size(274, 61);
            this.buttonChangeLogBuilder.TabIndex = 3;
            this.buttonChangeLogBuilder.Text = "Changelog Creator";
            this.buttonChangeLogBuilder.UseVisualStyleBackColor = true;
            this.buttonChangeLogBuilder.Click += new System.EventHandler(this.buttonChangeLogBuilder_Click);
            // 
            // buttonForgeManager
            // 
            this.buttonForgeManager.Location = new System.Drawing.Point(12, 12);
            this.buttonForgeManager.Name = "buttonForgeManager";
            this.buttonForgeManager.Size = new System.Drawing.Size(274, 61);
            this.buttonForgeManager.TabIndex = 4;
            this.buttonForgeManager.Text = "Forge Manager";
            this.buttonForgeManager.UseVisualStyleBackColor = true;
            this.buttonForgeManager.Click += new System.EventHandler(this.buttonForgeManager_Click);
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 354);
            this.Controls.Add(this.buttonForgeManager);
            this.Controls.Add(this.buttonChangeLogBuilder);
            this.Controls.Add(this.buttonServerBuilder);
            this.Controls.Add(this.buttonConfigPackager);
            this.Controls.Add(this.buttonModManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Selector";
            this.Text = "Welder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonModManager;
        private System.Windows.Forms.Button buttonConfigPackager;
        private System.Windows.Forms.Button buttonServerBuilder;
        private System.Windows.Forms.Button buttonChangeLogBuilder;
        private System.Windows.Forms.Button buttonForgeManager;
    }
}

