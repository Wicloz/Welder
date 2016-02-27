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
        private ForgeManager forgeManager = new ForgeManager();
        private ModManager modManager = new ModManager();
        private ConfigPackager configPackager = new ConfigPackager();
        private ServerBuilder serverBuilder = new ServerBuilder();
        private ChangeLogBuilder changelogBuilder = new ChangeLogBuilder();

        public Selector() {
            InitializeComponent();
        }

        private void buttonForgeManager_Click (object sender, EventArgs e) {
            forgeManager.Show();
        }

        private void buttonModManager_Click(object sender, EventArgs e) {
            modManager.Show();
        }

        private void buttonConfigPackager_Click(object sender, EventArgs e) {
            configPackager.Show();
        }

        private void buttonServerBuilder_Click (object sender, EventArgs e) {
            serverBuilder.Show();
        }

        private void buttonChangeLogBuilder_Click (object sender, EventArgs e) {
            changelogBuilder.Show();
        }
    }
}
