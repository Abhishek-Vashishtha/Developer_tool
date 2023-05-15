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
                string header = "Time\tRTC\tVoltage\t\t\tVoltage DC\t\t\tCurrent\t\t\t\tCurrent DC\t\t\t\tPF\t\t\t\tAngle\t\t\tPower(W)\t\t\t\tPower(VAR)\t\t\t\tPower(VA)\t\t\t\tPower(VA)-vi\t\t\t\tPower(VA)-power triangle\t\t\t\tFrequency\t\t\t\tQuadrant\t\t\t\tSamples\t\t\t\t\tTHD(Vol)\t\t\tTHD(Curr)\t\t\tCurr_N_vect\tAngle_N_vect\tVoltage\t\t\tAngle\t\t\tActive Err(%)\t\t\t\tRective Err(%)\t\t\t\tApparent Err(%)\t\t\t\t" +
                    "Energy(Wh)\t\t\t\t\t\t\t\tEnergy(VARh)\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tEnergy(VAh)\t\t\t\t\t\t\t\t" +
                    "Fundamental Energy(Wh)\t\t\t\t\t\t\t\tDefraud Energy(Wh)\t\t\t\tActive Pulse\t\t\t\t\t\t\t\tReactive Pulse\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tApparent Pulse\t\t\t\t\t\t\t\tFundamental Power(Wh)\t\t\t\tTemperature(C)\tCycle/Sec\tBAttery vol(V)\tRTC Coltage(V)\tMetering Mode\tFG Flag\t" +
                    "Reactive Samples\tReactive Timer\tReactive Time delay\tReactive Time deviation\tMISC Data\tTamper Data\n";
                DS_TextFile.createNewFile(pathName);
                DS_TextFile.appendToFile(pathName, header);
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
