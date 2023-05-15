using System;
using System.Collections.Generic;
using System.IO;
namespace Developer_Tools
{
    class DS_TextFile
    {
        public static void createNewFile(string path)
        {
            StreamWriter sw = File.AppendText(path);
            sw.Close();
            sw.Dispose();
        }
        public static string readFile(string path)
        {
            string fileContents = System.IO.File.ReadAllText(@path);
            return fileContents;
        }

        public static void appendToFile(string path, string data)
        {
            StreamWriter sw = File.AppendText(path);
            sw.Write(data);
            sw.Close();
            sw.Dispose();
        }
    }
}
