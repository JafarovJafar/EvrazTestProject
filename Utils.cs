using System;

namespace EvrazTestProject
{
    static class Utils
    {
        public static void AddNewLineToString(ref string currentString, string newLine)
        {
            bool isFirstLine = currentString == string.Empty ? true : false;

            currentString += (isFirstLine ? string.Empty : Environment.NewLine) + newLine;
        }
    }
}