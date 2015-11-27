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
        public string modUid {
            get {
                return mcVersion + "-" + modslug + "-" + versionLocal;
            }
        }
        public string versionLocal = "NA";
        public string versionOnline = "NA";
        public string fileNumberOnline = "NA";
        public string fileNameOnline = "NA";
        public string releaseDateLatest = "NA";
        public string websiteCheck = "NONE";
        public string websiteDownload {
            get {
                return siteConfig.downloadSite
                    .Replace("%SITE%", websiteCheck)
                    .Replace("%FILENUMBER%", fileNumberOnline)
                    .Replace("%FILENAME%", fileNameOnline)
                    .Replace("%VERSION%", versionOnline);
            }
        }
        public string sitemode {
            get {
                return siteConfig.name;
            }
        }
        private MM_SiteConfig siteConfig = new MM_SiteConfig();

        public ModData () {
            siteConfig = new MM_SiteConfig();
        }
        public void Initialise () {
            UpdateSiteConfig();
        }

        public void UpdateSiteConfig () {
            siteConfig = MiscFunctions.GetSiteConfig(websiteCheck);
        }
    }
}
