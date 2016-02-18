using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Welder {
    [Serializable]
    class CP_ConfigData {
        public string name = "NONE";
        public string packageVersion = "";
        public string sourceFolder = "";
        public string destFolder = "";
    }
}
