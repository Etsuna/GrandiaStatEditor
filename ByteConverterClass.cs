using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandiaReduxMaker
{
    public class ByteConverterClass
    {
        public static byte[] IntToByte(string value)
        {
            byte[] bytes = new byte[1];
            Buffer.BlockCopy(BitConverter.GetBytes(int.Parse(value)), 0, bytes, 0, 1);
            return bytes;
        }

        public static byte[] Int16ToBytes(string value)
        {
            byte[] bytes = new byte[2];
            Buffer.BlockCopy(BitConverter.GetBytes(int.Parse(value)), 0, bytes, 0, 2);
            return bytes;
        }

        public static string AddSeven(string value)
        {
            var result = int.Parse(value) + 7;
            return result.ToString();
        }

        public static int NibbleToByte(string nibble1, string nibble2)
        {
            var firstNibble = int.Parse(nibble1);
            var SecondNibble = int.Parse(nibble2);
            var result = (byte)(firstNibble << 4) | SecondNibble;
            return result;
        }

        public static Tuple<byte, byte> GetNibble(byte value)
        {
            byte nibble1 = (byte)(value & 0x0F);
            byte nibble2 = (byte)((value & 0xF0) >> 4);
            return Tuple.Create(nibble2, nibble1);
        }
    }

    
}
