using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Welder {
    [Serializable]
    public class CP_ConfigData {
        public string packageName = "NONE";
        public string packageVersion = "";
        public string sourceFolder = "";
        public string destFolder = "";
        public List<string> selectionFolder = new List<string>();
        public List<string> selectionWildcards = new List<string>();
        public int selectedSelection = -1;

        public string slug {
            get {
                string[] folders = destFolder.Split('\\');
                return folders[folders.Length - 1];
            }
        }
        public string packageBuildFolder {
            get {
                return ConfigPackager.cd + "/packages/" + slug + "-" + packageVersion;
            }
        }
        public string exportFile {
            get {
                return destFolder + "/" + slug + "-" + packageVersion + ".zip";
            }
        }

        public string notificationFile {
            get {
                return destFolder + "../../../ChangedMods.txt";
            }
        }

        public CP_ConfigData () { }

        //Builds this package
        public void BuildPackage () {
            CopySelectionFiles();
            ZipPackage();
            if (Directory.Exists(packageBuildFolder))
                Directory.Delete(packageBuildFolder, true);
            MiscFunctions.RemoveEmptyFolders(ConfigPackager.cd + "/packages/", true);
        }

        //Copies selected files to temporary build folder
        private void CopySelectionFiles () {
            if (Directory.Exists(packageBuildFolder))
                Directory.Delete(packageBuildFolder, true);
            for (int i = 0; i < selectionFolder.Count; i++) {
                try {
                    foreach (string file in MiscFunctions.GetFiles(sourceFolder + "/" + selectionFolder[i], selectionWildcards[i], SearchOption.AllDirectories)) {
                        string newFile = file.Replace(sourceFolder, packageBuildFolder);
                        Directory.CreateDirectory(Path.GetDirectoryName(newFile));
                        File.Copy(file, newFile);
                    }
                }
                catch { }
            }
        }

        //Creates package file from temporary folder
        private void ZipPackage () {
            if (File.Exists(exportFile))
                File.Delete(exportFile);
            ZipFile.CreateFromDirectory(packageBuildFolder, exportFile, CompressionLevel.Optimal, false);

            //Create line in notification file
            File.AppendAllText(notificationFile, "Package Updated: " + slug + " - " + packageVersion + "\n");
        }

        //Sets the selection lists to the default for config packages
        public void SetDefaultSelections () {
            selectionFolder = new List<string>();
            selectionWildcards = new List<string>();
            selectionFolder.Add("config");
            selectionWildcards.Add("*.*");
            selectionFolder.Add("scripts");
            selectionWildcards.Add("*.*");
            selectionFolder.Add("betterrecords");
            selectionWildcards.Add("*.cfg");
            selectionFolder.Add("mods");
            selectionWildcards.Add("*.cfg|*.dat|*.json|*.conf");
        }
    }
}
