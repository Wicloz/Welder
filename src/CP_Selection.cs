using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welder {
    [Serializable]
    public class CP_Selection {
        public string folder = "";
        public string wildcards = "*.*";

        public CP_Selection () { }

        public CP_Selection (string folder, string wildcards) {
            this.folder = folder;
            this.wildcards = wildcards;
        }
    }
}
