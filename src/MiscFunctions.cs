using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welder {
    class MiscFunctions {
        //Returns everything before the first dash, cleaned
        public static string CleanModName (string originalName) {
            char[] delim = new char[] { '-' };
            string proDash = originalName.Split(delim)[0];
            return CleanString(proDash).Replace("botaniar", "botania");
        }

        //Removes a bunch of characyers and numbers from a string
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

        //Removes all letters from a string and returns only numbers seperated by dots
        public static string RemoveLetters (string originalString) {
            string returnString = "";
            char[] charArray = originalString.Replace(" ", "").ToLower().ToCharArray();
            List<char> allowedList = new List<char>();

            allowedList.Add('1');
            allowedList.Add('2');
            allowedList.Add('3');
            allowedList.Add('4');
            allowedList.Add('5');
            allowedList.Add('6');
            allowedList.Add('7');
            allowedList.Add('8');
            allowedList.Add('9');
            allowedList.Add('0');

            returnString += "#";
            bool pointMade = true;

            foreach (char c in charArray) {
                if (allowedList.Contains(c)) {
                    returnString += c;
                    pointMade = false;
                }
                else if (!pointMade) {
                    returnString += ".";
                    pointMade = true;
                }
            }

            returnString += "#";
            return returnString.Replace(".#", "").Replace("#.", "").Replace("#", "").Replace("..", ".").Replace("..", ".").Replace("..", ".");
        }
    }
}
