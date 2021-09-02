using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Developer_Tools
{
    public partial class Form1 : Form
    {
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
            MessageBox.Show("An ultimate tool to do the job easily. write us your feedback/suggestions/new feature on dheeraj.singhal@genus.in");
        }

        private void buttonToolsInputTextBoxPaste_Click(object sender, EventArgs e)
        {
            textBoxToolsInputString.Text = Clipboard.GetText();
        }

        private void buttonToolsInputTextBoxClear_Click(object sender, EventArgs e)
        {
            textBoxToolsInputString.Text = String.Empty;
        }

        private void buttonToolsOutputTextBoxCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxToolsOutputString.Text);
        }

        private void buttonToolsOutputTextBoxClear_Click(object sender, EventArgs e)
        {
            textBoxToolsOutputString.Text = String.Empty;
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
                if(DS_Functions.CheckValidHexString(textBoxToolsInputString.Text) == true)
                {
                    input_string = textBoxToolsInputString.Text;
                    input_format = "HEX";
                }
            }
            else if(radioButtonToolsInputTextBoxHEXSpaced.Checked == true)
            {
                if (DS_Functions.CheckValidHexString(DS_Functions.string_subtract(textBoxToolsInputString.Text," ","")) == true)
                {
                    input_string = DS_Functions.string_subtract(textBoxToolsInputString.Text, " ", "");
                    input_format = "HEXSpaced";
                }
            }
            else if (radioButtonToolsInputTextBoxASCII.Checked == true)
            {
                input_format = "ASCII";
                input_string = textBoxToolsInputString.Text;
            }


            if (string.IsNullOrEmpty(input_string) == false)
            {
                /* calculating length of byte array */
                int b_array_len = 0;
                if (string.Equals(input_format, "ASCII") == true)
                {
                    b_array_len = input_string.Length;
                }
                else if (string.Equals(input_format, "HEX") == true || string.Equals(input_format, "HEXSpaced") == true)
                {
                    b_array_len = input_string.Length/2;
                }
                byte[] b_array = new byte[b_array_len];

                /* converting into byte array */
                if (string.Equals(input_format, "ASCII") == true)
                {
                    b_array = DS_Functions.ascii_string_to_byte_array(input_string);
                }
                else if (string.Equals(input_format, "HEX") == true || string.Equals(input_format, "HEXSpaced") == true)
                {
                    b_array = DS_Functions.hex_string_to_byte_array(input_string);
                }

                /* getting output formatter */
                if (radiobuttonToolsOutputTextBoxHEX.Checked == true)
                {
                    input_format = "HEX";
                    output_string = DS_Functions.byte_array_to_hex_string(b_array, b_array_len);
                }
                else if (radiobuttonToolsOutputTextBoxHEXSpaced.Checked == true)
                {
                    output_format = "HEXSpaced";
                    output_string = DS_Functions.byte_array_to_hex_string(b_array, b_array_len);
                    output_string = DS_Functions.string_insertor(output_string, " ", 2);
                }
                else if (radiobuttonToolsOutputTextBoxASCII.Checked == true)
                {
                    output_format = "ASCII";
                    output_string = DS_Functions.byte_array_to_ascii_string(b_array, b_array_len);
                }

                textBoxToolsOutputString.Text = output_string;
            }
            else
            {
                MessageBox.Show("Invalid input String","Error");
            }
        }
    }
}
