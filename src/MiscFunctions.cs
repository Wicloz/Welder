using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welder {
    class MiscFunctions {
        //Returns true when kar is a digit
        public static bool IsDigit (char kar) {
            if (kar >= '0' && kar <= '9')
                return true;
            else
                return false;
        }

        //Returns the vesion of a mod without the minecraft version
        public static string VersionFromOnlineMod (string modName, string mcVersion) {
            char[] delims = new char[] {'.', '-', '_'};
            string version = modName.Split(delims, 2)[1];
            return ConvertToVersion(version).Replace(mcVersion, "").TrimStart(delims).TrimEnd(delims);
        }

        //Returns the vesion of a repo mod
        public static string VersionFromRepoMod (string modName, string modslug) {
            return modName.Replace(modslug + "-", "").Replace(".zip", "");
        }

        //Returns the first string in text between before and after
        public static string ExtractSection (string text, string before, string after) {
            return "";
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
