﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Welder {
    enum ActionStates {idle, update, check, find};

    class MiscFunctions {
        //Deletes only empty folders in the specified root
        public static void RemoveEmptyFolders (string root, bool includeRoot) {
            if (Directory.Exists(root)) {
                foreach (string folder in Directory.GetDirectories(root)) {
                    RemoveEmptyFolders(folder, true);
                }
                if (Directory.GetFiles(root).Length == 0 && Directory.GetDirectories(root).Length == 0) {
                    if (includeRoot)
                        Directory.Delete(root);
                }
            }
        }

        //Returns the string formatted as a slug
        public static string ConvertToSlug (string name) {
            return name.ToLower().Replace(" ", "-");
        }

        //Returns a cookie aware webclient authenticated with the speciefied email and password
        public static CookieAwareWebClient GetAuthenticatedWebClient (string solderUrl, string email, string password) {
            string loginAddress = solderUrl + "login";
            System.Collections.Specialized.NameValueCollection loginData = new System.Collections.Specialized.NameValueCollection {{"email", email}, {"password", password}};
            CookieAwareWebClient client = new CookieAwareWebClient();
            client.UploadValues(loginAddress, loginData);
            return client;
        }

        //Sends a modversion to the specified mod at the solder website
        public static void SendSolderModVersion (string solderUrl, string email, string password, string id, string version) {
            using (CookieAwareWebClient client = GetAuthenticatedWebClient(solderUrl, email, password)) {
                string getURL = solderUrl + "post.php?id=" + id + "&version=" + version;
                var cookies = client.CookieContainer.GetCookies(new Uri(solderUrl.Substring(0, solderUrl.Length - 1)));

                System.Windows.Forms.WebBrowser browser = new System.Windows.Forms.WebBrowser();
                browser.Navigate(getURL, "", null, "Cookie: " + cookies[0].Value + Environment.NewLine + "Cookie: " + cookies[1].Value + Environment.NewLine);
            }
        }

        //Allows usage of the GetFiles function with multiple searchPattern
        public static string[] GetFiles (string path, string searchPattern, SearchOption searchOption) {
            string[] searchPatterns = searchPattern.Split('|');
            List<string> files = new List<string>();
            foreach (string sp in searchPatterns)
                files.AddRange(Directory.GetFiles(path, sp, searchOption));
            files.Sort();
            return files.ToArray();
        }

        //Returns true if the path ends with folder, followed by wildcards
        //Returns true if the operation gives an error
        public static bool PathContainsWildcards (string path, string folder, string wildcards) {
            path = path.Replace('/', '\\');
            folder = folder.Replace('/', '\\');
            try {
                string[] folderArray = new string[] {folder};
                char[] trimChars = new char[] {'\\', '/'};
                string afterFolder = path.Split(folderArray, StringSplitOptions.None)[1].TrimStart(trimChars);
                return afterFolder == wildcards;
            }
            catch {
                return false;
            }
        }

        //Returns the site config for a certain website url
        public static MM_SiteConfig GetSiteConfig (string website) {
            foreach (MM_SiteConfig config in ModManager.sites) {
                if (website.Contains(config.identifier))
                    return config;
            }
            return new MM_SiteConfig();
        }

        //Returns the identifier for a certain config name
        public static string GetSiteIdentifier (string name) {
            foreach (MM_SiteConfig config in ModManager.sites) {
                if (config.name == name)
                    return config.identifier;
            }
            return "no config with that name"; //Arbitrary string that no url would contain
        }

        //Returns true when kar is a digit
        public static bool IsDigit (char kar) {
            return (kar >= '0' && kar <= '9');
        }

        //Returns whether a string could be a site or not
        public static bool IsValidSite (string url) {
            return ((url.Contains("http://") || url.Contains("https://")) && url.Contains("."));
        }

        //Returns the vesion of a mod without the minecraft version
        public static string VersionFromOnlineMod (string modName, string mcVersion) {
            char[] delims = new char[] {'.', '-', '_'};
            //string version = modName.Split(delims, 2)[1];
            return ConvertToVersion(modName).Replace(mcVersion, "").TrimStart(delims).TrimEnd(delims);
        }

        //Returns the vesion of a repo mod
        public static string VersionFromRepoMod (string modName, string modslug) {
            return modName.Replace(modslug + "-", "").Replace(".zip", "");
        }

        //Returns whether text1 contains text2 or tex2 contains text1
        public static bool PartialMatch (string text1, string text2) {
            string text1Clean = CleanString(text1);
            string text2Clean = CleanString(text2);
            return (text1Clean.Contains(text2Clean) || text2Clean.Contains(text1Clean));
        }

        //Returns the first string in text between before and after
        public static string ExtractSection (string text, string before, string after) {
            string returnString = "";
            string[] beforeArray = new string[] {before};
            string[] afterArray = new string[] {after};

            if (before == "")
                returnString = text;
            else if (text.Split(beforeArray, StringSplitOptions.RemoveEmptyEntries).Length > 1)
                returnString = text.Split(beforeArray, 2, StringSplitOptions.RemoveEmptyEntries)[1];
            if (returnString.Split(afterArray, StringSplitOptions.RemoveEmptyEntries).Length > 0)
                returnString = returnString.Split(afterArray, 2, StringSplitOptions.RemoveEmptyEntries)[0];

            return returnString;
        }

        //Removes a bunch of characters and numbers from a string
        public static string CleanString (string originalString) {
            return originalString
                .ToLower()
                .Replace("0", "")
                .Replace("1", "")
                .Replace("2", "")
                .Replace("3", "")
                .Replace("4", "")
                .Replace("5", "")
                .Replace("6", "")
                .Replace("7", "")
                .Replace("8", "")
                .Replace("9", "")
                .Replace(".zip", "")
                .Replace(".jar", "")
                .Replace(".disabled", "")
                .Replace(".txt", "")
                .Replace("-", "")
                .Replace("_", "")
                .Replace(" ", "")
                .Replace(".", "")
                .Replace("[", "")
                .Replace("]", "")
                .Replace("(", "")
                .Replace("}", "");
        }

        //Returns only numbers seperated by dots
        public static string ConvertToVersion (string text) {
            string returnString = "";
            char[] charArray = text.Replace(" ", "").ToLower().ToCharArray();

            returnString += "#";
            bool dotMade = true;
            foreach (char c in charArray) {
                if (IsDigit(c)) {
                    returnString += c;
                    dotMade = false;
                }
                else if (!dotMade) {
                    returnString += ".";
                    dotMade = true;
                }
            }

            returnString += "#";
            return returnString.Replace("..", ".").Replace("..", ".").Replace("..", ".").Replace(".#", "").Replace("#.", "").Replace("#", "");
        }
    }
}
