using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Developer_Tools
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_LoginNow_Click(object sender, EventArgs e)
        {
            if(textBox_LoginUserName.Text == "`" && textBox_LoginPassword.Text == "`")
            {
                Form1.login_success = true;
            }
            else
            {
                MessageBox.Show("Invalid credentials");
                textBox_LoginUserName.Text = "";
                textBox_LoginPassword.Text = "";
                Form1.login_success = false;
            }
            if(Form1.login_success == true)
            {
                this.Close();
            }
        }
    }
}
