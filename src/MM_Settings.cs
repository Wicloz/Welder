using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welder {
    [Serializable]
    public class MM_Settings {
        public string repo = "";
        public string mainMcVersion = "";
        public string solderUrl = "";
        public string solderMail = "";
        public string solderPass = "";
        public MM_Settings () { }
    }
}
