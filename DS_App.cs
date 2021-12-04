using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Developer_Tools
{
    class DS_App
    {
        public static void startUpFilesChecking()
        {
            /* checking for default directories and files. if they are not present then create them */
            /* default directory */
            string pathName = @"D:\DevelopersTool";
            if (Directory.Exists(pathName) ==  false)
            {
                Directory.CreateDirectory(pathName);
                Thread t = new Thread(() => MessageBox.Show("New directory \"DevelopersTool\" created in D drive"));
                t.Start();
            }

            /* Communication traffic Log */
            pathName = "D:\\DevelopersTool\\DevelopersToolCommunicationTrafficLogFile.txt";
            if(File.Exists(pathName) == false)
            {
                DS_TextFile.createNewFile(pathName);
            }

            /* Instant data logs */
            pathName = "D:\\DevelopersTool\\DevelopersToolEnergyMeterInstantDataLogFile.txt";
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
