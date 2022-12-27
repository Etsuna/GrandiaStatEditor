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

        public static string AddSeven(string name, string value)
        {
            var result = int.Parse(value) + 7;
            if(result < 0 || result > 14)
            {
                MessageBox.Show($"{name} must be between -7 to 7", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
            return result.ToString();
        }
    }

    
}
