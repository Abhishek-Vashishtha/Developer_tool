
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
            this.SuspendLayout();
            // 
            // comboBox_SerialCOMPORT
            // 
            this.comboBox_SerialCOMPORT.FormattingEnabled = true;
            this.comboBox_SerialCOMPORT.Location = new System.Drawing.Point(21, 14);
            this.comboBox_SerialCOMPORT.Name = "comboBox_SerialCOMPORT";
            this.comboBox_SerialCOMPORT.Size = new System.Drawing.Size(88, 21);
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
            this.comboBox_SerialBaudrate.Location = new System.Drawing.Point(115, 14);
            this.comboBox_SerialBaudrate.Name = "comboBox_SerialBaudrate";
            this.comboBox_SerialBaudrate.Size = new System.Drawing.Size(69, 21);
            this.comboBox_SerialBaudrate.TabIndex = 1;
            this.comboBox_SerialBaudrate.Text = "Baudrate";
            // 
            // comboBox_SerialParity
            // 
            this.comboBox_SerialParity.FormattingEnabled = true;
            this.comboBox_SerialParity.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_SerialParity.Location = new System.Drawing.Point(190, 14);
            this.comboBox_SerialParity.Name = "comboBox_SerialParity";
            this.comboBox_SerialParity.Size = new System.Drawing.Size(60, 21);
            this.comboBox_SerialParity.TabIndex = 2;
            this.comboBox_SerialParity.Text = "Parity";
            // 
            // comboBox_SerialDatabits
            // 
            this.comboBox_SerialDatabits.FormattingEnabled = true;
            this.comboBox_SerialDatabits.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_SerialDatabits.Location = new System.Drawing.Point(179, 41);
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
            this.comboBox_SerialHandshake.Location = new System.Drawing.Point(265, 14);
            this.comboBox_SerialHandshake.Name = "comboBox_SerialHandshake";
            this.comboBox_SerialHandshake.Size = new System.Drawing.Size(79, 21);
            this.comboBox_SerialHandshake.TabIndex = 4;
            this.comboBox_SerialHandshake.Text = "HandShake";
            // 
            // comboBox_SerialStopbits
            // 
            this.comboBox_SerialStopbits.FormattingEnabled = true;
            this.comboBox_SerialStopbits.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_SerialStopbits.Location = new System.Drawing.Point(265, 41);
            this.comboBox_SerialStopbits.Name = "comboBox_SerialStopbits";
            this.comboBox_SerialStopbits.Size = new System.Drawing.Size(79, 21);
            this.comboBox_SerialStopbits.TabIndex = 5;
            this.comboBox_SerialStopbits.Text = "StopBits";
            // 
            // button_SerialConnect
            // 
            this.button_SerialConnect.Location = new System.Drawing.Point(350, 14);
            this.button_SerialConnect.Name = "button_SerialConnect";
            this.button_SerialConnect.Size = new System.Drawing.Size(84, 23);
            this.button_SerialConnect.TabIndex = 6;
            this.button_SerialConnect.Text = "Connect";
            this.button_SerialConnect.UseVisualStyleBackColor = true;
            // 
            // button_SerialDisconnect
            // 
            this.button_SerialDisconnect.Location = new System.Drawing.Point(350, 39);
            this.button_SerialDisconnect.Name = "button_SerialDisconnect";
            this.button_SerialDisconnect.Size = new System.Drawing.Size(84, 23);
            this.button_SerialDisconnect.TabIndex = 7;
            this.button_SerialDisconnect.Text = "Disconnect";
            this.button_SerialDisconnect.UseVisualStyleBackColor = true;
            // 
            // FormSerialConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 149);
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
    }
}