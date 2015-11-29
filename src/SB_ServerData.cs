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
        public string arguments = "-Xmn2G -Xss4M -Xms4G -Xmx4G -XX:+UseLargePages -XX:+AggressiveOpts -XX:+UseFastAccessorMethods -XX:+OptimizeStringConcat -XX:+UseBiasedLocking -Xincgc -XX:MaxGCPauseMillis=10 -XX:SoftRefLRUPolicyMSPerMB=10000 -XX:+CMSParallelRemarkEnabled -XX:ParallelGCThreads=10 -Djava.net.preferIPv4Stack=true -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true";
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
        public string exportFileLatest {
            get {
                return destFolder + "/" + serverSlug + "-latest-server.zip";
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
            if (Directory.Exists(serverFolder)) {
                foreach (string file in Directory.GetFiles(serverFolder, "*.*", SearchOption.AllDirectories)) {
                    if (Path.GetFileName(file) != "server.properties")
                        File.Delete(file);
                }
                MiscFunctions.RemoveEmptyFolders(serverFolder, false);
            }
            Directory.CreateDirectory(serverFolder);

            List<string> copyFiles = new List<string>();
            string[] copyFolders = new string[] {"betterrecords", "Flan", "hats", "config", "scripts"};

            foreach (string file in Directory.GetFiles(sourceFolder, "*.*", SearchOption.AllDirectories)) {
                foreach (string copyFolder in copyFolders) {
                    if (file.StartsWith(sourceFolder + "\\" + copyFolder + "\\")) {
                        copyFiles.Add(file);
                        break;
                    }
                }
                if ((file.StartsWith(sourceFolder + "\\mods\\") || file.StartsWith(sourceFolder + "\\coremods\\")) && !SB_ExceptionManager.IsException(Path.GetFileName(file)))
                    copyFiles.Add(file);
            }

            foreach (string file in copyFiles) {
                string newFile = file.Replace(sourceFolder, serverFolder);
                Directory.CreateDirectory(Path.GetDirectoryName(newFile));
                File.Copy(file, newFile);
            }

            File.WriteAllText(serverFolder + "/eula.txt", "#By changing the setting below to TRUE you are indicating your agreement to our EULA (https://account.mojang.com/documents/minecraft_eula).\neula = true\n");
            File.AppendAllText(serverFolder + "/RUN.bat", "@ECHO OFF\n\n");
            if (addBackup)
                File.AppendAllText(serverFolder + "/RUN.bat", "ECHO Backing up world ...\nrmdir backups\\backup_before / Q / S\nrobocopy world backups\\backup_before / e\n\n");
            File.AppendAllText(serverFolder + "/RUN.bat", "ECHO Starting server ...\njava " + arguments + " -jar modpack.jar nogui\n\n");
            if (addBackup)
                File.AppendAllText(serverFolder + "/RUN.bat", "ECHO Backing up world ...\nrmdir backups\\backup_after / Q / S\nrobocopy world backups\\backup_after / e\n\n");
            File.AppendAllText(serverFolder + "/RUN.bat", "pause\nexit");
            if (addBackup) {
                Directory.CreateDirectory(serverFolder + "/backups");
                File.WriteAllText(serverFolder + "/backups/backups.txt", "backups folder\n");
            }
            if (File.Exists(sourceFolder + "/bin/modpack.jar"))
                File.Copy(sourceFolder + "/bin/modpack.jar", serverFolder + "/modpack.jar");

            using (WebClient client = new WebClient()) {
                client.DownloadFile(serverJarOnline, serverJarLocal);
                client.DownloadFile("https://dl.dropboxusercontent.com/u/46484032/TMC/ForgeLibs.zip", serverFolder + "/libraries.zip");
            }
            ZipFile.ExtractToDirectory(serverFolder + "/libraries.zip", serverFolder + "/libraries");
            File.Delete(serverFolder + "/libraries.zip");

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
            File.Copy(exportFile, exportFileLatest);
        }
    }
}
