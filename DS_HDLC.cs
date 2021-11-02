using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Developer_Tools
{
    class DS_HDLC
    {
        
        public static bool verify_hdlc_frame(byte[] b_array, int length)
        {
            int temp_len;

            if (length < 6)
            {
                return false;
            }

            if (b_array[0] != 0x7E && b_array[length - 1] != 0x7E)
            {
                return false;
            }

            if ((b_array[1] & 0xF0) != 0xA0)
            {
                return false;
            }
            temp_len = (b_array[1] & 0x0F) * 256;
            temp_len += b_array[2];

            if (temp_len != length - 2)
            {
                return false;
            }

            /* checking FCS */
            if (DS_CRC.check_fcs(b_array, 1, length - 4) == false)
            {
                return false;
            }
            return true;
        }

        /* parameter is hdlc frame length */
        public static void fill_hdlc_length(byte[] b_array, int frame_len)
        {
            b_array[1] = (byte)(0xA0 | ((frame_len >> 8) & 0xFF));
            b_array[2] = (byte)(frame_len % 0xFF);
        }

        /* parameter is hdlc frame length */
        public static void fill_hdlc_fcs(byte[] b_array, int frame_len)
        {
            int temp_us16 = DS_CRC.get_fcs(b_array, 1, frame_len - 2);
            b_array[frame_len - 1] = (byte)((frame_len >> 8) & 0xFF);
            b_array[frame_len] = (byte)(frame_len % 0xFF);
        }

        /* parameter is hdlc frame length */
        public static void fill_hdlc_start_end_flag(byte[] b_array, int frame_len)
        {
            b_array[0] = 0x7E;
            b_array[frame_len + 1] = 0x7E;
        }
        
    }
}
