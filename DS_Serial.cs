using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Developer_Tools
{
    class DS_Serial : SerialPort
    {
        static string[] PortListNew, PortListOld;
        public static int totalRxBytes, totalTxBytes;
        static int RxFrameTimeOut;
        byte[] send_buffer = new byte[550];
        byte[] receive_buffer = new byte[550];
        int receive_buffer_head, send_buffer_head;
        int receive_frame_timeoutTimer;
        bool frame_process_f, frame_processed_f;
        bool frame_receiving_f;

        /* send repeat variables */
        public bool SendRepeatEnable;
        public int SendRepeatTimeInMs, SendRepeatNoOfTimes, SendRepeatSentCounter;
        int SendRepeatTimer;
        public DS_Serial()
        {
            RxFrameTimeOut = 50;
            SendRepeatSentCounter = 0;
            SendRepeatNoOfTimes = 0;
            SendRepeatTimeInMs = 0;
            receive_buffer_head = 0;
            SendRepeatEnable = false;

            frame_receiving_f = false;
            receive_frame_timeoutTimer = 0;
            frame_processed_f = true;
            frame_process_f = false;
        }
        public bool Connect(string com_port, Int32 baud_rate)
        {
            if (this.IsOpen == true)
            {
                Thread t = new Thread(() => MessageBox.Show("Serial Port Is Already Open..!"));
                t.Start();
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
                    Thread t = new Thread(() => MessageBox.Show("Error Opening the Serial Port", ex.Message));
                    t.Start();
                    return false;
                }
            }
            return true;
        }
        public bool Disconnect()
        {
            if (this.IsOpen == false)
            {
                Thread t = new Thread(() => MessageBox.Show("Serial Port Is Already Closed..!"));
                t.Start();
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
                    Thread t = new Thread(() => MessageBox.Show("Error Closing the Serial Port", ex.Message));
                    t.Start();
                    return false;
                }
            }
            return true;
        }
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesToRead = this.BytesToRead;
            if (frame_processed_f == true)
            {
                for (int index = 0; index < bytesToRead; index++)
                {
                    receive_buffer[receive_buffer_head++] = (byte)this.ReadByte();
                    if (receive_buffer_head >= 550)
                    {
                        receive_buffer_head = 0;
                        Thread t = new Thread(() => MessageBox.Show("Receive Buffer overflow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
                        t.Start();
                    }
                }
                receive_frame_timeoutTimer = 0;
                frame_receiving_f = true;
                totalRxBytes += bytesToRead;
            }
        }
        public void serial_loop_10ms()
        {
            /***************************** Data Receiving Routines *****************************/
            if (frame_receiving_f == true)
            {
                receive_frame_timeoutTimer += 10;
                if (receive_frame_timeoutTimer >= RxFrameTimeOut)
                {
                    receive_frame_timeoutTimer = 0;
                    frame_processed_f = false;      /* stops receiving new data */
                    frame_process_f = true;         /* indicates that frame has been received and now need to process */
                    frame_receiving_f = false;      /* stops increasing the timeout timer */
                }
            }
            if (frame_process_f == true)
            {
                frame_process_f = false;
                Thread ProcessFrame = new Thread(new ThreadStart(process_frame));       /* starting a async thread to process frame */
                ProcessFrame.Start();
            }

            /***************************** Data Transmitting Routines *****************************/
            if (SendRepeatEnable == true)
            {
                if (SendRepeatSentCounter < SendRepeatNoOfTimes)
                {
                    SendRepeatTimer += 10;
                    if (SendRepeatTimer >= SendRepeatTimeInMs)
                    {
                        SendRepeatTimer = 0;
                        if (write() == true)
                        {
                            Form1.fillTrafficString("<< ", send_buffer, send_buffer_head); 
                        }
                        else
                        {
                            SendRepeatEnable = false;
                            SendRepeatTimer = 0;
                            SendRepeatTimeInMs = 0;
                            SendRepeatNoOfTimes = 0;
                        }
                    }
                }
                else
                {
                    SendRepeatEnable = false;
                    SendRepeatTimer = 0;
                }
            }
        }
        public void process_frame()
        {
            Form1.fillTrafficString(">> ", receive_buffer, receive_buffer_head);

            /* Handle the received data here */









            receive_buffer_head = 0; 
            frame_processed_f = true;
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
                    Thread t = new Thread(() => MessageBox.Show(messageString, "Notification"));
                    t.Start();
                }
            }
            PortListOld = PortListNew;
        }
        private bool write()
        {
            if (this.IsOpen == true)
            {
                if (send_buffer_head >= 550)
                {
                    MessageBox.Show("Send buffer overflow..!");
                    send_buffer_head = 0;
                    return false;
                }

                try
                {
                    Write(send_buffer, 0, send_buffer_head);
                    if(SendRepeatEnable == true)
                    {
                        SendRepeatSentCounter++;
                    }
                    totalTxBytes += send_buffer_head;
                }
                catch (Exception ex)
                {
                    Thread t = new Thread(() => MessageBox.Show("Error Sending To Serial Port..!",ex.Message));
                    t.Start(); 
                    return false;
                }
            }
            else
            {
                Thread t = new Thread(() => MessageBox.Show("Serial Port Is Closed..!"));
                t.Start();
                return false;
            }
            return true;
        }
        public bool write(byte[] b_array, int start_loc, int length, bool sendHDLC)
        {
            /* checking length */
            if (sendHDLC == true)
            {
                if (start_loc + length >= 550 - 6)
                {
                    Thread t = new Thread(() => MessageBox.Show("serial tx buffer will overflow")); t.Start();
                    return false;
                }
            }
            else
            {
                if (start_loc + length >= 550)
                {
                    Thread t = new Thread(() => MessageBox.Show("serial tx buffer will overflow")); t.Start();
                    return false;
                }
            }

            /* filling send buffer and setting send_buffer_head */
            if (sendHDLC == true)
            {
                DS_HDLC.make_hdlc_frame(this.send_buffer, b_array, start_loc, length);
                send_buffer_head = length + 6;
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    send_buffer[i] = b_array[start_loc + i];
                }
                send_buffer_head = length;
            }

            if (write() == true)
            {
                Form1.fillTrafficString("<< ", send_buffer, send_buffer_head);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool write(byte[] b_array, int start_loc, int length, bool sendHDLC, bool SendRepeat1, int SendRepeatTimeInMs1, int SendRepeatNoOfTimes1)
        {
            SendRepeatEnable = SendRepeat1;
            SendRepeatTimeInMs = SendRepeatTimeInMs1;
            SendRepeatNoOfTimes = SendRepeatNoOfTimes1;
            SendRepeatSentCounter = 0;
            if (write(b_array, start_loc, length, sendHDLC) == true)
            {
                Form1.fillTrafficString("<< ", send_buffer, send_buffer_head);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
