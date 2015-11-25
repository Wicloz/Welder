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
            this.SuspendLayout();
            // 
            // buttonModManager
            // 
            this.buttonModManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModManager.Location = new System.Drawing.Point(13, 13);
            this.buttonModManager.Name = "buttonModManager";
            this.buttonModManager.Size = new System.Drawing.Size(273, 61);
            this.buttonModManager.TabIndex = 0;
            this.buttonModManager.Text = "Mod Version Manager";
            this.buttonModManager.UseVisualStyleBackColor = true;
            this.buttonModManager.Click += new System.EventHandler(this.buttonModManager_Click);
            // 
            // buttonConfigPackager
            // 
            this.buttonConfigPackager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigPackager.Location = new System.Drawing.Point(13, 80);
            this.buttonConfigPackager.Name = "buttonConfigPackager";
            this.buttonConfigPackager.Size = new System.Drawing.Size(273, 61);
            this.buttonConfigPackager.TabIndex = 1;
            this.buttonConfigPackager.Text = "Config Package Manager";
            this.buttonConfigPackager.UseVisualStyleBackColor = true;
            this.buttonConfigPackager.Click += new System.EventHandler(this.buttonConfigPackager_Click);
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 154);
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
    }
}

