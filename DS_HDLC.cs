using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Developer_Tools
{
    class DS_HDLC
    {
        /* parameter is hdlc frame length */
        static void fill_hdlc_length(byte[] b_array, int hdlc_frame_len)
        {
            b_array[1] = (byte)(0xA0 | ((hdlc_frame_len >> 8) & 0xFF));
            b_array[2] = (byte)(hdlc_frame_len % 0xFF);
        }

        /* parameter is hdlc frame length */
        static void fill_hdlc_fcs(byte[] b_array, int hdlc_frame_len)
        {
            int temp_us16 = DS_CRC.get_fcs(b_array, 1, hdlc_frame_len - 2);
            b_array[hdlc_frame_len - 1] = (byte)((hdlc_frame_len >> 8) & 0xFF);
            b_array[hdlc_frame_len] = (byte)(hdlc_frame_len % 0xFF);
        }

        /* parameter is hdlc frame length */
        static void fill_hdlc_start_end_flag(byte[] b_array, int hdlc_frame_len)
        {
            b_array[0] = 0x7E;
            b_array[hdlc_frame_len + 1] = 0x7E;
        }
        /* parameter is hdlc frame length */
        static void fill_hdlc_infornation(byte[] b_array_dest, byte[] b_array_source, int start_loc, int len)
        {
            for(int i = 0; i < len; i++)
            {
                b_array_dest[3 + i] = b_array_source[i + start_loc];
            }
        }
        public static void make_hdlc_frame(byte[] b_array, byte[] info_array, int start_loc, int len)
        {
            int hdlc_frame_len = len + 4;                   //  A0 len and FCS

            fill_hdlc_start_end_flag(b_array, hdlc_frame_len); 
            fill_hdlc_length(b_array, hdlc_frame_len);
            fill_hdlc_infornation(b_array, info_array, start_loc, len);
            fill_hdlc_fcs(b_array, hdlc_frame_len);
        }

        public static bool verify_hdlc_frame(byte[] b_array, int frame_length)
        {
            int temp_len;

            if (frame_length < 6)
            {
                return false;
            }

            if (b_array[0] != 0x7E && b_array[frame_length - 1] != 0x7E)
            {
                return false;
            }

            if ((b_array[1] & 0xF0) != 0xA0)
            {
                return false;
            }
            temp_len = (b_array[1] & 0x0F) * 256;
            temp_len += b_array[2];

            if (temp_len != frame_length - 2)
            {
                return false;
            }

            /* checking FCS */
            if (DS_CRC.check_fcs(b_array, 1, frame_length - 4) == false)
            {
                return false;
            }
            return true;
        }
    }
}
