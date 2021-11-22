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

        /* configuration file */
        string config_file_name;
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
        }

        private void ToolStripMenuItem_Connect_Click(object sender, EventArgs e)
        {
           

        }

        private void ToolStripMenuItem_Disconnect_Click(object sender, EventArgs e)
        {

        }

        private void timer1sec_Tick(object sender, EventArgs e)
        {
            /* enable/disable functionlity as per flags */


            /* fill up information periodically */


            /* update availble serial ports every second */


            /* pop up notification when a port is connected or disconnected */
            DS_Serial.update_port_list();
        }
    }
}
