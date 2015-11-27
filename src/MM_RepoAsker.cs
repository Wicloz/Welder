using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welder {
    public partial class MM_RepoAsker : Form {
        public string repoLocation = "";
        public string repoVersion = "";

        public MM_RepoAsker (string oldLocation, string oldVersion) {
            InitializeComponent();
            repoLocation = oldLocation;
            repoVersion = oldVersion;
        }

        private void MM_RepoAsker_Load (object sender, EventArgs e) {
            textBoxRepo.Text = repoLocation;
            textBoxVersion.Text = repoVersion;
        }

        private void textBoxRepo_TextChanged (object sender, EventArgs e) {
            repoLocation = textBoxRepo.Text;
        }

        private void textBoxVersion_TextChanged (object sender, EventArgs e) {
            repoVersion = textBoxVersion.Text;
        }

        private void buttonConfirm_Click (object sender, EventArgs e) {
            this.Close();
        }
    }
}
