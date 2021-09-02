using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Developer_Tools
{
    class DS_JSON 
    {
        public static void createNewFile(string path)
        {
            StreamWriter sw = File.AppendText(path);
            sw.Write("{\n\"is_blank\"\t:true\n}");
            sw.Close();
            sw.Dispose();
        }
    }
}
