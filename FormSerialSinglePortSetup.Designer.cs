
namespace Developer_Tools
{
    partial class FormSerialSinglePortSetup
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
            this.comboBoxSerialSingleBaudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSerialSingleDatabits = new System.Windows.Forms.ComboBox();
            this.comboBoxSerialSingleParity = new System.Windows.Forms.ComboBox();
            this.comboBoxSerialSingleStopbits = new System.Windows.Forms.ComboBox();
            this.comboBoxSerialSingleParityErrorCharacter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSerialSingleCOMPORT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSerialSingleBaudrate
            // 
            this.comboBoxSerialSingleBaudrate.FormattingEnabled = true;
            this.comboBoxSerialSingleBaudrate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.comboBoxSerialSingleBaudrate.Location = new System.Drawing.Point(84, 45);
            this.comboBoxSerialSingleBaudrate.Name = "comboBoxSerialSingleBaudrate";
            this.comboBoxSerialSingleBaudrate.Size = new System.Drawing.Size(54, 21);
            this.comboBoxSerialSingleBaudrate.TabIndex = 0;
            this.comboBoxSerialSingleBaudrate.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baud rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stop Bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parity Error Charactor";
            // 
            // comboBoxSerialSingleDatabits
            // 
            this.comboBoxSerialSingleDatabits.FormattingEnabled = true;
            this.comboBoxSerialSingleDatabits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxSerialSingleDatabits.Location = new System.Drawing.Point(153, 45);
            this.comboBoxSerialSingleDatabits.Name = "comboBoxSerialSingleDatabits";
            this.comboBoxSerialSingleDatabits.Size = new System.Drawing.Size(31, 21);
            this.comboBoxSerialSingleDatabits.TabIndex = 6;
            this.comboBoxSerialSingleDatabits.Text = "8";
            // 
            // comboBoxSerialSingleParity
            // 
            this.comboBoxSerialSingleParity.FormattingEnabled = true;
            this.comboBoxSerialSingleParity.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.comboBoxSerialSingleParity.Location = new System.Drawing.Point(215, 45);
            this.comboBoxSerialSingleParity.Name = "comboBoxSerialSingleParity";
            this.comboBoxSerialSingleParity.Size = new System.Drawing.Size(53, 21);
            this.comboBoxSerialSingleParity.TabIndex = 7;
            this.comboBoxSerialSingleParity.Text = "None";
            // 
            // comboBoxSerialSingleStopbits
            // 
            this.comboBoxSerialSingleStopbits.FormattingEnabled = true;
            this.comboBoxSerialSingleStopbits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBoxSerialSingleStopbits.Location = new System.Drawing.Point(284, 45);
            this.comboBoxSerialSingleStopbits.Name = "comboBoxSerialSingleStopbits";
            this.comboBoxSerialSingleStopbits.Size = new System.Drawing.Size(38, 21);
            this.comboBoxSerialSingleStopbits.TabIndex = 8;
            this.comboBoxSerialSingleStopbits.Text = "1";
            // 
            // comboBoxSerialSingleParityErrorCharacter
            // 
            this.comboBoxSerialSingleParityErrorCharacter.FormattingEnabled = true;
            this.comboBoxSerialSingleParityErrorCharacter.Items.AddRange(new object[] {
            "(ignore)",
            "35(\'#\')",
            "42(\'*\')",
            "63(\'?\')",
            "248(\'phi\')"});
            this.comboBoxSerialSingleParityErrorCharacter.Location = new System.Drawing.Point(338, 45);
            this.comboBoxSerialSingleParityErrorCharacter.Name = "comboBoxSerialSingleParityErrorCharacter";
            this.comboBoxSerialSingleParityErrorCharacter.Size = new System.Drawing.Size(64, 21);
            this.comboBoxSerialSingleParityErrorCharacter.TabIndex = 9;
            this.comboBoxSerialSingleParityErrorCharacter.Text = "63(\'?\')";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxSerialSingleCOMPORT
            // 
            this.comboBoxSerialSingleCOMPORT.FormattingEnabled = true;
            this.comboBoxSerialSingleCOMPORT.Location = new System.Drawing.Point(12, 45);
            this.comboBoxSerialSingleCOMPORT.Name = "comboBoxSerialSingleCOMPORT";
            this.comboBoxSerialSingleCOMPORT.Size = new System.Drawing.Size(65, 21);
            this.comboBoxSerialSingleCOMPORT.TabIndex = 13;
            // 
            // FormSerialSinglePortSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 121);
            this.Controls.Add(this.comboBoxSerialSingleCOMPORT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSerialSingleParityErrorCharacter);
            this.Controls.Add(this.comboBoxSerialSingleStopbits);
            this.Controls.Add(this.comboBoxSerialSingleParity);
            this.Controls.Add(this.comboBoxSerialSingleDatabits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSerialSingleBaudrate);
            this.Name = "FormSerialSinglePortSetup";
            this.Text = "Serial Setup Single Port";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSerialSingleBaudrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSerialSingleDatabits;
        private System.Windows.Forms.ComboBox comboBoxSerialSingleParity;
        private System.Windows.Forms.ComboBox comboBoxSerialSingleStopbits;
        private System.Windows.Forms.ComboBox comboBoxSerialSingleParityErrorCharacter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxSerialSingleCOMPORT;
    }
}