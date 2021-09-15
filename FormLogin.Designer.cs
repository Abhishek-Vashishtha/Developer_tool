
namespace Developer_Tools
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label99 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_LoginUserName = new System.Windows.Forms.TextBox();
            this.textBox_LoginPassword = new System.Windows.Forms.TextBox();
            this.button_LoginNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.Color.Transparent;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.Color.Red;
            this.label99.Location = new System.Drawing.Point(-2, 15);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(164, 31);
            this.label99.TabIndex = 503;
            this.label99.Text = "User name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 505;
            this.label1.Text = "Password:";
            // 
            // textBox_LoginUserName
            // 
            this.textBox_LoginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LoginUserName.Location = new System.Drawing.Point(157, 15);
            this.textBox_LoginUserName.Name = "textBox_LoginUserName";
            this.textBox_LoginUserName.PasswordChar = '#';
            this.textBox_LoginUserName.Size = new System.Drawing.Size(289, 38);
            this.textBox_LoginUserName.TabIndex = 508;
            // 
            // textBox_LoginPassword
            // 
            this.textBox_LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LoginPassword.Location = new System.Drawing.Point(157, 59);
            this.textBox_LoginPassword.Name = "textBox_LoginPassword";
            this.textBox_LoginPassword.PasswordChar = '#';
            this.textBox_LoginPassword.Size = new System.Drawing.Size(289, 38);
            this.textBox_LoginPassword.TabIndex = 509;
            // 
            // button_LoginNow
            // 
            this.button_LoginNow.BackColor = System.Drawing.Color.ForestGreen;
            this.button_LoginNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LoginNow.ForeColor = System.Drawing.Color.Red;
            this.button_LoginNow.Location = new System.Drawing.Point(13, 103);
            this.button_LoginNow.Name = "button_LoginNow";
            this.button_LoginNow.Size = new System.Drawing.Size(434, 61);
            this.button_LoginNow.TabIndex = 510;
            this.button_LoginNow.Text = "Login Now";
            this.button_LoginNow.UseVisualStyleBackColor = false;
            this.button_LoginNow.Click += new System.EventHandler(this.button_LoginNow_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Developer_Tools.Properties.Resources.background_digital_matrix_neon_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(458, 170);
            this.Controls.Add(this.button_LoginNow);
            this.Controls.Add(this.textBox_LoginPassword);
            this.Controls.Add(this.textBox_LoginUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label99);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_LoginUserName;
        private System.Windows.Forms.TextBox textBox_LoginPassword;
        private System.Windows.Forms.Button button_LoginNow;
    }
}