using System;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将十六进制数字的格式化字符串(例如：6f1d965223738c4e58b0da9da4bc4d0203010001)
        ///  转换为二进制字节数组
        /// </summary>
        /// <param name="hexString">x50916 格式的字符串。例如：</param>
        /// <returns></returns>
        public static byte[] ConvertHexStringToByteArray(this string hexString)
        {
            hexString = hexString.Replace(" ", "");
            byte[] buffer = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i += 2)
            {
                buffer[i / 2] = (byte)Convert.ToByte(hexString.Substring(i, 2), 16);
            }

            return buffer;
        }

        /// <summary>
        ///  自定义扩展方法：将字二进制字节组转换为十六进制数字的格式化字符串（例如：e4 ca b2）
        /// </summary>
        /// <param name="data">二进制字节数组</param>
        /// <returns></returns>
        public static string ConvertByteArrayToHexString(this byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
            {
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            }

            return sb.ToString().ToUpper();
        }

        /// <summary>
        ///   自定义扩展方法：将一条十六进制字符串转换为ASCII
        /// </summary>
        /// <param name="hexString">十六进制字符串</param>
        /// <returns></returns>
        public static string ConvertHexStringToASCII(this string hexString)
        {
            byte[] bt = ConvertHexStringToBinary(hexString);
            string lin = "";
            for (int i = 0; i < bt.Length; i++)
            {
                lin = lin + bt[i] + " ";
            }

            string[] ss = lin.Trim().Split(new char[] { ' ' });
            char[] c = new char[ss.Length];
            int a;
            for (int i = 0; i < c.Length; i++)
            {
                a = Convert.ToInt32(ss[i]);
                c[i] = Convert.ToChar(a);
            }

            string b = new string(c);
            return b;
        }

        /// <summary>
        ///  自定义扩展方法：将16进制字符串转换为二进制数组
        /// </summary>
        /// <param name="hexString">十六进制字符串</param>
        /// <returns></returns>
        public static byte[] ConvertHexStringToBinary(this string hexString)
        {
            string[] tmpArray = hexString.Trim().Split(' ');
            byte[] buff = new byte[tmpArray.Length];
            for (int i = 0; i < buff.Length; i++)
            {
                buff[i] = Convert.ToByte(tmpArray[i], 16);
            }
            return buff;
        }
    }
}