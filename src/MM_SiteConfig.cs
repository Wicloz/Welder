using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welder {
    [Serializable]
    public class MM_SiteConfig {
        public string name = "Unsupported";
        public string identifier = "";
        public string downloadSite = "NONE";
        public string mcLineId = "html";
        public string mcLinePre = "html";
        public string mcLinePost = "html";
        public string fileNumLineId = "html";
        public string fileNumLinePre = "html";
        public string fileNumLinePost = "html";
        public string fileNameLineId = "html";
        public string fileNameLinePre = "html";
        public string fileNameLinePost = "html";
        public string dateLineLineId = "html";
        public string dateLinePre = "html";
        public string dateLinePost = "html";
        public string versionLineLineId = "html";
        public string versionLinePre = "html";
        public string versionLinePost = "html";
        public MM_SiteConfig () { }
    }
}
