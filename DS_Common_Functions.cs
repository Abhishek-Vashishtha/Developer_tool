using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Developer_Tools
{
    class DS_Common_Functions
    {
        public static void startUpFilesChecking()
        {
            /* checking for default directories and files. if they are not present then create them */
            /* default directory */
            string pathName = @"D:\DevelopersTool";
            if (Directory.Exists(pathName) ==  false)
            {
                Directory.CreateDirectory(pathName);
            }

            /* Communication traffic Log */
            pathName = "D:\\DevelopersTool\\DevelopersToolTrafficLogFile.txt";
            if(File.Exists(pathName) == false)
            {
                StreamWriter sw = File.CreateText(pathName);
                sw.Close();
                sw.Dispose();
            }
            /* Instant data logs */
            pathName = "D:\\DevelopersTool\\DevelopersToolEnergyMeterInstantLogFile.txt";
            if (File.Exists(pathName) == false)
            {
                StreamWriter sw = File.CreateText(pathName);
                sw.Close();
                sw.Dispose();
            }

            /* setup(JSON file) */
            pathName = "D:\\DevelopersTool\\DevelopersToolSetupFile.json";
            if (File.Exists(pathName) == false)
            {
                StreamWriter sw = File.CreateText(pathName);
                sw.Close();
                sw.Dispose();
            }
        }
    }
}
