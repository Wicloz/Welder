﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welder {
    public partial class ChangeLogBuilder : Form {
        public ChangeLogBuilder () {
            InitializeComponent();
        }

        private void ChangeLogBuilder_Load (object sender, EventArgs e) {

        }

        private void ChangeLogBuilder_FormClosing (object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
