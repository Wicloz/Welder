using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welder
{
    public partial class Selector : Form {
        private ModManager modManager = new ModManager();
        private ConfigPackager configPackager = new ConfigPackager();

        public Selector() {
            InitializeComponent();
        }

        private void buttonModManager_Click(object sender, EventArgs e) {
            modManager.Show();
        }

        private void buttonConfigPackager_Click(object sender, EventArgs e) {
            configPackager.Show();
        }

        private void Selector_Shown (object sender, EventArgs e) {
            modManager.Show();
        }
    }
}
