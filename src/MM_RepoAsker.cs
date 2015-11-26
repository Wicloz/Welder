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

        public MM_RepoAsker (string oldLocation) {
            InitializeComponent();
            repoLocation = oldLocation;
        }

        private void MM_RepoAsker_Load (object sender, EventArgs e) {
            textBoxRepo.Text = repoLocation;
        }

        private void textBoxRepo_TextChanged (object sender, EventArgs e) {
            repoLocation = textBoxRepo.Text;
        }

        private void buttonConfirm_Click (object sender, EventArgs e) {
            this.Close();
        }
    }
}
