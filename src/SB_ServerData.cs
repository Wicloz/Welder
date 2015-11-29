using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.IO.Compression;

namespace Welder {
    [Serializable]
    public class SB_ServerData {
        public string serverName = "NONE";
        public string serverVersion = "";
        public string mcVersion = "";
        public string sourceFolder = "";
        public string destFolder = "";
        public bool addBackup = true;

        public string serverSlug {
            get {
                return MiscFunctions.ConvertToSlug(serverName);
            }
        }
        public string serverFolder {
            get {
                return ServerBuilder.cd + "/servers/" + serverSlug;
            }
        }
        public string serverTestFolder {
            get {
                return ServerBuilder.cd + "/servers/tests/" + serverSlug;
            }
        }
        public string exportFile {
            get {
                return destFolder + "/" + serverSlug + "-" + serverVersion + "-server.zip";
            }
        }

        public string serverJarOnline {
            get {
                return "https://s3.amazonaws.com/Minecraft.Download/versions/" + mcVersion + "/minecraft_server." + mcVersion + ".jar";
            }
        }
        public string serverJarLocal {
            get {
                return serverFolder + "/minecraft_server." + mcVersion + ".jar";
            }
        }

        public SB_ServerData () { }

        //Builds a server release
        public void BuildServer () {
            if (Directory.Exists(serverFolder))
                Directory.Delete(serverFolder, true);
            Directory.CreateDirectory(serverFolder);

            using (WebClient client = new WebClient()) {

            }

            MiscFunctions.RemoveEmptyFolders(serverFolder, false);
        }

        //Makes a copy of the build folder
        public void CopyTestServer () {
            if (Directory.Exists(serverTestFolder))
                Directory.Delete(serverTestFolder, true);
            Directory.CreateDirectory(serverFolder);
            Directory.CreateDirectory(serverTestFolder);
            foreach (string file in Directory.GetFiles(serverFolder, "*.*", SearchOption.AllDirectories)) {
                string newFile = file.Replace(serverFolder, serverTestFolder);
                Directory.CreateDirectory(Path.GetDirectoryName(newFile));
                File.Copy(file, newFile);
            }
        }

        //Copies the server.properties back and deletes the test folder
        public void ClearTestServer () {
            if (File.Exists(serverTestFolder + "/server.properties")) {
                File.Delete(serverFolder + "/server.properties");
                File.Move(serverTestFolder + "/server.properties", serverFolder + "/server.properties");
            }
            if (Directory.Exists(serverTestFolder))
                Directory.Delete(serverTestFolder, true);
            MiscFunctions.RemoveEmptyFolders(serverTestFolder + "/..", true);
        }

        //Creates a server zipfile in the destination
        public void ExportServer () {
            File.Delete(exportFile);
            MiscFunctions.RemoveEmptyFolders(serverFolder, false);
            ZipFile.CreateFromDirectory(serverFolder, exportFile, CompressionLevel.Optimal, false);
        }
    }
}
