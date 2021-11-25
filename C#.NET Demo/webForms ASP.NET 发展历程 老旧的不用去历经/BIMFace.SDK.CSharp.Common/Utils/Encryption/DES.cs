// /* ---------------------------------------------------------------------------------------
//    文件名：Base64Utility.cs
//    文件功能描述：
// 
//    创建标识：20200308
//    作   者：张传宁 （QQ：905442693  微信：savionzhang）  
//    作者博客：https://www.cnblogs.com/SavionZhang/
//    BIMFace专栏地址：https://www.cnblogs.com/SavionZhang/p/11424431.html
// 
//    修改标识： 
//    修改描述：
//  ------------------------------------------------------------------------------------------*/

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BIMFace.SDK.CSharp.Common.Utils
{
    public static partial class CryptoUtility
    {
        #region DES 对称加密

        /// <summary>
        ///  注意 DEFAULT_DES_KEY 的长度为10位(如果要增加或者减少key长度,调整IV的长度就可以) 
        /// </summary>
        public const string DEFAULT_DES_KEY = "@L9#W3F&6$";
        private const int DES_KEY_LENGTH = 10;
        private static readonly byte[] DES_RgbIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF, 0x1A, 0x2B };

        /// <summary> 
        ///  使用RSA(对称加密)算法加密字符串
        /// </summary> 
        /// <param name="this">待加密字符串</param> 
        /// <returns></returns> 
        public static string EncryptByDES(this string @this)
        {
            return EncryptByDES(@this, DEFAULT_DES_KEY);
        }

        /// <summary> 
        ///  使用RSA(对称加密)算法加密字符串。注意 key 的长度为10位。字符串的编码方式为UTF8
        /// </summary> 
        /// <param name="this">待加密字符串。字符串的编码方式为UTF8</param> 
        /// <param name="key">加密键。编码方式为UTF8</param> 
        /// <returns></returns> 
        public static string EncryptByDES(this string @this, string key)
        {
            byte[] rgbKey = Encoding.UTF8.GetBytes(key.Substring(0, DES_KEY_LENGTH));
            byte[] inputByteArray = Encoding.UTF8.GetBytes(@this);

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(rgbKey, DES_RgbIV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }

        /// <summary> 
        ///  使用RSA(对称加密)算法解密字符串
        /// </summary> 
        /// <param name="this">待解密的字符串</param>  
        /// <returns>解密后的字符串</returns> 
        public static string DecryptByDES(this string @this)
        {
            return DecryptByDES(@this, DEFAULT_DES_KEY);
        }

        /// <summary> 
        ///  使用RSA(对称加密)算法解密字符串。注意 key 的长度为10位
        /// </summary> 
        /// <param name="this">待解密的字符串</param> 
        /// <param name="key">解密键。编码方式为UTF8</param> 
        /// <returns>解密后的字符串</returns> 
        public static string DecryptByDES(this string @this, string key)
        {
            byte[] rgbKey = Encoding.UTF8.GetBytes(key.Substring(0, DES_KEY_LENGTH));
            byte[] inputByteArray = new Byte[@this.Length];

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            inputByteArray = Convert.FromBase64String(@this);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(rgbKey, DES_RgbIV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            Encoding encoding = new UTF8Encoding();
            return encoding.GetString(ms.ToArray());
        }

        /// <summary> 
        ///  使用RSA(对称加密)算法加密文件
        /// </summary> 
        /// <param name="inFilePath">待加密的文件路径</param> 
        /// <param name="outFilePath">输出文件路径</param> 
        public static void EncryptFileByDES(string inFilePath, string outFilePath)
        {
            EncryptFileByDES(inFilePath, outFilePath, DEFAULT_DES_KEY);
        }

        /// <summary> 
        ///  使用RSA(对称加密)算法加密文件。注意 key 的长度为10位
        /// </summary> 
        /// <param name="inFilePath">待加密的文件路径</param> 
        /// <param name="outFilePath">输出文件路径</param> 
        /// <param name="key">加密键。编码方式为UTF8</param> 
        public static void EncryptFileByDES(string inFilePath, string outFilePath, string key)
        {
            byte[] rgbKey = Encoding.UTF8.GetBytes(key.Substring(0, DES_KEY_LENGTH));
            FileStream fileStreamIn = new FileStream(inFilePath, FileMode.Open, FileAccess.Read);
            FileStream fileStreamOut = new FileStream(outFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            fileStreamOut.SetLength(0);
            byte[] bin = new byte[100];
            long rdLen = 0;
            long totLen = fileStreamIn.Length;

            DES des = new DESCryptoServiceProvider();
            CryptoStream encStream = new CryptoStream(fileStreamOut, des.CreateEncryptor(rgbKey, DES_RgbIV), CryptoStreamMode.Write);

            while (rdLen < totLen)
            {
                var len = fileStreamIn.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                rdLen = rdLen + len;
            }
            encStream.Close();
            fileStreamOut.Close();
            fileStreamIn.Close();
        }

        /// <summary> 
        ///  使用RSA(对称加密)算法解密文件
        /// </summary> 
        /// <param name="inFilePath">待解密的文件路径</param> 
        /// <param name="outFilePath">输出路径</param>  
        public static void DecryptFileByDES(string inFilePath, string outFilePath)
        {
            DecryptFileByDES(inFilePath, outFilePath,DEFAULT_DES_KEY);
        }

        /// <summary> 
        ///  使用RSA(对称加密)算法解密文件。注意 key 的长度为10位
        /// </summary> 
        /// <param name="inFilePath">待解密的文件路径</param> 
        /// <param name="outFilePath">输出路径</param> 
        /// <param name="key">解密键。编码方式为UTF8</param> 
        public static void DecryptFileByDES(string inFilePath, string outFilePath, string key)
        {
            byte[] rgbKey = Encoding.UTF8.GetBytes(key.Substring(0, DES_KEY_LENGTH));
            FileStream fileStreamIn = new FileStream(inFilePath, FileMode.Open, FileAccess.Read);
            FileStream fileStreamOut = new FileStream(outFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            fileStreamOut.SetLength(0);
            byte[] bin = new byte[100];
            long rdLen = 0;
            long totLen = fileStreamIn.Length;

            DES des = new DESCryptoServiceProvider();
            CryptoStream encStream = new CryptoStream(fileStreamOut, des.CreateDecryptor(rgbKey, DES_RgbIV), CryptoStreamMode.Write);

            while (rdLen < totLen)
            {
                var len = fileStreamIn.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                rdLen = rdLen + len;
            }
            encStream.Close();
            fileStreamOut.Close();
            fileStreamIn.Close();
        }

        #endregion
    }
}