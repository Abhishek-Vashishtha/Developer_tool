using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Developer_Tools
{
    class DS_Serial : SerialPort
    {
        static string[] PortListNew, PortListOld;
        byte[] send_data = new byte[550];
        byte[] receive_data = new byte[550];
        int receive_data_head, send_data_head;
        bool receive_isr_f, frame_receiving_f;
        public DS_Serial()
        {
            receive_data_head = 0;
        }
        public bool Connect(string com_port, Int32 baud_rate)
        {
            if (this.IsOpen == true)
            {
                MessageBox.Show("Serial Port Is Already Open..!");
            }
            else
            {
                if (baud_rate == 1200 || baud_rate == 2400 || baud_rate == 4800 || baud_rate == 9600 ||
                baud_rate == 19200 || baud_rate == 38400 || baud_rate == 57600 || baud_rate == 115200)
                {
                    this.BaudRate = baud_rate;
                }
                else
                {
                    return false;
                }

                if (com_port.Contains("COM") == true)
                {
                    this.PortName = com_port;
                }
                else
                {
                    return false;
                }

                this.DataBits = 8;
                this.Parity = Parity.None;
                this.StopBits = StopBits.One;
                this.ReadTimeout = 2000;
                this.WriteTimeout = 2000;
                this.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                this.DtrEnable = true; 
                try
                {
                    this.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Opening the Serial Port", ex.Message);
                    return false;
                }
            }
            return true;
        }
        public bool Disconnect()
        {
            if (this.IsOpen == false)
            {
                MessageBox.Show("Serial Port Is Already Closed..!");
                return false;
            }
            else
            {
                try
                {
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Closing the Serial Port", ex.Message);
                    return false;
                }
            }
            return true;
        }
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesToRead = this.BytesToRead;
            for (int index = 0; index < bytesToRead; ++index)
            {
                receive_data[receive_data_head++] = (byte)this.ReadByte();
                if (receive_data_head >= 550)
                {
                    receive_data_head = 0;
                    MessageBox.Show("Receive Buffer overflow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            receive_isr_f = true;
            frame_receiving_f = true;
        }
        public static void update_port_list()
        {
            string messageString = String.Empty;
            PortListNew = SerialPort.GetPortNames();
            if (PortListOld != null && PortListNew != null)
            {
                if (string.Compare(string.Join(",", PortListOld), string.Join(",", PortListNew)) != 0)
                {
                    foreach (string newList in PortListNew)
                    {
                        Boolean searchResult = false;
                        foreach (string oldList in PortListOld)
                        {
                            if (string.Compare(newList, oldList) == 0)
                            {
                                searchResult = true;
                                break;
                            }
                        }
                        if (searchResult == false)
                        {
                            if (messageString != String.Empty)
                            {
                                messageString += " | ";
                            }
                            messageString += newList + " Attached";
                        }
                    }
                    // verify from this place
                    foreach (string oldList in PortListOld)
                    {
                        Boolean searchResult = false;
                        foreach (string newList in PortListNew)
                        {
                            if (string.Compare(newList, oldList) == 0)
                            {
                                searchResult = true;
                                break;
                            }
                        }
                        if (searchResult == false)
                        {
                            if (messageString != String.Empty)
                            {
                                messageString += " | ";
                            }
                            messageString += oldList + " Removed";
                        }
                    }
                    PortListOld = PortListNew;
                    MessageBox.Show(messageString, "Notification");
                }
            }
            PortListOld = PortListNew;
        }
        public bool write(int length)
        {
            if (this.IsOpen == true)
            {
                if (length < 550)
                {
                    send_data_head = length;
                }
                else
                {
                    return false;
                }

                try
                {
                    Write(send_data, 0, send_data_head);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Sending data to Serial Port", ex.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Serial Port Is Closed..!"); 
                return false;
            }
            return true;
        }
    }
}
