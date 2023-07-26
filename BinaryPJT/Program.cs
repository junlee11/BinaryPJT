using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPJT
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryClass binaryClass = new BinaryClass();

            //string -> hex -> bytes
            string str = "hi";
            string hex = binaryClass.StringToHex(str);
            byte[] bytes = binaryClass.HexStringToByteHex(hex.Replace("-",""));

            string rst = binaryClass.byteArrayToString(bytes);

            Console.WriteLine(rst);            

            Console.ReadLine();
        }
    }

    public class BinaryClass
    {
        public byte[] HexStringToByteHex(string strHex)
        {
            byte[] bytes = new byte[strHex.Length / 2];

            for (int count = 0; count < strHex.Length; count += 2)
            {
                bytes[count / 2] = System.Convert.ToByte(strHex.Substring(count, 2), 16);
            }
            return bytes;
        }

        public string StringToHex(string str)
        {            
            //문자열을 hex로 변환
            byte[] bytes = Encoding.Default.GetBytes(str);
            string hexString = BitConverter.ToString(bytes);
            //hexString = hexString.Replace("-", "");
            return hexString;
        }

        public string ByteToString(byte srcByte)
        {
            //한개의 바이트를 hex로 변환
            return srcByte.ToString("X2");
        }

        public string byteArrayToHexString(byte[] convBytes)
        {
            //바이트 배열을 hex로 변환
            return BitConverter.ToString(convBytes).Replace("-", "");
        }

        public string byteArrayToString(byte[] srcBytes)
        {
            //바이트 배열을 문자열로 변환
            return Encoding.Default.GetString(srcBytes);
        }

        public byte[] getByteArrayFromString(string sSrc)
        {
            //문자열을 바이트 배열로 변환
            byte[] retBytes;

            retBytes = Encoding.Default.GetBytes(sSrc);

            return retBytes;
        }
    }
}

