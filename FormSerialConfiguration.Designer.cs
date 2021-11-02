
namespace Developer_Tools
{
    partial class FormSerialConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerialConfiguration));
            this.comboBox_SerialCOMPORT = new System.Windows.Forms.ComboBox();
            this.comboBox_SerialBaudrate = new System.Windows.Forms.ComboBox();
            this.comboBox_SerialParity = new System.Windows.Forms.ComboBox();
            this.comboBox_SerialDatabits = new System.Windows.Forms.ComboBox();
            this.comboBox_SerialHandshake = new System.Windows.Forms.ComboBox();
            this.comboBox_SerialStopbits = new System.Windows.Forms.ComboBox();
            this.button_SerialConnect = new System.Windows.Forms.Button();
            this.button_SerialDisconnect = new System.Windows.Forms.Button();
            this.comboBoxSerialSingleParityErrorCharacter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_SerialCOMPORT
            // 
            this.comboBox_SerialCOMPORT.FormattingEnabled = true;
            this.comboBox_SerialCOMPORT.Location = new System.Drawing.Point(12, 30);
            this.comboBox_SerialCOMPORT.Name = "comboBox_SerialCOMPORT";
            this.comboBox_SerialCOMPORT.Size = new System.Drawing.Size(78, 21);
            this.comboBox_SerialCOMPORT.TabIndex = 0;
            this.comboBox_SerialCOMPORT.Text = "COMPORT";
            // 
            // comboBox_SerialBaudrate
            // 
            this.comboBox_SerialBaudrate.FormattingEnabled = true;
            this.comboBox_SerialBaudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_SerialBaudrate.Location = new System.Drawing.Point(96, 30);
            this.comboBox_SerialBaudrate.Name = "comboBox_SerialBaudrate";
            this.comboBox_SerialBaudrate.Size = new System.Drawing.Size(69, 21);
            this.comboBox_SerialBaudrate.TabIndex = 1;
            this.comboBox_SerialBaudrate.Text = "Baudrate";
            // 
            // comboBox_SerialParity
            // 
            this.comboBox_SerialParity.FormattingEnabled = true;
            this.comboBox_SerialParity.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.comboBox_SerialParity.Location = new System.Drawing.Point(248, 30);
            this.comboBox_SerialParity.Name = "comboBox_SerialParity";
            this.comboBox_SerialParity.Size = new System.Drawing.Size(60, 21);
            this.comboBox_SerialParity.TabIndex = 2;
            this.comboBox_SerialParity.Text = "Parity";
            // 
            // comboBox_SerialDatabits
            // 
            this.comboBox_SerialDatabits.FormattingEnabled = true;
            this.comboBox_SerialDatabits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_SerialDatabits.Location = new System.Drawing.Point(171, 30);
            this.comboBox_SerialDatabits.Name = "comboBox_SerialDatabits";
            this.comboBox_SerialDatabits.Size = new System.Drawing.Size(71, 21);
            this.comboBox_SerialDatabits.TabIndex = 3;
            this.comboBox_SerialDatabits.Text = "DataBits";
            // 
            // comboBox_SerialHandshake
            // 
            this.comboBox_SerialHandshake.FormattingEnabled = true;
            this.comboBox_SerialHandshake.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_SerialHandshake.Location = new System.Drawing.Point(469, 30);
            this.comboBox_SerialHandshake.Name = "comboBox_SerialHandshake";
            this.comboBox_SerialHandshake.Size = new System.Drawing.Size(79, 21);
            this.comboBox_SerialHandshake.TabIndex = 4;
            this.comboBox_SerialHandshake.Text = "HandShake";
            // 
            // comboBox_SerialStopbits
            // 
            this.comboBox_SerialStopbits.FormattingEnabled = true;
            this.comboBox_SerialStopbits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox_SerialStopbits.Location = new System.Drawing.Point(384, 30);
            this.comboBox_SerialStopbits.Name = "comboBox_SerialStopbits";
            this.comboBox_SerialStopbits.Size = new System.Drawing.Size(79, 21);
            this.comboBox_SerialStopbits.TabIndex = 5;
            this.comboBox_SerialStopbits.Text = "StopBits";
            // 
            // button_SerialConnect
            // 
            this.button_SerialConnect.Location = new System.Drawing.Point(554, 12);
            this.button_SerialConnect.Name = "button_SerialConnect";
            this.button_SerialConnect.Size = new System.Drawing.Size(84, 40);
            this.button_SerialConnect.TabIndex = 6;
            this.button_SerialConnect.Text = "Connect";
            this.button_SerialConnect.UseVisualStyleBackColor = true;
            // 
            // button_SerialDisconnect
            // 
            this.button_SerialDisconnect.Location = new System.Drawing.Point(644, 12);
            this.button_SerialDisconnect.Name = "button_SerialDisconnect";
            this.button_SerialDisconnect.Size = new System.Drawing.Size(84, 40);
            this.button_SerialDisconnect.TabIndex = 7;
            this.button_SerialDisconnect.Text = "Disconnect";
            this.button_SerialDisconnect.UseVisualStyleBackColor = true;
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
            this.comboBoxSerialSingleParityErrorCharacter.Location = new System.Drawing.Point(314, 30);
            this.comboBoxSerialSingleParityErrorCharacter.Name = "comboBoxSerialSingleParityErrorCharacter";
            this.comboBoxSerialSingleParityErrorCharacter.Size = new System.Drawing.Size(64, 21);
            this.comboBoxSerialSingleParityErrorCharacter.TabIndex = 10;
            this.comboBoxSerialSingleParityErrorCharacter.Text = "Parity Error Character";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Parity Error Ch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stop Bit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date Bits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Baud rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Handshake";
            // 
            // FormSerialConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 60);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSerialSingleParityErrorCharacter);
            this.Controls.Add(this.button_SerialDisconnect);
            this.Controls.Add(this.button_SerialConnect);
            this.Controls.Add(this.comboBox_SerialStopbits);
            this.Controls.Add(this.comboBox_SerialHandshake);
            this.Controls.Add(this.comboBox_SerialDatabits);
            this.Controls.Add(this.comboBox_SerialParity);
            this.Controls.Add(this.comboBox_SerialBaudrate);
            this.Controls.Add(this.comboBox_SerialCOMPORT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSerialConfiguration";
            this.Text = "Connection Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SerialCOMPORT;
        private System.Windows.Forms.ComboBox comboBox_SerialBaudrate;
        private System.Windows.Forms.ComboBox comboBox_SerialParity;
        private System.Windows.Forms.ComboBox comboBox_SerialDatabits;
        private System.Windows.Forms.ComboBox comboBox_SerialHandshake;
        private System.Windows.Forms.ComboBox comboBox_SerialStopbits;
        private System.Windows.Forms.Button button_SerialConnect;
        private System.Windows.Forms.Button button_SerialDisconnect;
        private System.Windows.Forms.ComboBox comboBoxSerialSingleParityErrorCharacter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}