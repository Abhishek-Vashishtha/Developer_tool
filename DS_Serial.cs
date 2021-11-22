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
        Boolean connectionStatus;
        string COMPORT;
        Int32 baudrate;
        static string[] PortListNew, PortListOld;
        public DS_Serial()
        {
            COMPORT = String.Empty;
            baudrate = 9600;
        }
        public DS_Serial(string com_port)
        {
            COMPORT = com_port;
            baudrate = 9600;
        }
        public DS_Serial(string com_port, Int32 baud_rate)
        {
            COMPORT = com_port;
            baudrate = baud_rate;
        }

        public bool Connect(string com_port, Int32 baud_rate)
        {
            if(baud_rate == 1200 || baud_rate == 2400 || baud_rate == 4800 || baud_rate == 9600 ||
                baud_rate == 19200 || baud_rate == 38400 || baud_rate == 57600 || baud_rate == 115200)
            {
                baudrate = baud_rate;
            }
            else
            {
                return false;
            }


            return true;
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
    }
}
