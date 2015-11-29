using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Welder {
    public partial class SB_ExceptionManager : Form {
        private static List<string> exceptions = new List<string>();

        public SB_ExceptionManager () {
            InitializeComponent();
            LoadExceptions();
        }

        //Loads Exceptions
        private void LoadExceptions () {
            if (File.Exists(ServerBuilder.cd + "/server_exceptions.cfg"))
                exceptions = SaveLoad.LoadFilePlain(ServerBuilder.cd + "/server_exceptions.cfg");
            if (exceptions == null)
                exceptions = new List<string>();
            SaveExceptions();
        }

        //Saves Exceptions
        private void SaveExceptions () {
            SaveLoad.SaveFilePlain(exceptions, ServerBuilder.cd + "/server_exceptions.cfg");
        }

        //Returns true when a mod should not be on a server
        public static bool IsException (string modname) {
            foreach (string exception in exceptions) {
                if (modname.ToLower().Contains(exception))
                    return true;
            }
            return false;
        }
    }
}
