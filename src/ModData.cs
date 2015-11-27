using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welder {
    [Serializable]
    public class ModData {
        public string modslug = "NONE";
        public bool enabled = true;
        public string mcVersion = "NONE";
        public string versionLocal = "NA";
        public string versionOnline = "NA";
        public string fileNumberOnline = "NA";
        public string fileNameOnline = "NA";
        public string releaseDateLatest = "NA";
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
