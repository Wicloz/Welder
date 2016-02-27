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
        public List<CP_Selection> inclusions = new List<CP_Selection>();
        public List<CP_Selection> exclusions = new List<CP_Selection>();
        public int selectedIndex = 0;
        public CP_Selection selectedSelection = new CP_Selection();

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

        //Gets both selection lists merged
        public List<CP_Selection> GetSelectionList () {
            List<CP_Selection> list = new List<CP_Selection>();
            list.AddRange(inclusions);
            list.AddRange(exclusions);
            return list;
        }

        //Gets the combined length of both selectionlists
        public int GetSelectionCount() {
            return inclusions.Count + exclusions.Count;
        }

        //Gets the selection at the specified index
        public CP_Selection GetSelectionAt (int index) {
            return GetSelectionList()[index];
        }

        //Removes an item from one of the lists
        public void RemoveSelectionAt (int index) {
            if (index < inclusions.Count)
                inclusions.RemoveAt(index);
            else
                exclusions.RemoveAt(index - inclusions.Count);
        }

        //Moves the requested selection to the other list
        //Returns the new index
        public int SwitchSelectionAt (int index) {
            if (index < inclusions.Count) {
                exclusions.Add(inclusions[index]);
                inclusions.RemoveAt(index);
                return inclusions.Count + exclusions.Count - 1;
            }
            else {
                index -= inclusions.Count;
                inclusions.Add(exclusions[index]);
                exclusions.RemoveAt(index);
                return inclusions.Count - 1;
            }
        }

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
            foreach (CP_Selection inclusion in inclusions) {
                try {
                    foreach (string file in MiscFunctions.GetFiles(sourceFolder + "/" + inclusion.folder, inclusion.wildcards, SearchOption.AllDirectories)) {
                        bool exclude = false;
                        foreach (CP_Selection exclusion in exclusions) {
                            if (MiscFunctions.PathContainsWildcards(file, exclusion.folder, exclusion.wildcards)) {
                                exclude = true;
                                break;
                            }
                        }

                        if (!exclude) {
                            string newFile = file.Replace(sourceFolder, packageBuildFolder);
                            Directory.CreateDirectory(Path.GetDirectoryName(newFile));
                            File.Copy(file, newFile);
                        }
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
            inclusions = new List<CP_Selection>();
            exclusions = new List<CP_Selection>();

            inclusions.Add(new CP_Selection("config", "*.*"));
            inclusions.Add(new CP_Selection("scripts", "*.*"));
            inclusions.Add(new CP_Selection("betterrecords", "*.cfg*"));
            inclusions.Add(new CP_Selection("mods", "*.cfg|*.dat|*.json|*.conf"));

            exclusions.Add(new CP_Selection("config", "InvTweaksRules.txt"));
            exclusions.Add(new CP_Selection("config/JEI", "worldSettings.cfg"));
        }
    }
}
