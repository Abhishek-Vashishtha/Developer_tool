using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows;

namespace Developer_Tools
{
    public partial class Form1 : Form
    {
        /* global variables */
        string newline = Environment.NewLine;
        public static bool login_success = false;

        /* communication traffic */
        static int traffic_mode;
        static string traffic_string = String.Empty;

        /* configuration file */
        string config_file_name;

        /* communication */
        byte[] temp_b_array = new byte[1000];
        int temp_b_array_length;
        byte[] tx_buffer = new byte[550];
        byte[] rx_buffer = new byte[550];


        /* Serial Port */
        DS_Serial serial_port = new DS_Serial();

        /******************************** Energy Meter Variables ********************************/
        /* input signal */
        public static double ip_vol_r, ip_vol_y, ip_vol_b, ip_curr_r, ip_curr_y, ip_curr_b, ip_curr_n_calculated;
        public static double ip_ang_r, ip_ang_y, ip_ang_b, ip_ang_n_calculated, ip_ang_ry, ip_ang_rb;
        public static double ip_freq;
        public static double ip_watt_r, ip_watt_y, ip_watt_b, ip_watt_total_fwd, ip_watt_total_net, ip_var_r, ip_var_y, ip_var_b, ip_var_total_fwd, ip_var_total_net, ip_va_r, ip_va_y, ip_va_b, ip_va_total_fwd, ip_va_total_net;
        public static double ip_pf_r, ip_pf_y, ip_pf_b, ip_pf_fwd, ip_pf_net;
        public static int ip_metering_mode;
        /* error calculation */
        public static int ip_avg_samples;
        public static bool cal_accuracy;
        public static ushort Meter_Const;

        /* instant frame variables */
        public static double VolR, VolY, VolB, CurrRSigned, CurrYSigned, CurrBSigned, CurrN, CurrNVector, VolRY, VolYB, VolBR;
        public static double VolRdc, VolYdc, VolBdc, CurrRdc, CurrYdc, CurrBdc, CurrNdc;
        public static double PFR, PFY, PFB, PFNet;
        public static double AnglePFR, AnglePFY, AnglePFB, AngleNVector, AngleRY, AngleYB, AngleBR;
        public static double WattR, WattY, WattB, WattNet;
        public static double WattRFunda, WattYFunda, WattBFunda, WattNetFunda;
        public static double VARR, VARY, VARB, VARNet;
        public static double VAR, VAY, VAB, VANet;
        public static double FreqR, FreqY, FreqB, FreqNet;
        public static int QuadrantR, QuadrantY, QuadrantB, QuadrantNet;
        public static int SamplesR, SamplesY, SamplesB, SamplesN, SamplesPerSec;
        public static double THDVr, THDVy, THDVb, THDIr, THDIy, THDIb;

        private void buttonOddComEvenSeg_Click(object sender, EventArgs e)
        {
            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0x58;
            temp_b_array[2] = 0x00;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0x00;
            temp_b_array[5] = 0x03;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 6);
            temp_b_array_length = 8;

            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void buttonOddComOddSeg_Click(object sender, EventArgs e)
        {
            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0x58;
            temp_b_array[2] = 0x00;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0x00;
            temp_b_array[5] = 0x04;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 6);
            temp_b_array_length = 8;

            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void buttonAllSeg_Click(object sender, EventArgs e)
        {
            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0x58;
            temp_b_array[2] = 0x00;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0x00;
            temp_b_array[5] = 0x00;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 6);
            temp_b_array_length = 8;

            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void buttonDisableLCDTest_Click(object sender, EventArgs e)
        {
            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0x58;
            temp_b_array[2] = 0x00;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0xFF;
            temp_b_array[5] = 0xFF;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 6);
            temp_b_array_length = 8;

            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void buttonRTCCalibration_Click(object sender, EventArgs e)
        {
            int ppm;
            ppm = Convert.ToInt16(textBoxRTCPPM.Text);

            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0x57;
            temp_b_array[2] = 0x00;
            temp_b_array[3] = 0x00;
            if (ppm >= 0)
            {
                temp_b_array[4] = 0x00;            /* sign */
                temp_b_array[5] = (byte)ppm;       /* ppm */
            }
            else
            {
                temp_b_array[4] = 0x01;            /* sign */
                temp_b_array[5] = (byte)-ppm;      /* ppm */
            }
            temp_b_array[6] = 0x00;
            temp_b_array[7] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 6);
            temp_b_array_length = 8;

            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void buttonRTCOUT_Click(object sender, EventArgs e)
        {
            int rtcout_time;
            rtcout_time = Convert.ToInt16(textBoxRTCOUTTimeSeconds.Text);
            if (rtcout_time != 0 && rtcout_time <= 300)
            {
                rtcout_time *= 200;
                temp_b_array[0] = 0x27;
                temp_b_array[1] = 0x5A;
                temp_b_array[2] = 0x00;
                temp_b_array[3] = 0x00;
                temp_b_array[4] = (byte)(rtcout_time / 256);                /* time */
                temp_b_array[5] = (byte)(rtcout_time % 256);                /* time */
                temp_b_array[6] = 0x00;
                temp_b_array[7] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 6);                /* checksum from 1 to 6 */
                temp_b_array_length = 8; 
                serial_port.write(temp_b_array, 0, temp_b_array_length, false);
            }
            else
            {
                MessageBox.Show("Invalid Time..");
            }
        }

        private void button_CommandMemoryFF_Click(object sender, EventArgs e)
        {
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0xFF;
            temp_b_array[2] = 0x05;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0x00;
            temp_b_array[5] = 0x00;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = 0x00;
            temp_b_array[8] = 0x00;
            temp_b_array[9] = 0x00;
            temp_b_array[10] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 9);
            temp_b_array_length = 11;
            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void button_CommandFGTrigger_Click(object sender, EventArgs e)
        {
            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0xFF;
            temp_b_array[2] = 0x06;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0x00;
            temp_b_array[5] = 0x00;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = 0x00;
            temp_b_array[8] = 0x00;
            temp_b_array[9] = 0x00;
            temp_b_array[10] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 9);
            temp_b_array_length = 11;
            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void button_CommandDumpLoadSurvey_Click(object sender, EventArgs e)
        {
            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0xFF;
            temp_b_array[2] = 0x03;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0x00;
            temp_b_array[5] = 0x00;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = 0x00;
            temp_b_array[8] = 0x00;
            temp_b_array[9] = 0x00;
            temp_b_array[10] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 9);
            temp_b_array_length = 11;
            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void button_CommandDumpEEPROM_Click(object sender, EventArgs e)
        {
            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0xFF;
            temp_b_array[2] = 0x04;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0x00;
            temp_b_array[5] = 0x00;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = 0x00;
            temp_b_array[8] = 0x00;
            temp_b_array[9] = 0x00;
            temp_b_array[10] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 9);
            temp_b_array_length = 11;
            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void buttonEvenComOddSeg_Click(object sender, EventArgs e)
        {
            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0x58;
            temp_b_array[2] = 0x00;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0x00;
            temp_b_array[5] = 0x02;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 6);
            temp_b_array_length = 8;

            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void buttonEvenComEvenSeg_Click(object sender, EventArgs e)
        {
            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0x58;
            temp_b_array[2] = 0x00;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0x00;
            temp_b_array[5] = 0x01;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 6);
            temp_b_array_length = 8;

            serial_port.write(temp_b_array, 0, temp_b_array_length, false);
        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        public static double EnergyWhR_imp, EnergyWhY_imp, EnergyWhB_imp, EnergyWhTotal_imp;
        public static double EnergyWhR_exp, EnergyWhY_exp, EnergyWhB_exp, EnergyWhTotal_exp;
        public static double EnergyVARhR_q1, EnergyVARhY_q1, EnergyVARhB_q1, EnergyVARhTotal_q1;
        public static double EnergyVARhR_q2, EnergyVARhY_q2, EnergyVARhB_q2, EnergyVARhTotal_q2;
        public static double EnergyVARhR_q3, EnergyVARhY_q3, EnergyVARhB_q3, EnergyVARhTotal_q3;
        public static double EnergyVARhR_q4, EnergyVARhY_q4, EnergyVARhB_q4, EnergyVARhTotal_q4;
        public static double EnergyVAhR_imp, EnergyVAhY_imp, EnergyVAhB_imp, EnergyVAhTotal_imp;
        public static double EnergyVAhR_exp, EnergyVAhY_exp, EnergyVAhB_exp, EnergyVAhTotal_exp;
        public static double EnergyFWhR_imp, EnergyFWhY_imp, EnergyFWhB_imp, EnergyFWhTotal_imp;
        public static double EnergyFWhR_exp, EnergyFWhY_exp, EnergyFWhB_exp, EnergyFWhTotal_exp;
        public static int pulse_EnergyWhR_imp, pulse_EnergyWhY_imp, pulse_EnergyWhB_imp, pulse_EnergyWhTotal_imp;
        public static int pulse_EnergyWhR_exp, pulse_EnergyWhY_exp, pulse_EnergyWhB_exp, pulse_EnergyWhTotal_exp;
        public static int pulse_EnergyVARhR_q1, pulse_EnergyVARhY_q1, pulse_EnergyVARhB_q1, pulse_EnergyVARhTotal_q1;
        public static int pulse_EnergyVARhR_q2, pulse_EnergyVARhY_q2, pulse_EnergyVARhB_q2, pulse_EnergyVARhTotal_q2;
        public static int pulse_EnergyVARhR_q3, pulse_EnergyVARhY_q3, pulse_EnergyVARhB_q3, pulse_EnergyVARhTotal_q3;
        public static int pulse_EnergyVARhR_q4, pulse_EnergyVARhY_q4, pulse_EnergyVARhB_q4, pulse_EnergyVARhTotal_q4;
        public static int pulse_EnergyVAhR_imp, pulse_EnergyVAhY_imp, pulse_EnergyVAhB_imp, pulse_EnergyVAhTotal_imp;
        public static int pulse_EnergyVAhR_exp, pulse_EnergyVAhY_exp, pulse_EnergyVAhB_exp, pulse_EnergyVAhTotal_exp;
        public static int pulse_EnergyFWhR_imp, pulse_EnergyFWhY_imp, pulse_EnergyFWhB_imp, pulse_EnergyFWhTotal_imp;
        public static int pulse_EnergyFWhR_exp, pulse_EnergyFWhY_exp, pulse_EnergyFWhB_exp, pulse_EnergyFWhTotal_exp;

        public static string Time;
        public static int powerUpSec, reactiveSamples, reactiveTimer, reactiveTimeDelay, reactiveTimeDeviation;
        public static long LoopCycles;
        public static double battery_voltage, battery_voltage_rtc, temperature_tlv;
        public static string MISCData, TamperStatus;
        public static byte MeteringMode, fg_flag;
        public static int METER_CONST = 1200, PULSE = 6;
        
        public static double error_act_r, error_act_y, error_act_b, error_act_total;
        public static double error_react_r, error_react_y, error_react_b, error_react_total;
        public static double error_app_r, error_app_y, error_app_b, error_app_total;

        public static byte[] tamper_status = new byte[8];
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* changing colors of fonts */
            menuStripMain.ForeColor = Color.Blue;

            /* creating files at startup */
            DS_App.startUpFilesChecking();

            /* Loading data from JSON */
            DS_App.loadParametersFromJson();

            timer10ms.Enabled = true;
            timer500ms.Enabled = true;
            timer100ms.Enabled = true;
            if (DS_Serial.GetPortNames().Length != 0)
            {
                comboBox_SerialSingleCOMPORT.Text = DS_Serial.GetPortNames()[0];
            }
            else
            {
                comboBox_SerialSingleCOMPORT.Text = string.Empty;
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* opens save file dialog */
            saveJSONFileDialog.Filter = "JSON files (*.json)|*.json";
            saveJSONFileDialog.InitialDirectory = "D:\\DevelopersTool";
            saveJSONFileDialog.Title = "Write the name of the configuration file.";
            saveJSONFileDialog.ShowDialog();

            /* creates a new json file */
            string fileName = saveJSONFileDialog.FileName;
            if (fileName.Length != 0)
            {
                try
                {
                    DS_JSON.createNewFile(fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* opens open file dialog */
            openJSONFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openJSONFileDialog.InitialDirectory = "D:\\DevelopersTool";
            openJSONFileDialog.Title = "Select the file to view";
            openJSONFileDialog.ShowDialog();

            /* displays the file in notepad */
            string fileName = openJSONFileDialog.FileName;
            if (fileName.Length != 0)
            {
                System.Diagnostics.Process.Start(@fileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* opens open file dialog */
            openJSONFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openJSONFileDialog.InitialDirectory = "D:\\DevelopersTool";
            openJSONFileDialog.Title = "Select the file to load";
            openJSONFileDialog.ShowDialog();

            /* reading the file into string */
            string fileName = openJSONFileDialog.FileName;
            if (fileName.Length != 0)
            {
                config_file_name = fileName;
                string data = DS_JSON.readFile(config_file_name);

                /* parsing JSON data from string */
                var jsonData = JObject.Parse(data);

                if (jsonData.HasValues == false)
                {
                    MessageBox.Show("Empty JSON file");
                }
                else
                {

                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (config_file_name == null)
            {
                MessageBox.Show("Configuration file not loaded");
            }
            else
            {
                /* save all the date into JSON file here */



                /* updating the text back to normal */
                if (saveToolStripMenuItem.Text == "Save'")
                {
                    saveToolStripMenuItem.Text = "Save";
                }
            }
        }

        private void writeUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string address = "mailto: dheeraj.singhal @genus.in?cc = dheerajsinghal01@gmail.com & subject = Developers % 20Tool % 20remarks % 3A";
            System.Diagnostics.Process.Start(@address);
        }

        private void webPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string address = "https://in.linkedin.com/in/dheerajsinghal";
            System.Diagnostics.Process.Start(@address);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An ultimate tool to do the job easily. write us your feedback/suggestions or request new feature @ dheeraj.singhal@genus.in");
        }

        private void buttonToolsInputTextBoxPaste_Click(object sender, EventArgs e)
        {
            textBox_ToolsInputString.Text = Clipboard.GetText();
        }

        private void buttonToolsInputTextBoxClear_Click(object sender, EventArgs e)
        {
            textBox_ToolsInputString.Text = String.Empty;
        }

        private void buttonToolsOutputTextBoxCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_ToolsOutputString.Text);
        }

        private void buttonToolsOutputTextBoxClear_Click(object sender, EventArgs e)
        {
            textBox_ToolsOutputString.Text = String.Empty;
        }

        private void button_SendRepeatStop_Click(object sender, EventArgs e)
        {
            serial_port.SendRepeatEnable = false;
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            /* Frame Creation */
            temp_b_array[0] = 0x27;
            temp_b_array[1] = 0xFF;
            temp_b_array[2] = 0x01;
            temp_b_array[3] = 0x00;
            temp_b_array[4] = 0x00;
            temp_b_array[5] = 0x00;
            temp_b_array[6] = 0x00;
            temp_b_array[7] = 0x00;
            temp_b_array[8] = 0x00;
            temp_b_array[9] = 0x00;
            temp_b_array[10] = DS_CRC.CRC_BCC_XOR(temp_b_array, 1, 9);
            temp_b_array_length = 11;

            /* Data sending with repeat facility */
            if (checkBox_SendRepeat.Checked == true)
            {
                serial_port.write(temp_b_array, 0, temp_b_array_length, false, true, Convert.ToInt32(textBox_SendRepeatTime.Text), Convert.ToInt32(textBox_SendRepeatNoOfTimes.Text));
            }
            else
            {
                serial_port.write(temp_b_array, 0, temp_b_array_length, false);
            }
        }

        private void buttonStringFilterConvert_Click(object sender, EventArgs e)
        {
            string input_ascii_string = String.Empty;
            string output_string = String.Empty;
            string output_format = String.Empty;

            /* getting output format */
            if (radiobuttonToolsOutputTextBoxHEX.Checked == true)
            {
                output_format = "HEX";
            }
            else if (radiobuttonToolsOutputTextBoxHEXSpaced.Checked == true)
            {
                output_format = "HEXSpaced";
            }
            else if (radiobuttonToolsOutputTextBoxASCII.Checked == true)
            {
                output_format = "ASCII";
            }

            /* Verify valid input data and making ascii string */
            if (radioButtonToolsInputTextBoxHEX.Checked == true)
            {
                if (DS_Functions.CheckValidHexString(textBox_ToolsInputString.Text) == true)
                {
                    input_ascii_string = DS_Functions.hex_string_to_ascii_string(textBox_ToolsInputString.Text);
                }
            }
            else if (radioButtonToolsInputTextBoxHEXSpaced.Checked == true)
            {
                if (DS_Functions.CheckValidHexString(DS_Functions.string_subtract(textBox_ToolsInputString.Text, " ", "")) == true)
                {
                    input_ascii_string = DS_Functions.hex_string_to_ascii_string(DS_Functions.string_subtract(textBox_ToolsInputString.Text, " ", ""));
                }
            }
            else if (radioButtonToolsInputTextBoxASCII.Checked == true)
            {
                input_ascii_string = textBox_ToolsInputString.Text;
            }


            if (string.IsNullOrEmpty(input_ascii_string) == false)
            {
                string ascii_str = string.Empty;


                /* removing the desired characters */
                if (checkBoxStringFilterRemoveSpace.Checked == true)
                {
                    ascii_str = DS_Functions.string_subtract(input_ascii_string, " ", "");
                }
                if (checkBoxStringFilterRemoveCR.Checked == true)
                {
                    ascii_str = DS_Functions.string_subtract(ascii_str, "\r", "");
                }
                if (checkBoxStringFilterRemoveLF.Checked == true)
                {
                    ascii_str = DS_Functions.string_subtract(ascii_str, "\n", "");
                }
                if (checkBoxStringFilterRemoveTab.Checked == true)
                {
                    ascii_str = DS_Functions.string_subtract(ascii_str, "\t", "");
                }


                /* getting output formatter */
                if (string.Equals(output_format, "HEX"))
                {
                    output_string = DS_Functions.ascii_string_to_hex_string(ascii_str);
                }
                else if (string.Equals(output_format, "HEXSpaced"))
                {
                    output_string = DS_Functions.ascii_string_to_hex_string_spaced(ascii_str);
                }
                else if (string.Equals(output_format, "ASCII"))
                {
                    output_string = ascii_str;
                }

                textBox_ToolsOutputString.Text = output_string;
            }
            else
            {
                MessageBox.Show("Invalid input String", "Error");
            }
        }

        private void button_ReadStop_Click(object sender, EventArgs e)
        {

        }

        private void buttonWordwrapConvert_Click(object sender, EventArgs e)
        {
            string input_string, output_string = "";
            input_string = textBox_ToolsInputString.Text;
            int wrap_len = Convert.ToInt16(textBoxWordwrapLength.Text);

            for (int i = 0; i < 1 + (input_string.Length / wrap_len); i++)
            {
                if ((i + 1) * wrap_len > input_string.Length)
                {
                    output_string += input_string.Substring(i * wrap_len, input_string.Length - i * wrap_len);
                }
                else
                {
                    output_string += input_string.Substring(i * wrap_len, wrap_len);
                }
                output_string += newline;
            }
            textBox_ToolsOutputString.Text = output_string;

        }

        /* calculate checsum/fcs etc */
        private void button_ToolsCalculateChecksum_Click(object sender, EventArgs e)
        {
            if (textBox_ToolsInputString.Text != String.Empty)
            {
                byte[] barray = null;
                bool input_string_error = false;
                if (radioButtonToolsInputTextBoxHEX.Checked == true || radioButtonToolsInputTextBoxHEXSpaced.Checked == true)
                {
                    if (DS_Functions.CheckValidHexSpacedString(textBox_ToolsInputString.Text) == true)
                    {
                        barray = DS_Functions.hex_string_to_byte_array(textBox_ToolsInputString.Text.Replace(" ", ""));
                    }
                    else
                    {
                        input_string_error = true;
                    }
                }
                else
                {
                    barray = DS_Functions.ascii_string_to_byte_array(textBox_ToolsInputString.Text);
                }

                if (input_string_error == false)
                {
                    textBox_ToolsChecksumMemory.Text = DS_Functions.byte_to_hex(DS_CRC.CRC_MEM(barray, 0, barray.Length));
                    textBox_ToolsChecksumBCCXOR.Text = DS_Functions.byte_to_hex(DS_CRC.CRC_BCC_XOR(barray, 0, barray.Length));
                    textBox_ToolsChecksumCRC16.Text = DS_Functions.int_to_hex(DS_CRC.get_fcs(barray, 0, barray.Length));
                }
                else
                {
                    MessageBox.Show("Error in input string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button_SendFramePaste_Click(object sender, EventArgs e)
        {
            textBox_SendFrame.Text = Clipboard.GetText();
        }

        private void button_SendFrameClear_Click(object sender, EventArgs e)
        {
            textBox_SendFrame.Text = String.Empty;
        }

        private void buttonDataTrafficCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_DataTraffic.Text);
        }

        private void buttonDataTrafficClear_Click(object sender, EventArgs e)
        {
            textBox_DataTraffic.Text = String.Empty;
            DS_Serial.totalRxBytes = 0;
            DS_Serial.totalTxBytes = 0;
            textBox_DataTrafficTxBytesTotal.Text = "0";
            textBox_DataTrafficRxBytesTotal.Text = "0";
        }

        private void ToolStripMenuItem_Connect_Click(object sender, EventArgs e)
        {
            if (radioButton_CommunicationSerial.Checked == true)
            {
                if (serial_port.Connect(comboBox_SerialSingleCOMPORT.Text, Convert.ToInt32(comboBox_SerialSingleBaudRate.Text)) == true)
                {

                }
            }
        }

        private void ToolStripMenuItem_Disconnect_Click(object sender, EventArgs e)
        {
            if (radioButton_CommunicationSerial.Checked == true)
            {
                if (serial_port.Disconnect() == true)
                {

                }
            }
        }

        private void timer500ms_Tick(object sender, EventArgs e)
        {
            bool connection_status;

            /* enable/disable functionlity as per flags */
            if (checkBox_SendRepeat.Checked == true)
            {
                textBox_SendRepeatTime.Enabled = true;
                textBox_SendRepeatNoOfTimes.Enabled = true;
                if (serial_port.SendRepeatEnable == true)
                {
                    button_SendRepeatStop.Enabled = true;
                    button_Send.Enabled = false;
                }
                else
                {
                    button_SendRepeatStop.Enabled = false;
                    button_Send.Enabled = true;
                }
            }
            else
            {
                textBox_SendRepeatTime.Enabled = false;
                textBox_SendRepeatTime.Text = "1000";
                textBox_SendRepeatNoOfTimes.Enabled = false;
                textBox_SendRepeatNoOfTimes.Text = "86400";
            }

            /* pop up notification when a port is connected or disconnected */
            DS_Serial.update_port_list();


            /* fill up information periodically */
            if (radioButton_CommunicationSerial.Checked == true && serial_port.IsOpen == true)
            {
                connection_status = true;
            }
            else
            {
                connection_status = false;
            }
           

            if (connection_status == true)                  /* Connected */
            {
                progressBar_connectionStatus.Value = 100;
                button_Send.Enabled = true;
                ToolStripMenuItem_Connect.Enabled = false;
                ToolStripMenuItem_Disconnect.Enabled = true;
                button_Read.Enabled = true;
            }
            else                                            /* Disconnected */
            {
                progressBar_connectionStatus.Value = 0;
                button_Send.Enabled = false;
                button_SendRepeatStop.Enabled = false;
                ToolStripMenuItem_Connect.Enabled = true;
                ToolStripMenuItem_Disconnect.Enabled = false;
                button_Read.Enabled = false;
            }
            try
            {
                textBox_SendRepeatSentCounter.Text = serial_port.SendRepeatSentCounter.ToString();
            }
            catch (Exception ex)
            {
                textBox_SendRepeatSentCounter.Text = ex.Message;
            }
            if (radioButton_DataTrafficFormatASCII.Checked == true)       /* ASCII */
            {
                traffic_mode = 1;
            }
            else if (radioButton_DataTrafficFormatHEX.Checked == true)  /* HEX */
            {
                traffic_mode = 2;
            }
            else if (radioButton_DataTrafficFormatHEXSpaced.Checked == true)  /* HEX Spaced */
            {
                traffic_mode = 3;
            }

            Meter_Const = Convert.ToUInt16(textBox_InputMeterConst.Text);
        }
        public void update_textboxes()
        {
            /* Communication traffic textbox update */
            string s = String.Empty;
            if (traffic_string.Length != 0)
            {
                s = traffic_string;
                traffic_string = String.Empty;
            }
            textBox_DataTraffic.AppendText(s);
            traffic_string = String.Empty; 
            
            textBox_DataTrafficTxBytesTotal.Text = DS_Serial.totalTxBytes.ToString();
            textBox_DataTrafficRxBytesTotal.Text = DS_Serial.totalRxBytes.ToString();
            
            /* Metrology Data text box update*/
            textBox_VolR.Text = VolR.ToString("0.00");
            textBox_VolY.Text = VolY.ToString("0.00");
            textBox_VolB.Text = VolB.ToString("0.00");
            textBox_VolRdc.Text = VolRdc.ToString();
            textBox_VolYdc.Text = VolYdc.ToString();
            textBox_VolBdc.Text = VolBdc.ToString();

            textBox_CurrR.Text = CurrRSigned.ToString("0.000");
            textBox_CurrY.Text = CurrYSigned.ToString("0.000");
            textBox_CurrB.Text = CurrBSigned.ToString("0.000");
            textBox_CurrN.Text = CurrN.ToString("0.000");

            textBox_CurrRdc.Text = CurrRdc.ToString();
            textBox_CurrYdc.Text = CurrYdc.ToString();
            textBox_CurrBdc.Text = CurrBdc.ToString();
            textBox_CurrNdc.Text = CurrNdc.ToString();

            textBox_PFR.Text = PFR.ToString("0.000");
            textBox_PFY.Text = PFY.ToString("0.000");
            textBox_PFB.Text = PFB.ToString("0.000");
            textBox_PFNet.Text = PFNet.ToString("0.000");

            textBox_AnglePFRph.Text = AnglePFR.ToString("0.00");
            textBox_AnglePFYph.Text = AnglePFY.ToString("0.00");
            textBox_AnglePFBph.Text = AnglePFB.ToString("0.00");

            textBox_WattR.Text = WattR.ToString("0.0");
            textBox_WattY.Text = WattY.ToString("0.0");
            textBox_WattB.Text = WattB.ToString("0.0");
            textBox_WattNet.Text = WattNet.ToString("0.0");

            textBox_WattRFunda.Text = WattRFunda.ToString("0.0");
            textBox_WattYFunda.Text = WattYFunda.ToString("0.0");
            textBox_WattBFunda.Text = WattBFunda.ToString("0.0");
            textBox_WattNetFunda.Text = WattNetFunda.ToString("0.0");

            textBox_VARR.Text = VARR.ToString("0.0");
            textBox_VARY.Text = VARY.ToString("0.0");
            textBox_VARB.Text = VARB.ToString("0.0");
            textBox_VARNet.Text = VARNet.ToString("0.0");

            textBox_VAR.Text = VAR.ToString("0.0");
            textBox_VAY.Text = VAY.ToString("0.0");
            textBox_VAB.Text = VAB.ToString("0.0");
            textBox_VANet.Text = VANet.ToString("0.0");

            textBox_VAR_vi.Text = (VolR * Math.Abs(CurrRSigned)).ToString("0.0");
            textBox_VAY_vi.Text = (VolY * Math.Abs(CurrYSigned)).ToString("0.0");
            textBox_VAB_vi.Text = (VolB * Math.Abs(CurrBSigned)).ToString("0.0");

            textBox_FreqR.Text = FreqR.ToString("0.000");
            textBox_FreqY.Text = FreqY.ToString("0.000");
            textBox_FreqB.Text = FreqB.ToString("0.000");
            textBox_FreqNet.Text = FreqNet.ToString("0.000");

            textBox_QuadR.Text = QuadrantR.ToString();
            textBox_QuadY.Text = QuadrantY.ToString();
            textBox_QuadB.Text = QuadrantB.ToString();
            textBox_QuadNet.Text = QuadrantNet.ToString();

            textBox_SamplesR.Text = SamplesR.ToString();
            textBox_SamplesY.Text = SamplesY.ToString();
            textBox_SamplesB.Text = SamplesB.ToString();
            textBox_SamplesPerSec.Text = SamplesPerSec.ToString();
            textBox_SamplesN.Text = SamplesN.ToString();

            textBox_THDVr.Text = THDVr.ToString("0.0");
            textBox_THDVy.Text = THDVy.ToString("0.0");
            textBox_THDVb.Text = THDVb.ToString("0.0");
            textBox_THDIr.Text = THDIr.ToString("0.0");
            textBox_THDIy.Text = THDIy.ToString("0.0");
            textBox_THDIb.Text = THDIb.ToString("0.0");

            textBox_EnergyWhImportR.Text = EnergyWhR_imp.ToString("0.000");
            textBox_EnergyWhImportY.Text = EnergyWhY_imp.ToString("0.000");
            textBox_EnergyWhImportB.Text = EnergyWhB_imp.ToString("0.000");
            textBox_EnergyWhImportTotal.Text = EnergyWhTotal_imp.ToString("0.000");
            textBox_EnergyWhExportR.Text = EnergyWhR_exp.ToString("0.000");
            textBox_EnergyWhExportY.Text = EnergyWhY_exp.ToString("0.000");
            textBox_EnergyWhExportB.Text = EnergyWhB_exp.ToString("0.000");
            textBox_EnergyWhExportTotal.Text = EnergyWhTotal_exp.ToString("0.000");

            textBox_EnergyVARhQ1R.Text = EnergyVARhR_q1.ToString("0.000");
            textBox_EnergyVARhQ1Y.Text = EnergyVARhY_q1.ToString("0.000");
            textBox_EnergyVARhQ1B.Text = EnergyVARhB_q1.ToString("0.000");
            textBox_EnergyVARhQ1Total.Text = EnergyVARhTotal_q1.ToString("0.000");
            textBox_EnergyVARhQ2R.Text = EnergyVARhR_q2.ToString("0.000");
            textBox_EnergyVARhQ2Y.Text = EnergyVARhY_q2.ToString("0.000");
            textBox_EnergyVARhQ2B.Text = EnergyVARhB_q2.ToString("0.000");
            textBox_EnergyVARhQ2Total.Text = EnergyVARhTotal_q2.ToString("0.000");
            textBox_EnergyVARhQ3R.Text = EnergyVARhR_q3.ToString("0.000");
            textBox_EnergyVARhQ3Y.Text = EnergyVARhY_q3.ToString("0.000");
            textBox_EnergyVARhQ3B.Text = EnergyVARhB_q3.ToString("0.000");
            textBox_EnergyVARhQ3Total.Text = EnergyVARhTotal_q3.ToString("0.000");
            textBox_EnergyVARhQ4R.Text = EnergyVARhR_q4.ToString("0.000");
            textBox_EnergyVARhQ4Y.Text = EnergyVARhY_q4.ToString("0.000");
            textBox_EnergyVARhQ4B.Text = EnergyVARhB_q4.ToString("0.000");
            textBox_EnergyVARhQ4Total.Text = EnergyVARhTotal_q4.ToString("0.000");

            textBox_EnergyVAhImportR.Text = EnergyVAhR_imp.ToString("0.000");
            textBox_EnergyVAhImportY.Text = EnergyVAhY_imp.ToString("0.000");
            textBox_EnergyVAhImportB.Text = EnergyVAhB_imp.ToString("0.000");
            textBox_EnergyVAhImportTotal.Text = EnergyVAhTotal_imp.ToString("0.000");
            textBox_EnergyVAhExportR.Text = EnergyVAhR_exp.ToString("0.000");
            textBox_EnergyVAhExportY.Text = EnergyVAhY_exp.ToString("0.000");
            textBox_EnergyVAhExportB.Text = EnergyVAhB_exp.ToString("0.000");
            textBox_EnergyVAhExportTotal.Text = EnergyVAhTotal_exp.ToString("0.000");

            textBox_FEnergyWhImportR.Text = EnergyFWhR_imp.ToString("0.000");
            textBox_FEnergyWhImportY.Text = EnergyFWhY_imp.ToString("0.000");
            textBox_FEnergyWhImportB.Text = EnergyFWhB_imp.ToString("0.000");
            textBox_FEnergyWhImportTotal.Text = EnergyFWhTotal_imp.ToString("0.000");
            textBox_FEnergyWhExportR.Text = EnergyFWhR_exp.ToString("0.000");
            textBox_FEnergyWhExportY.Text = EnergyFWhY_exp.ToString("0.000");
            textBox_FEnergyWhExportB.Text = EnergyFWhB_exp.ToString("0.000");
            textBox_FEnergyWhExportTotal.Text = EnergyFWhTotal_exp.ToString("0.000");

            textBox_ErrorActR.Text = error_act_r.ToString("0.00");
            textBox_ErrorActY.Text = error_act_y.ToString("0.00");
            textBox_ErrorActB.Text = error_act_b.ToString("0.00");
            textBox_ErrorActTotal.Text = error_act_total.ToString("0.00");

            textBox_ErrorReactR.Text = error_react_r.ToString("0.00");
            textBox_ErrorReactY.Text = error_react_y.ToString("0.00");
            textBox_ErrorReactB.Text = error_react_b.ToString("0.00");
            textBox_ErrorReactTotal.Text = error_react_total.ToString("0.00");

            textBox_ErrorAppR.Text = error_app_r.ToString("0.00");
            textBox_ErrorAppY.Text = error_app_y.ToString("0.00");
            textBox_ErrorAppB.Text = error_app_b.ToString("0.00");
            textBox_ErrorAppTotal.Text = error_app_total.ToString("0.00");


            textBox_CurrNeuVector.Text = CurrNVector.ToString("0.000");
            textBox_AngleNeuVector.Text = AngleNVector.ToString("0.00");

            textBox_Time.Text = Time;
            textBox_MetrologyTimer.Text = powerUpSec.ToString();

            textBox_VolRY.Text = VolRY.ToString("0.00");
            textBox_VolYB.Text = VolYB.ToString("0.00");
            textBox_VolBR.Text = VolBR.ToString("0.00");

            textBox_AngleRY.Text = AngleRY.ToString("0.00");
            textBox_AngleYB.Text = AngleYB.ToString("0.00");
            textBox_AngleBR.Text = AngleBR.ToString("0.00");

            textBox_Temperature.Text = temperature_tlv.ToString();
            textBox_BatteryVoltage.Text = battery_voltage.ToString("0.00");
            textBox_BatteryVoltageRTC.Text = battery_voltage_rtc.ToString("0.00");
            textBox_LoopCycles.Text = LoopCycles.ToString();

            textBox_ReactiveSamples.Text = reactiveSamples.ToString();
            textBox_ReactiveTimer.Text = reactiveTimer.ToString();
            textBox_ReactiveTimeDelay.Text = reactiveTimeDelay.ToString();
            textBox_ReactiveTimeDeviation.Text = reactiveTimeDeviation.ToString();

            TamperStatus = String.Empty;
            if (DS_Functions.checkBit(tamper_status[7], 0x80) == true) { TamperStatus += " | bit63"; }
            if (DS_Functions.checkBit(tamper_status[7], 0x40) == true) { TamperStatus += " | bit62"; }
            if (DS_Functions.checkBit(tamper_status[7], 0x20) == true) { TamperStatus += " | bit61"; }
            if (DS_Functions.checkBit(tamper_status[7], 0x10) == true) { TamperStatus += " | bit60"; }
            if (DS_Functions.checkBit(tamper_status[7], 0x08) == true) { TamperStatus += " | bit59"; }
            if (DS_Functions.checkBit(tamper_status[7], 0x04) == true) { TamperStatus += " | bit58"; }
            if (DS_Functions.checkBit(tamper_status[7], 0x02) == true) { TamperStatus += " | bit57"; }
            if (DS_Functions.checkBit(tamper_status[7], 0x01) == true) { TamperStatus += " | bit56"; }

            if (DS_Functions.checkBit(tamper_status[6], 0x80) == true) { TamperStatus += " | bit55"; }
            if (DS_Functions.checkBit(tamper_status[6], 0x40) == true) { TamperStatus += " | bit54"; }
            if (DS_Functions.checkBit(tamper_status[6], 0x20) == true) { TamperStatus += " | bit53"; }
            if (DS_Functions.checkBit(tamper_status[6], 0x10) == true) { TamperStatus += " | bit52"; }
            if (DS_Functions.checkBit(tamper_status[6], 0x08) == true) { TamperStatus += " | bit51"; }
            if (DS_Functions.checkBit(tamper_status[6], 0x04) == true) { TamperStatus += " | bit50"; }
            if (DS_Functions.checkBit(tamper_status[6], 0x02) == true) { TamperStatus += " | bit49"; }
            if (DS_Functions.checkBit(tamper_status[6], 0x01) == true) { TamperStatus += " | bit48"; }

            if (DS_Functions.checkBit(tamper_status[5], 0x80) == true) { TamperStatus += " | bit47"; }
            if (DS_Functions.checkBit(tamper_status[5], 0x40) == true) { TamperStatus += " | bit46"; }
            if (DS_Functions.checkBit(tamper_status[5], 0x20) == true) { TamperStatus += " | bit45"; }
            if (DS_Functions.checkBit(tamper_status[5], 0x10) == true) { TamperStatus += " | bit44"; }
            if (DS_Functions.checkBit(tamper_status[5], 0x08) == true) { TamperStatus += " | bit43"; }
            if (DS_Functions.checkBit(tamper_status[5], 0x04) == true) { TamperStatus += " | bit42"; }
            if (DS_Functions.checkBit(tamper_status[5], 0x02) == true) { TamperStatus += " | bit41"; }
            if (DS_Functions.checkBit(tamper_status[5], 0x01) == true) { TamperStatus += " | Faulty Capacitor"; }

            if (DS_Functions.checkBit(tamper_status[4], 0x80) == true) { TamperStatus += " | RTC Battery Low"; }
            if (DS_Functions.checkBit(tamper_status[4], 0x40) == true) { TamperStatus += " | Over Cureent B"; }
            if (DS_Functions.checkBit(tamper_status[4], 0x20) == true) { TamperStatus += " | Over Current Y"; }
            if (DS_Functions.checkBit(tamper_status[4], 0x10) == true) { TamperStatus += " | Over Current R"; }
            if (DS_Functions.checkBit(tamper_status[4], 0x08) == true) { TamperStatus += " | Abnormal Frequency"; }
            if (DS_Functions.checkBit(tamper_status[4], 0x04) == true) { TamperStatus += " | Two wire"; }
            if (DS_Functions.checkBit(tamper_status[4], 0x02) == true) { TamperStatus += " | RTC Error"; }
            if (DS_Functions.checkBit(tamper_status[4], 0x01) == true) { TamperStatus += " | bit32"; }

            if (DS_Functions.checkBit(tamper_status[3], 0x80) == true) { TamperStatus += " | 35KV/ESD"; }
            if (DS_Functions.checkBit(tamper_status[3], 0x40) == true) { TamperStatus += " | Invalid phase association"; }
            if (DS_Functions.checkBit(tamper_status[3], 0x20) == true) { TamperStatus += " | Invalid voltage"; }
            if (DS_Functions.checkBit(tamper_status[3], 0x10) == true) { TamperStatus += " | High Neutral Current"; }
            if (DS_Functions.checkBit(tamper_status[3], 0x08) == true) { TamperStatus += " | Wrong connection"; }
            if (DS_Functions.checkBit(tamper_status[3], 0x04) == true) { TamperStatus += " | Main battery low"; }
            if (DS_Functions.checkBit(tamper_status[3], 0x02) == true) { TamperStatus += " | Low Load"; }
            if (DS_Functions.checkBit(tamper_status[3], 0x01) == true) { TamperStatus += " | Over Load"; }

            if (DS_Functions.checkBit(tamper_status[2], 0x80) == true) { TamperStatus += " | EEPROM Fail"; }
            if (DS_Functions.checkBit(tamper_status[2], 0x40) == true) { TamperStatus += " | B Phase Active Export"; }
            if (DS_Functions.checkBit(tamper_status[2], 0x20) == true) { TamperStatus += " | Y Phase Active Export"; }
            if (DS_Functions.checkBit(tamper_status[2], 0x10) == true) { TamperStatus += " | R Phase Active Export"; }
            if (DS_Functions.checkBit(tamper_status[2], 0x08) == true) { TamperStatus += " | Phase sequence reverse"; }
            if (DS_Functions.checkBit(tamper_status[2], 0x04) == true) { TamperStatus += " | Top Cover"; }
            if (DS_Functions.checkBit(tamper_status[2], 0x02) == true) { TamperStatus += " | Low PF"; }
            if (DS_Functions.checkBit(tamper_status[2], 0x01) == true) { TamperStatus += " | Neutral Disturb"; }

            if (DS_Functions.checkBit(tamper_status[1], 0x80) == true) { TamperStatus += " | Magnet"; }
            if (DS_Functions.checkBit(tamper_status[1], 0x40) == true) { TamperStatus += " | Over Current"; }
            if (DS_Functions.checkBit(tamper_status[1], 0x20) == true) { TamperStatus += " | CT Bypass"; }
            if (DS_Functions.checkBit(tamper_status[1], 0x10) == true) { TamperStatus += " | Current Unbalance"; }
            if (DS_Functions.checkBit(tamper_status[1], 0x08) == true) { TamperStatus += " | CY Open B"; }
            if (DS_Functions.checkBit(tamper_status[1], 0x04) == true) { TamperStatus += " | CT Open Y"; }
            if (DS_Functions.checkBit(tamper_status[1], 0x02) == true) { TamperStatus += " | CT Open R"; }
            if (DS_Functions.checkBit(tamper_status[1], 0x01) == true) { TamperStatus += " | CT Reverse B"; }

            if (DS_Functions.checkBit(tamper_status[0], 0x80) == true) { TamperStatus += " | CT Reverse Y"; }
            if (DS_Functions.checkBit(tamper_status[0], 0x40) == true) { TamperStatus += " | CT Reverse R"; }
            if (DS_Functions.checkBit(tamper_status[0], 0x20) == true) { TamperStatus += " | Vol Unbalance"; }
            if (DS_Functions.checkBit(tamper_status[0], 0x10) == true) { TamperStatus += " | Vol Low"; }
            if (DS_Functions.checkBit(tamper_status[0], 0x08) == true) { TamperStatus += " | Vol High"; }
            if (DS_Functions.checkBit(tamper_status[0], 0x04) == true) { TamperStatus += " | Vol Miss B"; }
            if (DS_Functions.checkBit(tamper_status[0], 0x02) == true) { TamperStatus += " | Vol Miss Y"; }
            if (DS_Functions.checkBit(tamper_status[0], 0x01) == true) { TamperStatus += " | Vol Miss R"; }

            textBox_TamperStatus.Text = TamperStatus;
            if (MeteringMode == 0)
                textBox_MeteringMode.Text = "Fwd";
            else
                textBox_MeteringMode.Text = "Net";
            textBox_FgFlag.Text = fg_flag.ToString();
            textBox_MISCData.Text = MISCData;

            ///* Vector Diagram Display */
            //if (ShowVectorDiag == true)
            //{
            //    if (v_diag.Visible == false)
            //    {
            //        v_diag.ShowDialog();
            //    }
            //    v_diag.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
            //    v_diag.Update();      // forces Repaint of invalidated area 
            //    v_diag.Refresh();     // Combines Invalidate() and Update()
            //}
        }
        private void comboBox_SerialSingleCOMPORT_Click(object sender, EventArgs e)
        {
            comboBox_SerialSingleCOMPORT.Items.Clear();
            comboBox_SerialSingleCOMPORT.Items.AddRange(DS_Serial.GetPortNames());
        }


        private void timer10ms_Tick(object sender, EventArgs e)
        {
            serial_port.serial_loop_10ms();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            int send_frame_length = 0;

            /* validate the input frame */
            if (radioButton_SendFrameFormatHex.Checked == true)
            {
                if (DS_Functions.CheckValidHexSpacedString(textBox_SendFrame.Text) == false)
                {
                    MessageBox.Show("Invalid Input Data..!!");
                    return;
                }
            }

            /* calculating the length */
            send_frame_length = textBox_SendFrame.Text.Replace(" ", "").Length;

            if (radioButton_SendFrameFormatHex.Checked == true)
            {
                send_frame_length /= 2;
            }

            /* checking the length */
            if (checkBox_SendFrameHDLC.Checked == true)
            {
                if (send_frame_length >= 550 - 6)       /* 7E 7E A0 LEN FCS FCS */
                {
                    MessageBox.Show("Large Input Data..!!");
                    return;
                }
            }
            else
            {
                if (send_frame_length >= 550)
                {
                    MessageBox.Show("Large Input Data..!!");
                    return;
                }
            }

            /* making a byte aray from input data */
            if (radioButton_SendFrameFormatHex.Checked == true)
            {
                temp_b_array = DS_Functions.hex_string_to_byte_array(textBox_SendFrame.Text.Replace(" ", ""));
                temp_b_array_length = send_frame_length;
            }
            else
            {
                temp_b_array = DS_Functions.ascii_string_to_byte_array(textBox_SendFrame.Text);
                temp_b_array_length = send_frame_length;
            }

            if (checkBox_SendRepeat.Checked == true)
            {
                serial_port.write(temp_b_array, 0, temp_b_array_length, checkBox_SendFrameHDLC.Checked, true, Convert.ToInt32(textBox_SendRepeatTime.Text), Convert.ToInt32(textBox_SendRepeatNoOfTimes.Text));
            }
            else
            {
                serial_port.write(temp_b_array, 0, temp_b_array_length, checkBox_SendFrameHDLC.Checked);
            }
        }

        private void timer100ms_Tick(object sender, EventArgs e)
        {
            update_textboxes();     /* make it as a thread and do the operation */
        }

        private void textBox_InputVr_Click(object sender, EventArgs e)
        {
            textBox_InputVr.SelectAll();
        }
        private void textBox_InputVy_Click(object sender, EventArgs e)
        {
            textBox_InputVy.SelectAll();
        }
        private void textBox_InputVb_Click(object sender, EventArgs e)
        {
            textBox_InputVb.SelectAll();
        }
        private void textBox_InputIr_Click(object sender, EventArgs e)
        {
            textBox_InputIr.SelectAll();
        }
        private void textBox_InputIy_Click(object sender, EventArgs e)
        {
            textBox_InputIy.SelectAll();
        }
        private void textBox_InputIb_Click(object sender, EventArgs e)
        {
            textBox_InputIb.SelectAll();
        }
        private void textBox_InputAngr_Click(object sender, EventArgs e)
        {
            textBox_InputAngr.SelectAll();
        }
        private void textBox_InputAngy_Click(object sender, EventArgs e)
        {
            textBox_InputAngy.SelectAll();
        }
        private void textBox_InputAngb_Click(object sender, EventArgs e)
        {
            textBox_InputAngb.SelectAll();
        }

        private void textBox_InputAngRY_Click(object sender, EventArgs e)
        {
            textBox_InputAngRY.SelectAll();
        }

        private void textBox_InputAngRB_Click(object sender, EventArgs e)
        {
            textBox_InputAngRB.SelectAll();
        }

        private void textBox_InputFreq_Click(object sender, EventArgs e)
        {
            textBox_InputFreq.SelectAll();
        }

        private void textBox_ErrorAvg_Click(object sender, EventArgs e)
        {
            textBox_ErrorAvg.SelectAll();
        }

        private void button_InputUpdate_Click(object sender, EventArgs e)
        {
            ip_vol_r = Convert.ToDouble(textBox_InputVr.Text);
            ip_vol_y = Convert.ToDouble(textBox_InputVy.Text);
            ip_vol_b = Convert.ToDouble(textBox_InputVb.Text);

            ip_curr_r = Convert.ToDouble(textBox_InputIr.Text);
            ip_curr_y = Convert.ToDouble(textBox_InputIy.Text);
            ip_curr_b = Convert.ToDouble(textBox_InputIb.Text);

            ip_ang_r = Convert.ToDouble(textBox_InputAngr.Text);
            ip_ang_y = Convert.ToDouble(textBox_InputAngy.Text);
            ip_ang_b = Convert.ToDouble(textBox_InputAngb.Text);

            ip_freq = Convert.ToDouble(textBox_InputFreq.Text);
            ip_ang_ry = Convert.ToDouble(textBox_InputAngRY.Text);
            ip_ang_rb = Convert.ToDouble(textBox_InputAngRB.Text);
            ip_avg_samples = Convert.ToInt16(textBox_ErrorAvg.Text);

            if (radioButton_InputModeFwd.Checked == true)
            {
                ip_metering_mode = 0;                                          /* Forwarded Metering */
            }
            else
            {
                ip_metering_mode = 1;                                          /* Net Metering */
            }

            cal_accuracy = checkBox_ErrorCalculateEnable.Checked;

            ip_watt_r = ip_vol_r * ip_curr_r * Math.Cos(Math.PI * ip_ang_r / 180.0);
            ip_watt_y = ip_vol_y * ip_curr_y * Math.Cos(Math.PI * ip_ang_y / 180.0);
            ip_watt_b = ip_vol_b * ip_curr_b * Math.Cos(Math.PI * ip_ang_b / 180.0);

            ip_var_r = ip_vol_r * ip_curr_r * Math.Sin(Math.PI * ip_ang_r / 180.0);
            ip_var_y = ip_vol_y * ip_curr_y * Math.Sin(Math.PI * ip_ang_y / 180.0);
            ip_var_b = ip_vol_b * ip_curr_b * Math.Sin(Math.PI * ip_ang_b / 180.0);

            ip_va_r = Math.Sqrt(ip_watt_r * ip_watt_r + ip_var_r * ip_var_r);
            ip_va_y = Math.Sqrt(ip_watt_y * ip_watt_y + ip_var_y * ip_var_y);
            ip_va_b = Math.Sqrt(ip_watt_b * ip_watt_b + ip_var_b * ip_var_b);

            if (ip_va_r != 0)
            {
                ip_pf_r = ip_watt_r / ip_va_r;
            }
            else
            {
                ip_pf_r = 1;
            }
            if (ip_va_y != 0)
            {
                ip_pf_y = ip_watt_y / ip_va_y;
            }
            else
            {
                ip_pf_y = 1;
            }
            if (ip_va_b != 0)
            {
                ip_pf_b = ip_watt_b / ip_va_b;
            }
            else
            {
                ip_pf_b = 1;
            }
            int qr, qy, qb;
            if (ip_watt_r >= 0 && ip_var_r >= 0)
            {
                qr = 1;
            }
            else if (ip_watt_r < 0 && ip_var_r >= 0)
            {
                qr = 2;
            }
            else if (ip_watt_r < 0 && ip_var_r < 0)
            {
                qr = 3;
            }
            else
            {
                qr = 4;
            }
            if (ip_watt_y >= 0 && ip_var_y >= 0)
            {
                qy = 1;
            }
            else if (ip_watt_y < 0 && ip_var_y >= 0)
            {
                qy = 2;
            }
            else if (ip_watt_y < 0 && ip_var_y < 0)
            {
                qy = 3;
            }
            else
            {
                qy = 4;
            }
            if (ip_watt_b >= 0 && ip_var_b >= 0)
            {
                qb = 1;
            }
            else if (ip_watt_b < 0 && ip_var_b >= 0)
            {
                qb = 2;
            }
            else if (ip_watt_b < 0 && ip_var_b < 0)
            {
                qb = 3;
            }
            else
            {
                qb = 4;
            }

            ip_watt_total_fwd = Math.Abs(ip_watt_r) + Math.Abs(ip_watt_y) + Math.Abs(ip_watt_b);
            double temp = 0;
            if (qr == 1 || qr == 3)
                temp += Math.Abs(ip_var_r);
            else
                temp -= Math.Abs(ip_var_r);

            if (qy == 1 || qy == 3)
                temp += Math.Abs(ip_var_y);
            else
                temp -= Math.Abs(ip_var_y);

            if (qb == 1 || qb == 3)
                temp += Math.Abs(ip_var_b);
            else
                temp -= Math.Abs(ip_var_b);

            ip_var_total_fwd = temp;
            ip_va_total_fwd = Math.Sqrt(ip_watt_total_fwd * ip_watt_total_fwd + ip_var_total_fwd * ip_var_total_fwd);
            ip_pf_fwd = ip_watt_total_fwd / ip_va_total_fwd;

            ip_watt_total_net = ip_watt_r + ip_watt_y + ip_watt_b;
            ip_var_total_net = ip_var_r + ip_var_y + ip_var_b;
            ip_va_total_net = Math.Sqrt(ip_watt_total_net * ip_watt_total_net + ip_var_total_net * ip_var_total_net);
            ip_pf_net = ip_watt_total_net / ip_va_total_net;

            /* neutral current calculation Lag angle is +, Lead is - */
            double angle, mag;
            angle = 0;
            mag = ip_curr_r;
            Vector vect_ref = new Vector(mag * Math.Cos(angle * Math.PI / 180.0), mag * Math.Sin(angle * Math.PI / 180.0)); //ref is Vr

            angle = ip_ang_r;
            mag = ip_curr_r;
            Vector vect_ir = new Vector(mag * Math.Cos(angle * Math.PI / 180.0), mag * Math.Sin(angle * Math.PI / 180.0));

            angle = ip_ang_y + ip_ang_ry;
            mag = ip_curr_y;
            Vector vect_iy = new Vector(mag * Math.Cos(angle * Math.PI / 180.0), mag * Math.Sin(angle * Math.PI / 180.0));

            angle = ip_ang_b - ip_ang_rb;
            mag = ip_curr_b;
            Vector vect_ib = new Vector(mag * Math.Cos(angle * Math.PI / 180.0), mag * Math.Sin(angle * Math.PI / 180.0));

            Vector vect_in = Vector.Add(vect_ir, vect_iy);
            vect_in = Vector.Add(vect_in, vect_ib);
            ip_curr_n_calculated = vect_in.Length;
            if (ip_curr_n_calculated != 0)
            {
                ip_ang_n_calculated = Vector.AngleBetween(vect_in, vect_ref);
            }
            else
            {
                ip_ang_n_calculated = 0;
            }

            Meter_Const = Convert.ToUInt16(textBox_InputMeterConst.Text);

            /* updating text boxes */
            textBox_InputWattR.Text = ip_watt_r.ToString("0.0");
            textBox_InputWattY.Text = ip_watt_y.ToString("0.0");
            textBox_InputWattB.Text = ip_watt_b.ToString("0.0");
            textBox_InputWattTotalFwd.Text = ip_watt_total_fwd.ToString("0.0");
            textBox_InputWattTotalNet.Text = ip_watt_total_net.ToString("0.0");

            textBox_InputVARR.Text = ip_var_r.ToString("0.0");
            textBox_InputVARY.Text = ip_var_y.ToString("0.0");
            textBox_InputVARB.Text = ip_var_b.ToString("0.0");
            textBox_InputVARTotalFwd.Text = ip_var_total_fwd.ToString("0.0");
            textBox_InputVARTotalNet.Text = ip_var_total_net.ToString("0.0");

            textBox_InputVAR.Text = ip_va_r.ToString("0.0");
            textBox_InputVAY.Text = ip_va_y.ToString("0.0");
            textBox_InputVAB.Text = ip_va_b.ToString("0.0");
            textBox_InputVATotalFwd.Text = ip_va_total_fwd.ToString("0.0");
            textBox_InputVATotalNet.Text = ip_va_total_net.ToString("0.0");

            textBox_InputPFR.Text = ip_pf_r.ToString("0.000");
            textBox_InputPFY.Text = ip_pf_y.ToString("0.000");
            textBox_InputPFB.Text = ip_pf_b.ToString("0.000");
            textBox_InputPFFwd.Text = ip_pf_fwd.ToString("0.000");
            textBox_InputPFNet.Text = ip_pf_net.ToString("0.000");

            textBox_NeuCurrentCalculated.Text = ip_curr_n_calculated.ToString("0.000");
            textBox_NeuCurrentAngleCalculated.Text = ip_ang_n_calculated.ToString("0.00");
        }

        public static void fillTrafficString(string header, byte[] data, int length)
        {
            traffic_string += Environment.NewLine;
            traffic_string += header;
            if (traffic_mode == 1)       /* ASCII */
            {
                traffic_string += DS_Functions.byte_array_to_ascii_string(data, length);

            }
            else if (traffic_mode == 2)  /* HEX */
            {
                traffic_string += DS_Functions.byte_array_to_hex_string(data, length);
            }
            else if (traffic_mode == 3)  /* HEX Spaced */
            {
                traffic_string += DS_Functions.byte_array_to_hex_string_spaced(data, length);
            }
        }
        public static void ProcessForm1String(byte[] b_array, int b_array_len)
        {
            ushort arr_ptr = 0;
            /* Checking for valid HDLC Frame */
            if (DS_HDLC.verify_hdlc_frame(b_array, b_array_len) == true)
            {
                DS_HDLC.decode_hdlc_frame(b_array);
                if (DS_HDLC.HdlcCommandCode == 0)                        /* waveform capture */
                {
                    //debug_string_for_textbox = DS_Functions.Byte_Array_To_HEX_String(b_array, 0, b_array_len);
                    //update_wf_capture_info = true;
                }
                else if (DS_HDLC.HdlcCommandCode == 15)
                {
                    //debug_string_for_textbox = DS_Functions.Byte_Array_To_HEX_String(b_array, 9, 288);
                    //update_cal_data = true;
                }
                else if (DS_HDLC.HdlcCommandCode == 1)               /* Instant Data frame */
                {
                    /* reading data into variables */

                    /* Displaying in the checkbox */

                    /* showing vector diagram */

                    /* taking log into file */
                    arr_ptr = 9;
                    VolR = DS_Functions.ByteArrayToUs32(b_array, arr_ptr, 100); arr_ptr += 4;
                    VolY = DS_Functions.ByteArrayToUs32(b_array, arr_ptr, 100); arr_ptr += 4;
                    VolB = DS_Functions.ByteArrayToUs32(b_array, arr_ptr, 100); arr_ptr += 4;

                    VolRdc = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 100); arr_ptr += 4;
                    VolYdc = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 100); arr_ptr += 4;
                    VolBdc = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 100); arr_ptr += 4;

                    CurrRSigned = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 1000); arr_ptr += 4;
                    CurrYSigned = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 1000); arr_ptr += 4;
                    CurrBSigned = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 1000); arr_ptr += 4;
                    CurrN = DS_Functions.ByteArrayToUs32(b_array, arr_ptr, 1000); arr_ptr += 4;

                    CurrRdc = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 1000); arr_ptr += 4;
                    CurrYdc = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 1000); arr_ptr += 4;
                    CurrBdc = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 1000); arr_ptr += 4;
                    CurrNdc = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 1000); arr_ptr += 4;

                    PFR = DS_Functions.ByteArrayToS16(b_array, arr_ptr, 1000); arr_ptr += 2;
                    PFY = DS_Functions.ByteArrayToS16(b_array, arr_ptr, 1000); arr_ptr += 2;
                    PFB = DS_Functions.ByteArrayToS16(b_array, arr_ptr, 1000); arr_ptr += 2;
                    PFNet = DS_Functions.ByteArrayToS16(b_array, arr_ptr, 1000); arr_ptr += 2;

                    AnglePFR = DS_Functions.ByteArrayToS16(b_array, arr_ptr, 1000); arr_ptr += 2;
                    AnglePFY = DS_Functions.ByteArrayToS16(b_array, arr_ptr, 1000); arr_ptr += 2;
                    AnglePFB = DS_Functions.ByteArrayToS16(b_array, arr_ptr, 1000); arr_ptr += 2;

                    WattR = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    WattY = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    WattB = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    WattNet = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;

                    WattRFunda = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    WattYFunda = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    WattBFunda = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    WattNetFunda = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;

                    VARR = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    VARY = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    VARB = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    VARNet = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;

                    VAR = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    VAY = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    VAB = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;
                    VANet = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 10); arr_ptr += 4;

                    FreqR = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 1000); arr_ptr += 2;
                    FreqY = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 1000); arr_ptr += 2;
                    FreqB = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 1000); arr_ptr += 2;
                    FreqNet = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 1000); arr_ptr += 2;

                    QuadrantR = b_array[arr_ptr++];
                    QuadrantY = b_array[arr_ptr++];
                    QuadrantB = b_array[arr_ptr++];
                    QuadrantNet = b_array[arr_ptr++];

                    SamplesR = DS_Functions.ByteArrayToUs16(b_array, arr_ptr); arr_ptr += 2;
                    SamplesY = DS_Functions.ByteArrayToUs16(b_array, arr_ptr); arr_ptr += 2;
                    SamplesB = DS_Functions.ByteArrayToUs16(b_array, arr_ptr); arr_ptr += 2;
                    SamplesPerSec = DS_Functions.ByteArrayToUs16(b_array, arr_ptr); arr_ptr += 2;
                    SamplesN = DS_Functions.ByteArrayToUs16(b_array, arr_ptr); arr_ptr += 2;

                    THDVr = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 10); arr_ptr += 2;
                    THDVy = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 10); arr_ptr += 2;
                    THDVb = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 10); arr_ptr += 2;
                    THDIr = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 10); arr_ptr += 2;
                    THDIy = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 10); arr_ptr += 2;
                    THDIb = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 10); arr_ptr += 2;

                    EnergyWhR_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyWhY_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyWhB_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyWhTotal_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyWhR_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyWhY_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyWhB_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyWhTotal_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhR_q1 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhY_q1 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhB_q1 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhTotal_q1 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhR_q2 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhY_q2 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhB_q2 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhTotal_q2 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhR_q3 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhY_q3 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhB_q3 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhTotal_q3 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhR_q4 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhY_q4 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhB_q4 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVARhTotal_q4 = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVAhR_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVAhY_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVAhB_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVAhTotal_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVAhR_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVAhY_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVAhB_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyVAhTotal_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyFWhR_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyFWhY_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyFWhB_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyFWhTotal_imp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyFWhR_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyFWhY_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyFWhB_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    EnergyFWhTotal_exp = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;

                    pulse_EnergyWhR_imp = b_array[arr_ptr++];
                    pulse_EnergyWhY_imp = b_array[arr_ptr++];
                    pulse_EnergyWhB_imp = b_array[arr_ptr++];
                    pulse_EnergyWhTotal_imp = b_array[arr_ptr++];
                    pulse_EnergyWhR_exp = b_array[arr_ptr++];
                    pulse_EnergyWhY_exp = b_array[arr_ptr++];
                    pulse_EnergyWhB_exp = b_array[arr_ptr++];
                    pulse_EnergyWhTotal_exp = b_array[arr_ptr++];
                    pulse_EnergyVARhR_q1 = b_array[arr_ptr++];
                    pulse_EnergyVARhY_q1 = b_array[arr_ptr++];
                    pulse_EnergyVARhB_q1 = b_array[arr_ptr++];
                    pulse_EnergyVARhTotal_q1 = b_array[arr_ptr++];
                    pulse_EnergyVARhR_q2 = b_array[arr_ptr++];
                    pulse_EnergyVARhY_q2 = b_array[arr_ptr++];
                    pulse_EnergyVARhB_q2 = b_array[arr_ptr++];
                    pulse_EnergyVARhTotal_q2 = b_array[arr_ptr++];
                    pulse_EnergyVARhR_q3 = b_array[arr_ptr++];
                    pulse_EnergyVARhY_q3 = b_array[arr_ptr++];
                    pulse_EnergyVARhB_q3 = b_array[arr_ptr++];
                    pulse_EnergyVARhTotal_q3 = b_array[arr_ptr++];
                    pulse_EnergyVARhR_q4 = b_array[arr_ptr++];
                    pulse_EnergyVARhY_q4 = b_array[arr_ptr++];
                    pulse_EnergyVARhB_q4 = b_array[arr_ptr++];
                    pulse_EnergyVARhTotal_q4 = b_array[arr_ptr++];
                    pulse_EnergyVAhR_imp = b_array[arr_ptr++];
                    pulse_EnergyVAhY_imp = b_array[arr_ptr++];
                    pulse_EnergyVAhB_imp = b_array[arr_ptr++];
                    pulse_EnergyVAhTotal_imp = b_array[arr_ptr++];
                    pulse_EnergyVAhR_exp = b_array[arr_ptr++];
                    pulse_EnergyVAhY_exp = b_array[arr_ptr++];
                    pulse_EnergyVAhB_exp = b_array[arr_ptr++];
                    pulse_EnergyVAhTotal_exp = b_array[arr_ptr++];
                    pulse_EnergyFWhR_imp = b_array[arr_ptr++];
                    pulse_EnergyFWhY_imp = b_array[arr_ptr++];
                    pulse_EnergyFWhB_imp = b_array[arr_ptr++];
                    pulse_EnergyFWhTotal_imp = b_array[arr_ptr++];
                    pulse_EnergyFWhR_exp = b_array[arr_ptr++];
                    pulse_EnergyFWhY_exp = b_array[arr_ptr++];
                    pulse_EnergyFWhB_exp = b_array[arr_ptr++];
                    pulse_EnergyFWhTotal_exp = b_array[arr_ptr++];

                    Time = String.Empty;

                    Time += b_array[arr_ptr++].ToString("D2") + ":";  // hh
                    Time += b_array[arr_ptr++].ToString("D2") + ":";  // mm
                    Time += b_array[arr_ptr++].ToString("D2") + " ";  // ss
                    Time += b_array[arr_ptr++].ToString("D2") + "/";  // date
                    Time += b_array[arr_ptr++].ToString("D2") + "/";  // month
                    Time += b_array[arr_ptr++].ToString("D2") + " ";  // year
                    Time += DS_Functions.get_day_of_week[b_array[arr_ptr++]];  // day of week

                    powerUpSec = DS_Functions.ByteArrayToUs16(b_array, arr_ptr); arr_ptr += 2;

                    CurrNVector = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 1000); arr_ptr += 4;
                    AngleNVector = DS_Functions.ByteArrayToS32(b_array, arr_ptr, 100); arr_ptr += 2;


                    temperature_tlv = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 100); arr_ptr += 2;
                    LoopCycles = DS_Functions.ByteArrayToUs32(b_array, arr_ptr); arr_ptr += 4;
                    battery_voltage = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 100); arr_ptr += 2;
                    battery_voltage_rtc = DS_Functions.ByteArrayToUs16(b_array, arr_ptr, 100); arr_ptr += 2;

                    VolRY = DS_Functions.ByteArrayToUs32(b_array, arr_ptr, 100); arr_ptr += 4;
                    VolYB = DS_Functions.ByteArrayToUs32(b_array, arr_ptr, 100); arr_ptr += 4;
                    VolBR = DS_Functions.ByteArrayToUs32(b_array, arr_ptr, 100); arr_ptr += 4;

                    AngleRY = DS_Functions.ByteArrayToS16(b_array, arr_ptr, 100); arr_ptr += 2;
                    AngleYB = DS_Functions.ByteArrayToS16(b_array, arr_ptr, 100); arr_ptr += 2;
                    AngleBR = DS_Functions.ByteArrayToS16(b_array, arr_ptr, 100); arr_ptr += 2;

                    reactiveSamples = b_array[arr_ptr++];
                    reactiveTimer = DS_Functions.ByteArrayToS16(b_array, arr_ptr); arr_ptr += 2;
                    reactiveTimeDelay = DS_Functions.ByteArrayToS16(b_array, arr_ptr); arr_ptr += 2;
                    reactiveTimeDeviation = DS_Functions.ByteArrayToS16(b_array, arr_ptr); arr_ptr += 2;

                    tamper_status[7] = b_array[arr_ptr++];
                    tamper_status[6] = b_array[arr_ptr++];
                    tamper_status[5] = b_array[arr_ptr++];
                    tamper_status[4] = b_array[arr_ptr++];
                    tamper_status[3] = b_array[arr_ptr++];
                    tamper_status[2] = b_array[arr_ptr++];
                    tamper_status[1] = b_array[arr_ptr++];
                    tamper_status[0] = b_array[arr_ptr++];

                    /* Reserved diag string of 8 bytes */
                    /* byte 0 - b7 b6 b5 b4 b3 b2 b1_FG_Flag b0_MeteringMode
                     * byte 1 - b7 b6 b5 b4 b3 b2 b1 b0
                     * byte 2 - b7 b6 b5 b4 b3 b2 b1 b0
                     * byte 3 - b7 b6 b5 b4 b3 b2 b1 b0
                     * byte 4 - b7 b6 b5 b4 b3 b2 b1 b0
                     * byte 5 - b7 b6 b5 b4 b3 b2 b1 b0
                     * byte 6 - b7 b6 b5 b4 b3 b2 b1 b0
                     * byte 7 - b7 b6 b5 b4 b3 b2 b1 b0
                     */
                    /* byte 0 */
                    MeteringMode = (byte)(b_array[arr_ptr] & 0x01);
                    fg_flag = (byte)((b_array[arr_ptr] >> 1) & 0x01);   

                    arr_ptr += 8;
                    // Reserved byte array of 8 bytes
                    arr_ptr += 8;

                    /* Handling Misc data */
                    MISCData = DS_Functions.byte_array_to_ascii_string(b_array, b_array_len - 3, arr_ptr);

                    ushort QUANTA,PULSE;
                    double[] PulseWeight = new double[7];
                    /* Calculating Energies */
                    if (Meter_Const == 1200)
                    {
                        QUANTA = 5;
                        PULSE = 6;
                        PulseWeight[0] = 0;
                        PulseWeight[1] = 0.833;
                        PulseWeight[2] = 1.666;
                        PulseWeight[3] = 2.500;
                        PulseWeight[4] = 3.333;
                        PulseWeight[5] = 4.166;
                        PulseWeight[6] = 5.000;
                    }
                    else if (Meter_Const == 1000)
                    {
                        QUANTA = 1;
                        PULSE = 1;
                        PulseWeight[0] = 0;
                        PulseWeight[1] = 1;
                        PulseWeight[2] = 2;
                        PulseWeight[3] = 3;
                        PulseWeight[4] = 4;
                        PulseWeight[5] = 5;
                        PulseWeight[6] = 6;
                    }
                    else if (Meter_Const == 600)
                    {
                        QUANTA = 5;
                        PULSE = 3;
                        PulseWeight[0] = 0;
                        PulseWeight[1] = 1.666;
                        PulseWeight[2] = 3.333;
                        PulseWeight[3] = 5.000;
                        PulseWeight[4] = 6.666;
                        PulseWeight[5] = 8.333;
                        PulseWeight[6] = 10;
                    }
                    else
                    {
                        QUANTA = 0;
                        PULSE = 0;
                    }
                    //QUANTA * (pulseEnergyWhR / PULSE)
                    EnergyWhR_imp += QUANTA *(pulse_EnergyWhR_imp / PULSE);
                    EnergyWhY_imp += QUANTA *(pulse_EnergyWhY_imp / PULSE);
                    EnergyWhB_imp += QUANTA *(pulse_EnergyWhB_imp / PULSE);
                    EnergyWhTotal_imp += QUANTA *(pulse_EnergyWhTotal_imp / PULSE);
                    EnergyWhR_exp += QUANTA *(pulse_EnergyWhR_exp / PULSE);
                    EnergyWhY_exp += QUANTA *(pulse_EnergyWhY_exp / PULSE);
                    EnergyWhB_exp += QUANTA *(pulse_EnergyWhB_exp / PULSE);
                    EnergyWhTotal_exp += QUANTA *(pulse_EnergyWhTotal_exp / PULSE);
                    EnergyVARhR_q1 += QUANTA *(pulse_EnergyVARhR_q1 / PULSE);
                    EnergyVARhY_q1 += QUANTA *(pulse_EnergyVARhY_q1 / PULSE);
                    EnergyVARhB_q1 += QUANTA *(pulse_EnergyVARhB_q1 / PULSE);
                    EnergyVARhTotal_q1 += QUANTA *(pulse_EnergyVARhTotal_q1 / PULSE);
                    EnergyVARhR_q2 += QUANTA *(pulse_EnergyVARhR_q2 / PULSE);
                    EnergyVARhY_q2 += QUANTA *(pulse_EnergyVARhY_q2 / PULSE);
                    EnergyVARhB_q2 += QUANTA *(pulse_EnergyVARhB_q2 / PULSE);
                    EnergyVARhTotal_q2 += QUANTA *(pulse_EnergyVARhTotal_q2 / PULSE);
                    EnergyVARhR_q3 += QUANTA *(pulse_EnergyVARhR_q3 / PULSE);
                    EnergyVARhY_q3 += QUANTA *(pulse_EnergyVARhY_q3 / PULSE);
                    EnergyVARhB_q3 += QUANTA *(pulse_EnergyVARhB_q3 / PULSE);
                    EnergyVARhTotal_q3 += QUANTA *(pulse_EnergyVARhTotal_q3 / PULSE);
                    EnergyVARhR_q4 += QUANTA *(pulse_EnergyVARhR_q4 / PULSE);
                    EnergyVARhY_q4 += QUANTA *(pulse_EnergyVARhY_q4 / PULSE);
                    EnergyVARhB_q4 += QUANTA *(pulse_EnergyVARhB_q4 / PULSE);
                    EnergyVARhTotal_q4 += QUANTA *(pulse_EnergyVARhTotal_q4 / PULSE);
                    EnergyVAhR_imp += QUANTA *(pulse_EnergyVAhR_imp / PULSE);
                    EnergyVAhY_imp += QUANTA *(pulse_EnergyVAhY_imp / PULSE);
                    EnergyVAhB_imp += QUANTA *(pulse_EnergyVAhB_imp / PULSE);
                    EnergyVAhTotal_imp += QUANTA *(pulse_EnergyVAhTotal_imp / PULSE);
                    EnergyVAhR_exp += QUANTA *(pulse_EnergyVAhR_exp / PULSE);
                    EnergyVAhY_exp += QUANTA *(pulse_EnergyVAhY_exp / PULSE);
                    EnergyVAhB_exp += QUANTA *(pulse_EnergyVAhB_exp / PULSE);
                    EnergyVAhTotal_exp += QUANTA *(pulse_EnergyVAhTotal_exp / PULSE);
                    EnergyFWhR_imp += QUANTA *(pulse_EnergyFWhR_imp / PULSE);
                    EnergyFWhY_imp += QUANTA *(pulse_EnergyFWhY_imp / PULSE);
                    EnergyFWhB_imp += QUANTA *(pulse_EnergyFWhB_imp / PULSE);
                    EnergyFWhTotal_imp += QUANTA *(pulse_EnergyFWhTotal_imp / PULSE);
                    EnergyFWhR_exp += QUANTA *(pulse_EnergyFWhR_exp / PULSE);
                    EnergyFWhY_exp += QUANTA *(pulse_EnergyFWhY_exp / PULSE);
                    EnergyFWhB_exp += QUANTA *(pulse_EnergyFWhB_exp / PULSE);
                    EnergyFWhTotal_exp += QUANTA *(pulse_EnergyFWhTotal_exp / PULSE);

                    EnergyWhR_imp += PulseWeight[pulse_EnergyWhR_imp % PULSE];
                    EnergyWhY_imp += PulseWeight[pulse_EnergyWhY_imp % PULSE];
                    EnergyWhB_imp += PulseWeight[pulse_EnergyWhB_imp % PULSE];
                    EnergyWhTotal_imp += PulseWeight[pulse_EnergyWhTotal_imp % PULSE];
                    EnergyWhR_exp += PulseWeight[pulse_EnergyWhR_exp % PULSE];
                    EnergyWhY_exp += PulseWeight[pulse_EnergyWhY_exp % PULSE];
                    EnergyWhB_exp += PulseWeight[pulse_EnergyWhB_exp % PULSE];
                    EnergyWhTotal_exp += PulseWeight[pulse_EnergyWhTotal_exp % PULSE];
                    EnergyVARhR_q1 += PulseWeight[pulse_EnergyVARhR_q1 % PULSE];
                    EnergyVARhY_q1 += PulseWeight[pulse_EnergyVARhY_q1 % PULSE];
                    EnergyVARhB_q1 += PulseWeight[pulse_EnergyVARhB_q1 % PULSE];
                    EnergyVARhTotal_q1 += PulseWeight[pulse_EnergyVARhTotal_q1 % PULSE];
                    EnergyVARhR_q2 += PulseWeight[pulse_EnergyVARhR_q2 % PULSE];
                    EnergyVARhY_q2 += PulseWeight[pulse_EnergyVARhY_q2 % PULSE];
                    EnergyVARhB_q2 += PulseWeight[pulse_EnergyVARhB_q2 % PULSE];
                    EnergyVARhTotal_q2 += PulseWeight[pulse_EnergyVARhTotal_q2 % PULSE];
                    EnergyVARhR_q3 += PulseWeight[pulse_EnergyVARhR_q3 % PULSE];
                    EnergyVARhY_q3 += PulseWeight[pulse_EnergyVARhY_q3 % PULSE];
                    EnergyVARhB_q3 += PulseWeight[pulse_EnergyVARhB_q3 % PULSE];
                    EnergyVARhTotal_q3 += PulseWeight[pulse_EnergyVARhTotal_q3 % PULSE];
                    EnergyVARhR_q4 += PulseWeight[pulse_EnergyVARhR_q4 % PULSE];
                    EnergyVARhY_q4 += PulseWeight[pulse_EnergyVARhY_q4 % PULSE];
                    EnergyVARhB_q4 += PulseWeight[pulse_EnergyVARhB_q4 % PULSE];
                    EnergyVARhTotal_q4 += PulseWeight[pulse_EnergyVARhTotal_q4 % PULSE];
                    EnergyVAhR_imp += PulseWeight[pulse_EnergyVAhR_imp % PULSE];
                    EnergyVAhY_imp += PulseWeight[pulse_EnergyVAhY_imp % PULSE];
                    EnergyVAhB_imp += PulseWeight[pulse_EnergyVAhB_imp % PULSE];
                    EnergyVAhTotal_imp += PulseWeight[pulse_EnergyVAhTotal_imp % PULSE];
                    EnergyVAhR_exp += PulseWeight[pulse_EnergyVAhR_exp % PULSE];
                    EnergyVAhY_exp += PulseWeight[pulse_EnergyVAhY_exp % PULSE];
                    EnergyVAhB_exp += PulseWeight[pulse_EnergyVAhB_exp % PULSE];
                    EnergyVAhTotal_exp += PulseWeight[pulse_EnergyVAhTotal_exp % PULSE];
                    EnergyFWhR_imp += PulseWeight[pulse_EnergyFWhR_imp % PULSE];
                    EnergyFWhY_imp += PulseWeight[pulse_EnergyFWhY_imp % PULSE];
                    EnergyFWhB_imp += PulseWeight[pulse_EnergyFWhB_imp % PULSE];
                    EnergyFWhTotal_imp += PulseWeight[pulse_EnergyFWhTotal_imp % PULSE];
                    EnergyFWhR_exp += PulseWeight[pulse_EnergyFWhR_exp % PULSE];
                    EnergyFWhY_exp += PulseWeight[pulse_EnergyFWhY_exp % PULSE];
                    EnergyFWhB_exp += PulseWeight[pulse_EnergyFWhB_exp % PULSE];
                    EnergyFWhTotal_exp += PulseWeight[pulse_EnergyFWhTotal_exp % PULSE];
                    

                    /* Calculating Error */
                    if (cal_accuracy == true)
                    {
                        if (ip_watt_r != 0)
                        {
                            error_act_r = (ip_watt_r - WattR) * 100 / ip_watt_r;
                        }
                        if (ip_watt_y != 0)
                        {
                            error_act_y = (ip_watt_y - WattY) * 100 / ip_watt_y;
                        }
                        if (ip_watt_b != 0)
                        {
                            error_act_b = (ip_watt_b - WattB) * 100 / ip_watt_b;
                        }
                        if (ip_var_r != 0)
                        {
                            error_react_r = (ip_var_r - VARR) * 100 / ip_var_r;
                        }
                        if (ip_var_y != 0)
                        {
                            error_react_y = (ip_var_y - VARY) * 100 / ip_var_y;
                        }
                        if (ip_var_b != 0)
                        {
                            error_react_b = (ip_var_b - VARB) * 100 / ip_var_b;
                        }
                        if (ip_va_r != 0)
                        {
                            error_app_r = (ip_va_r - VAR) * 100 / ip_va_r;
                        }
                        if (ip_va_y != 0)
                        {
                            error_app_y = (ip_va_y - VAY) * 100 / ip_va_y;
                        }
                        if (ip_va_b != 0)
                        {
                            error_app_b = (ip_va_b - VAB) * 100 / ip_va_b;
                        }
                        if (ip_metering_mode == 1)  /* Forwarded */
                        {
                            if (ip_watt_total_fwd != 0)
                            {
                                error_act_total = (ip_watt_total_fwd - WattNet) * 100 / ip_watt_total_fwd;
                            }
                            if (ip_var_total_fwd != 0)
                            {
                                error_react_total = (ip_var_total_fwd - VARNet) * 100 / ip_var_total_fwd;
                            }
                            if (ip_va_total_fwd != 0)
                            {
                                error_app_total = (ip_va_total_fwd - VANet) * 100 / ip_va_total_fwd;
                            }
                        }
                        else if (ip_metering_mode == 2) /* Net */
                        {
                            if (ip_watt_total_net != 0)
                            {
                                error_act_total = (ip_watt_total_fwd - WattNet) * 100 / ip_watt_total_net;
                            }
                            if (ip_var_total_net != 0)
                            {
                                error_react_total = (ip_var_total_fwd - VARNet) * 100 / ip_var_total_net;
                            }
                            if (ip_va_total_net != 0)
                            {
                                error_app_total = (ip_va_total_net - VANet) * 100 / ip_va_total_net;
                            }
                        }
                    }
            
                    ///* Data logging */
                    //if (logData_f == true)
                    //{
                    //    string pathName;
                    //    if (log_to_newfile_f == true)
                    //    {
                    //        pathName = "D:\\SerialTools\\" + newlogfileName + ".txt";
                    //    }
                    //    else
                    //    {
                    //        pathName = "D:\\SerialTools\\" + "SerialToolsLogFile" + ".txt";
                    //    }
                    //    string dir = @"D:\SerialTools";
                    //    if (!Directory.Exists(dir))
                    //    {
                    //        Directory.CreateDirectory(dir);
                    //    }
                    //    using (StreamWriter sw = File.AppendText(pathName))
                    //    {
                    //        sw.Write(metrology_timer.ToString()); sw.Write(tab);
                    //        sw.Write(Time); sw.Write(tab);
                    //        sw.Write(VolR.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(VolY.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(VolB.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(VolRdc.ToString()); sw.Write(tab);
                    //        sw.Write(VolYdc.ToString()); sw.Write(tab);
                    //        sw.Write(VolBdc.ToString()); sw.Write(tab);
                    //        sw.Write(CurrR.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(CurrY.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(CurrB.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(CurrN.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(CurrRdc.ToString()); sw.Write(tab);
                    //        sw.Write(CurrYdc.ToString()); sw.Write(tab);
                    //        sw.Write(CurrBdc.ToString()); sw.Write(tab);
                    //        sw.Write(CurrNdc.ToString()); sw.Write(tab);
                    //        sw.Write(PFR.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(PFY.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(PFB.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(PFNet.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(AnglePFR.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(AnglePFY.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(AnglePFB.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(WattR.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(WattY.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(WattB.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(WattNet.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(VARR.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(VARY.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(VARB.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(VARNet.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(VAR.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(VAY.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(VAB.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(VANet.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(FreqR.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(FreqY.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(FreqB.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(FreqNet.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(QuadrantR.ToString()); sw.Write(tab);
                    //        sw.Write(QuadrantY.ToString()); sw.Write(tab);
                    //        sw.Write(QuadrantB.ToString()); sw.Write(tab);
                    //        sw.Write(QuadrantNet.ToString()); sw.Write(tab);
                    //        sw.Write(CalAngleActR.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(CalAngleActY.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(CalAngleActB.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(CalAngleReactR.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(CalAngleReactY.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(CalAngleReactB.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(SamplesR.ToString()); sw.Write(tab);
                    //        sw.Write(SamplesY.ToString()); sw.Write(tab);
                    //        sw.Write(SamplesB.ToString()); sw.Write(tab);
                    //        sw.Write(SamplesPerSec.ToString()); sw.Write(tab);
                    //        sw.Write(SamplesN.ToString()); sw.Write(tab);
                    //        sw.Write(CurrNVector.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(AngleNVector.ToString("0.000")); sw.Write(tab);
                    //        sw.Write(VolRY.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(VolYB.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(VolBR.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(AngleRY.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(AngleYB.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(AngleBR.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(EnergyWhR.ToString("0.0000")); sw.Write(tab);
                    //        sw.Write(EnergyWhY.ToString("0.0000")); sw.Write(tab);
                    //        sw.Write(EnergyWhB.ToString("0.0000")); sw.Write(tab);
                    //        sw.Write(EnergyWhTotal.ToString("0.0000")); sw.Write(tab);
                    //        sw.Write(EnergyVARhLagTotal.ToString("0.0000")); sw.Write(tab);
                    //        sw.Write(EnergyVARhLeadTotal.ToString("0.0000")); sw.Write(tab);
                    //        sw.Write(EnergyVAhTotal.ToString("0.0000")); sw.Write(tab);
                    //        sw.Write(error_act_r.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_act_y.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_act_b.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_act_total.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_react_r.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_react_y.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_react_b.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_react_total.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_app_r.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_app_y.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_app_b.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(error_app_total.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(temperature_tlv.ToString()); sw.Write(tab);
                    //        sw.Write(battery_voltage.ToString("0.00")); sw.Write(tab);
                    //        sw.Write(reactiveSamples.ToString()); sw.Write(tab);
                    //        sw.Write(reactiveTimer.ToString()); sw.Write(tab);
                    //        sw.Write(reactiveTimeDelay.ToString()); sw.Write(tab);
                    //        sw.Write(reactiveTimeDeviation.ToString()); sw.Write(tab);
                    //        sw.Write(THDVr.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(THDVy.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(THDVb.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(THDIr.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(THDIy.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(THDIb.ToString("0.0")); sw.Write(tab);
                    //        sw.Write(EnergyWhTotalFunda.ToString("0.0000")); sw.Write(tab);
                    //        sw.Write(LoopCycles.ToString()); sw.Write(tab);
                    //        sw.Write(DS_Functions.Byte_Array_To_HEX_String(tamper_status)); sw.Write(tab);
                    //        sw.Write(MISCData); sw.Write(tab);
                    //        sw.Write(newline);
                    //        sw.Close();
                    //        sw.Dispose();
                    //    }
                    //}
                }
            }
        }
    }
}


