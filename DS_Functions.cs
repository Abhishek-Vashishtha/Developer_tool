using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Developer_Tools
{
    class DS_Functions
    {
        public static void startUpFilesChecking()
        {
            /* checking for default directories and files. if they are not present then create them */
            /* default directory */
            string pathName = @"D:\DevelopersTool";
            if (Directory.Exists(pathName) ==  false)
            {
                Directory.CreateDirectory(pathName);
                MessageBox.Show("New directory \"DevelopersTool\" created in D drive");
            }

            /* Communication traffic Log */
            pathName = "D:\\DevelopersTool\\DevelopersToolTrafficLogFile.txt";
            if(File.Exists(pathName) == false)
            {
                DS_TextFile.createNewFile(pathName);
            }

            /* Instant data logs */
            pathName = "D:\\DevelopersTool\\DevelopersToolEnergyMeterInstantLogFile.txt";
            if (File.Exists(pathName) == false)
            {
                DS_TextFile.createNewFile(pathName);
            }

            /* setup(JSON file) */
            pathName = "D:\\DevelopersTool\\DevelopersToolSetupFile.json";
            if (File.Exists(pathName) == false)
            {
                DS_JSON.createNewFile(pathName);
            }
        }
        public static void CloseUpFilesSaving()
        {

        }


        public static void loadParametersFromJson()
        {

        }
        public static void saveParametersIntoJson()
        {

        }
    }
}
