using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Developer_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* changing colors of fonts */
            menuStripMain.ForeColor = Color.Blue;
           
            /* creating files at startup */
            DS_Functions.startUpFilesChecking();

            /* Loading data from JSON */
            DS_Functions.loadParametersFromJson();
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
            try
            {
                DS_JSON.createNewFile(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            System.Diagnostics.Process.Start(@fileName);
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
            string data = DS_JSON.readFile(fileName);

            /* parsing JSON data from string */
            var jsonData = JObject.Parse(data);

            if(jsonData.HasValues == false)
            {
                MessageBox.Show("Empty JSON file");
            }
            else
            {
                
            }
        }
    }
}
