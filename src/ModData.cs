using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welder {
    [Serializable]
    public class ModData {
        public string modslug = "error";
        public bool enabled = true;
        public string mcVersion = "error";
        public string versionLocal = "NA";
        public string versionOnline = "NA";
        public string fileNumber = "NA";
        public string fileName = "NA";
        public string releaseDate = "NA";
        public string websiteCheck = "NONE";
        public string websiteDownload {
            get {
                return "NONE";
            }
        }
        public string sitemode {
            get {
                return "Unsupported";
            }
        }
    }
}
