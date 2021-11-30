using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

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
        public static int total_sent_bytes, total_received_bytes;

        /* Serial Port */
        DS_Serial serial_port = new DS_Serial();

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

            timer1sec.Enabled = true;
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
            if(fileName.Length != 0)
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
            if(config_file_name == null)
            {
                MessageBox.Show("Configuration file not loaded");
            }
            else
            {
                /* save all the date into JSON file here */



                /* updating the text back to normal */
                if(saveToolStripMenuItem.Text == "Save'")
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

        private void checkBoxStringFilterRemoveHEX_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxStringFilterRemoveHEX.Checked == true)
            {
                textBoxStringFilterRemoveHEX.Enabled = true;
            }
            else
            {
                textBoxStringFilterRemoveHEX.Enabled = false;
            }
        }

        private void buttonStringFilterConvert_Click(object sender, EventArgs e)
        {
            string input_string = String.Empty;
            string input_format = String.Empty;
            string output_string = String.Empty;
            string output_format = String.Empty;

            /* Verify valid input data */
            if (radioButtonToolsInputTextBoxHEX.Checked == true)
            {
                if(DS_Functions.CheckValidHexString(textBox_ToolsInputString.Text) == true)
                {
                    input_string = textBox_ToolsInputString.Text;
                    input_format = "HEX";
                }
            }
            else if(radioButtonToolsInputTextBoxHEXSpaced.Checked == true)
            {
                if (DS_Functions.CheckValidHexString(DS_Functions.string_subtract(textBox_ToolsInputString.Text," ","")) == true)
                {
                    input_string = DS_Functions.string_subtract(textBox_ToolsInputString.Text, " ", "");
                    input_format = "HEXSpaced";
                }
            }
            else if (radioButtonToolsInputTextBoxASCII.Checked == true)
            {
                input_format = "ASCII";
                input_string = textBox_ToolsInputString.Text;
            }


            if (string.IsNullOrEmpty(input_string) == false)
            {
                string ascii_str = string.Empty;

                /* converting into byte array */
                if (string.Equals(input_format, "ASCII") == true)
                {
                    ascii_str = input_string;
                }
                else if (string.Equals(input_format, "HEX") == true || string.Equals(input_format, "HEXSpaced") == true)
                {
                    ascii_str = DS_Functions.hex_string_to_ascii_string(input_string);
                }
                /* removing the desired characters */
                if (checkBoxStringFilterRemoveSpace.Checked == true)
                {
                    ascii_str = DS_Functions.string_subtract(input_string, " ", "");
                }
                if (checkBoxStringFilterRemoveCR.Checked == true)
                {
                    ascii_str = DS_Functions.string_subtract(input_string,"\r","");
                }
                if (checkBoxStringFilterRemoveLF.Checked == true)
                {
                    ascii_str = DS_Functions.string_subtract(input_string, "\n", "");
                }
                if (checkBoxStringFilterRemoveTab.Checked == true)
                {
                    ascii_str = DS_Functions.string_subtract(input_string, "\t", "");
                }
                if (checkBoxStringFilterRemoveHEX.Checked == true)
                {
                    ascii_str = DS_Functions.string_subtract(input_string, DS_Functions.byte_to_ascii_char(13), DS_Functions.byte_to_ascii_char(32));
                    string temp = textBoxStringFilterRemoveHEX.Text;
                    temp = DS_Functions.string_subtract(temp, " ", "");
                    if (DS_Functions.CheckValidHexString(temp) == true)
                    {
                        ascii_str = DS_Functions.string_subtract(input_string, temp, "");
                    }
                    else
                    {
                        MessageBox.Show("invalid HEX string");
                    }
                }


                /* getting output formatter */
                if (radiobuttonToolsOutputTextBoxHEX.Checked == true)
                {
                    input_format = "HEX";
                    output_string = DS_Functions.ascii_string_to_hex_string(ascii_str);
                }
                else if (radiobuttonToolsOutputTextBoxHEXSpaced.Checked == true)
                {
                    output_format = "HEXSpaced";
                    output_string = DS_Functions.ascii_string_to_hex_string(ascii_str);
                    output_string = DS_Functions.string_insertor(output_string, " ", 2);
                }
                else if (radiobuttonToolsOutputTextBoxASCII.Checked == true)
                {
                    output_format = "ASCII";
                    output_string = ascii_str;
                }

                textBox_ToolsOutputString.Text = output_string;
            }
            else
            {
                MessageBox.Show("Invalid input String","Error");
            }
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
                    if(DS_Functions.CheckValidHexSpacedString(textBox_ToolsInputString.Text) == true)
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
            total_received_bytes = 0;
            total_sent_bytes = 0;
            textBox_DataTrafficTxBytesTotal.Text = "0";
            textBox_DataTrafficRxBytesTotal.Text = "0";
        }

        private void ToolStripMenuItem_Connect_Click(object sender, EventArgs e)
        {
            if (radioButton_CommunicationSerial.Checked == true)
            {
                if(serial_port.Connect(comboBox_SerialSingleCOMPORT.Text, Convert.ToInt32(comboBox_SerialSingleBaudRate.Text)) == true)
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
        private void timer1sec_Tick(object sender, EventArgs e)
        {

        }

        private void timerText500ms_Tick(object sender, EventArgs e)
        {
            bool connection_status;
            
            /* enable/disable functionlity as per flags */
            if(checkBox_SendRepeat.Checked == true)
            {
                textBox_SendRepeatTime.Enabled = true;
                textBox_SendRepeatNoOfTimes.Enabled = true;
            }
            else
            {
                textBox_SendRepeatTime.Enabled = false;
                textBox_SendRepeatTime.Text = "1000";
                textBox_SendRepeatNoOfTimes.Enabled = false;
                textBox_SendRepeatNoOfTimes.Text = "100";
            }
            
            /* pop up notification when a port is connected or disconnected */
            DS_Serial.update_port_list();


            /* fill up information periodically */
            if(radioButton_CommunicationSerial.Checked == true && serial_port.IsOpen == true)
            {
                connection_status = true;
            }
            else
            {
                connection_status = false;
            }
            textBox_DataTrafficTxBytesTotal.Text = total_sent_bytes.ToString();
            textBox_DataTrafficRxBytesTotal.Text = total_received_bytes.ToString();

            if (connection_status == true)                  /* Connected */
            {
                progressBar_connectionStatus.Value = 100;
                button_Send.Enabled = true;
                ToolStripMenuItem_Connect.Enabled = false;
                ToolStripMenuItem_Disconnect.Enabled = true;
            }
            else                                            /* Disconnected */
            {
                progressBar_connectionStatus.Value = 0;
                button_Send.Enabled = false;
                ToolStripMenuItem_Connect.Enabled = true;
                ToolStripMenuItem_Disconnect.Enabled = false;
            }
            try
            {
                textBox_SendRepeatSentCounter.Text = serial_port.SendRepeaSentCounter.ToString();
            }
            catch(Exception ex)
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
            else if(radioButton_DataTrafficFormatHEXSpaced.Checked == true)  /* HEX Spaced */
            {
                traffic_mode = 3;
            }

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
                if(DS_Functions.CheckValidHexSpacedString(textBox_SendFrame.Text) == false)
                {
                    MessageBox.Show("Invalid Input Data..!!");
                    return;
                }
            }

            /* calculating the length */
            send_frame_length = textBox_SendFrame.Text.Replace(" ","").Length;

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
                serial_port.write(temp_b_array, 0, temp_b_array_length, checkBox_SendFrameHDLC.Checked,true,Convert.ToInt32(textBox_SendRepeatTime.Text), Convert.ToInt32(textBox_SendRepeatNoOfTimes.Text));
            }
            else
            {
                serial_port.write(temp_b_array, 0, temp_b_array_length, checkBox_SendFrameHDLC.Checked);
            }
        }

        private void timer100ms_Tick(object sender, EventArgs e)
        {
            string s = String.Empty;// traffic_string;
            if(traffic_string.Length != 0)
            {
                s = traffic_string;
                traffic_string = String.Empty;
            }
            textBox_DataTraffic.AppendText(s);
            traffic_string = String.Empty;
        }

        public static void fillTrafficString(string header, byte[] data, int length)
        {
            traffic_string += Environment.NewLine;
            traffic_string += header;
            if (traffic_mode == 1)       /* ASCII */
            {
                traffic_string += DS_Functions.byte_array_to_ascii_string(data, length);

            }
            else if(traffic_mode == 2)  /* HEX */
            {
                traffic_string += DS_Functions.byte_array_to_hex_string(data, length);
            }
            else if(traffic_mode == 3)  /* HEX Spaced */
            {
                traffic_string += DS_Functions.byte_array_to_hex_string_spaced(data, length);
            }
        }
    }
}
