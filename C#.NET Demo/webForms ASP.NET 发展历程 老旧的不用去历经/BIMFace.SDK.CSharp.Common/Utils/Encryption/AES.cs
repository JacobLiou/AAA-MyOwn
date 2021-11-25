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
using System.Text.RegularExpressions;

namespace BIMFace.SDK.CSharp.Common.Utils
{
    public static partial class CryptoUtility
    {
        #region AES RijndaelManaged 对称加密
        private const string DEFAULT_AES_KEY = "@K9#F3F&3$";
        private static readonly byte[] DEFAULT_AES_IV = { 0x41, 0x72, 0x65, 0x79, 0x6F, 0x75, 0x6D, 0x79, 0x53, 0x6E, 0x6F, 0x77, 0x6D, 0x61, 0x6E, 0x3F };

        /// <summary>
        ///  使用 AES RijndaelManaged(对称加密) 算法加密字符串。 (RijndaelManaged（AES）算法是块式加密算法)。字符串的编码方式为UTF8
        /// </summary>
        /// <param name="this">待加密字符串。编码方式为UTF8</param>
        /// <param name="cipherMode">对称算法的运算模式，默认为CipherMode.CBC</param>
        /// <param name="paddingMode">对称算法的填充模式，默认为 PaddingMode.PKCS7</param>
        /// <returns>加密结果字符串</returns>
        public static string EncryptByAES(this string @this, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            return EncryptByAES(@this, DEFAULT_AES_KEY, cipherMode, paddingMode);
        }

        /// <summary>
        ///  自定义扩展方法：使用 AES RijndaelManaged(对称加密) 算法解密字符串。字符串的编码方式为UTF8
        /// </summary>
        /// <param name="this">待解密的字符串。、编码方式为UTF8</param>
        /// <param name="cipherMode">对称算法的运算模式，默认为 CipherMode.CBC</param>
        /// <param name="paddingMode">对称算法的填充模式，默认为 PaddingMode.PKCS7</param>
        /// <returns>解密成功返回解密后的字符串,失败返源串</returns>
        public static string DecryptByAES(this string @this, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            return DecryptByAES(@this, DEFAULT_AES_KEY, cipherMode, paddingMode);
        }

        /// <summary>
        ///  使用 AES RijndaelManaged(对称加密) 算法加密字符串。 (RijndaelManaged（AES）算法是块式加密算法)。字符串的编码方式为UTF8
        /// </summary>
        /// <param name="this">待加密字符串。编码方式为UTF8</param>
        /// <param name="key">加密密钥，须半角字符。编码方式为UTF8</param>
        /// <param name="cipherMode">对称算法的运算模式，默认为 CipherMode.CBC</param>
        /// <param name="paddingMode">对称算法的填充模式，默认为 PaddingMode.PKCS7</param>
        /// <returns>加密结果字符串</returns>
        public static string EncryptByAES(this string @this, string key, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            // JAVA的AES加密要求长度必须是16位。
            // RijndaelManaged 中的密钥是32位，所以如果长度不够32位，则补齐32位。长度超过32位则从头开始截取32位
            key = GetSubString(key, 32, "");
            key = key.PadRight(32, ' ');
          
            RijndaelManaged rijndaelManaged = new RijndaelManaged
            {
                Mode = cipherMode,
                Padding = PaddingMode.PKCS7,
                Key = Encoding.UTF8.GetBytes(key.Substring(0, 32)),
                IV = DEFAULT_AES_IV
            };

            ICryptoTransform iCryptoTransform = rijndaelManaged.CreateEncryptor();

            byte[] inputDataByteArray = Encoding.UTF8.GetBytes(@this);
            byte[] encryptedDataByteArray = iCryptoTransform.TransformFinalBlock(inputDataByteArray, 0, inputDataByteArray.Length);

            return Convert.ToBase64String(encryptedDataByteArray);
        }

        /// <summary>
        ///  自定义扩展方法：使用 AES RijndaelManaged(对称加密) 算法解密字符串。字符串的编码方式为UTF8
        /// </summary>
        /// <param name="this">待解密的字符串</param>
        /// <param name="key">解密密钥,和加密密钥相同。编码方式为UTF8</param>
        /// <param name="cipherMode">对称算法的运算模式，默认为 CipherMode.CBC</param>
        /// <param name="paddingMode">对称算法的填充模式，默认为 PaddingMode.PKCS7</param>
        /// <returns>解密成功返回解密后的字符串,失败返回空</returns>
        public static string DecryptByAES(this string @this, string key, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            try
            {
                // RijndaelManaged 中的密钥是32位，所以如果长度不够32位，则补齐32位
                key = GetSubString(key, 32, "");
                key = key.PadRight(32, ' ');

                RijndaelManaged rijndaelManaged = new RijndaelManaged
                {
                    Mode = cipherMode,
                    Padding = paddingMode,
                    Key = Encoding.UTF8.GetBytes(key),
                    IV = DEFAULT_AES_IV
                };
                ICryptoTransform iCryptoTransform = rijndaelManaged.CreateDecryptor();

                byte[] inputDataByteArray = Convert.FromBase64String(@this);
                byte[] decryptedData = iCryptoTransform.TransformFinalBlock(inputDataByteArray, 0, inputDataByteArray.Length);

                return Encoding.UTF8.GetString(decryptedData);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        ///  自定义扩展方法：使用 AES RijndaelManaged(对称加密)加密文件流
        /// </summary>
        /// <param name="this">文件流对象</param>
        /// <param name="key">加密键。编码方式为UTF8</param>
        /// <param name="cipherMode">对称算法的运算模式，默认为 CipherMode.CBC</param>
        /// <param name="paddingMode">对称算法的填充模式，默认为 PaddingMode.PKCS7</param>
        /// <returns></returns>
        public static CryptoStream EncryptByAES(this FileStream @this, string key, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            // RijndaelManaged 中的密钥是32位，所以如果长度不够32位，则补齐32位
            key = GetSubString(key, 32, "");
            key = key.PadRight(32, ' ');

            RijndaelManaged rijndaelManaged = new RijndaelManaged
            {
                Mode = cipherMode,
                Padding = paddingMode,
                Key = Encoding.UTF8.GetBytes(key),
                IV = DEFAULT_AES_IV
            };

            ICryptoTransform iCryptoTransform = rijndaelManaged.CreateEncryptor();
            CryptoStream cryptoStream = new CryptoStream(@this, iCryptoTransform, CryptoStreamMode.Write);
            return cryptoStream;
        }

        /// <summary>
        ///  自定义扩展方法：使用 AES RijndaelManaged(对称加密)解密文件流
        /// </summary>
        /// <param name="this">文件流对象</param>
        /// <param name="key">解密键。编码方式为UTF8</param>
        /// <param name="cipherMode">对称算法的运算模式，默认为 CipherMode.CBC</param>
        /// <param name="paddingMode">对称算法的填充模式，默认为 PaddingMode.PKCS7</param>
        /// <returns></returns>
        public static CryptoStream DecryptByAES(this FileStream @this, string key, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            // RijndaelManaged 中的密钥是32位，所以如果长度不够32位，则补齐32位
            key = GetSubString(key, 32, "");
            key = key.PadRight(32, ' ');
            
            RijndaelManaged rijndaelManaged = new RijndaelManaged
            {
                Mode = cipherMode,
                Padding = paddingMode,
                Key = Encoding.UTF8.GetBytes(key),
                IV = DEFAULT_AES_IV
            };
            ICryptoTransform iCryptoTransform = rijndaelManaged.CreateDecryptor();
            CryptoStream cryptoStream = new CryptoStream(@this, iCryptoTransform, CryptoStreamMode.Read);
            return cryptoStream;
        }

        /// <summary>
        ///  自定义扩展方法：使用 AES RijndaelManaged(对称加密) 对指定文件加密
        /// </summary>
        /// <param name="inputFile">输入文件</param>
        /// <param name="outputFile">输出文件</param>
        /// <param name="cipherMode">对称算法的运算模式，默认为 CipherMode.CBC</param>
        /// <param name="paddingMode">对称算法的填充模式，默认为 PaddingMode.PKCS7</param>
        /// <returns></returns>
        public static bool EncryptFileByAES(this string inputFile, string outputFile, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            return EncryptFileByAES(inputFile, outputFile, DEFAULT_AES_KEY, cipherMode, paddingMode);
        }

        /// <summary>
        ///  自定义扩展方法：使用 AES RijndaelManaged(对称加密) 对指定的文件解密
        /// </summary>
        /// <param name="inputFile">输入文件</param>
        /// <param name="outputFile">输出文件</param>
        /// <param name="cipherMode">对称算法的运算模式，默认为 CipherMode.CBC</param>
        /// <param name="paddingMode">对称算法的填充模式，默认为 PaddingMode.PKCS7</param>
        /// <returns></returns>
        public static bool DecryptFileByAES(this string inputFile, string outputFile, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            return DecryptFileByAES(inputFile, outputFile, DEFAULT_AES_KEY, cipherMode, paddingMode);
        }

        /// <summary>
        ///  自定义扩展方法：使用 AES RijndaelManaged(对称加密) 对指定文件加密
        /// </summary>
        /// <param name="inputFile">输入文件</param>
        /// <param name="outputFile">输出文件</param>
        /// <param name="key">加密键。编码方式为UTF8</param>
        /// <param name="cipherMode">对称算法的运算模式，默认为 CipherMode.CBC</param>
        /// <param name="paddingMode">对称算法的填充模式，默认为 PaddingMode.PKCS7</param>
        /// <returns></returns>
        public static bool EncryptFileByAES(this string inputFile, string outputFile, string key, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            try
            {
                FileStream fileStreamIn = new FileStream(inputFile, FileMode.Open);
                FileStream fileStreamOut = new FileStream(outputFile, FileMode.Create);
                CryptoStream cryptoStream = EncryptByAES(fileStreamOut, key, cipherMode, paddingMode);
                byte[] byteArrayInput = new byte[fileStreamIn.Length];
                fileStreamIn.Read(byteArrayInput, 0, byteArrayInput.Length);
                cryptoStream.Write(byteArrayInput, 0, byteArrayInput.Length);
                cryptoStream.Close();
                fileStreamIn.Close();
                fileStreamOut.Close();
            }
            catch
            {
                //文件异常
                return false;
            }
            return true;
        }

        /// <summary>
        ///  自定义扩展方法：使用 AES RijndaelManaged(对称加密) 对指定的文件解密
        /// </summary>
        /// <param name="inputFile">输入文件</param>
        /// <param name="outputFile">输出文件</param>
        /// <param name="key">解密键。编码方式为UTF8</param>
        /// <param name="cipherMode">对称算法的运算模式，默认为CipherMode.CBC</param>
        /// <param name="paddingMode">对称算法的填充模式，默认为 PaddingMode.PKCS7</param>
        /// <returns></returns>
        public static bool DecryptFileByAES(this string inputFile, string outputFile, string key, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            try
            {
                FileStream fileStreamIn = new FileStream(inputFile, FileMode.Open);
                FileStream fileStreamOut = new FileStream(outputFile, FileMode.Create);
                CryptoStream cryptoStream = DecryptByAES(fileStreamIn, key, cipherMode, paddingMode);
                byte[] byteArrayOutput = new byte[1024];

                do
                {
                    int count = cryptoStream.Read(byteArrayOutput, 0, byteArrayOutput.Length);
                    fileStreamOut.Write(byteArrayOutput, 0, count);
                    if (count < byteArrayOutput.Length)
                    {
                        break;
                    }
                } while (true);

                cryptoStream.Close();
                fileStreamIn.Close();
                fileStreamOut.Close();
            }
            catch
            {
                //文件异常
                return false;
            }
            return true;
        }

        #endregion

        #region 辅助方法

        /// <summary>
        ///  按字节长度(按字节,一个汉字为2个字节)取得某字符串的一部分
        /// </summary>
        /// <param name="sourceString">源字符串</param>
        /// <param name="length">所取字符串字节长度</param>
        /// <param name="tailString">附加字符串(当字符串不够长时，尾部所添加的字符串，一般为"...")</param>
        /// <returns>某字符串的一部分</returns>
        private static string GetSubString(string sourceString, int length, string tailString)
        {
            return GetSubString(sourceString, 0, length, tailString);
        }

        /// <summary>
        ///  按字节长度(按字节,一个汉字为2个字节)取得某字符串的一部分
        /// </summary>
        /// <param name="sourceString">源字符串</param>
        /// <param name="startIndex">索引位置，以0开始</param>
        /// <param name="length">所取字符串字节长度</param>
        /// <param name="tailString">附加字符串(当字符串不够长时，尾部所添加的字符串，一般为"...")</param>
        /// <returns>某字符串的一部分</returns>
        private static string GetSubString(string sourceString, int startIndex, int length, string tailString)
        {
            //当是日文或韩文时(注:中文的范围:\u4e00 - \u9fa5, 日文在\u0800 - \u4e00, 韩文为\xAC00-\xD7A3)
            if (Regex.IsMatch(sourceString, "[\u0800-\u4e00]+") ||
                Regex.IsMatch(sourceString, "[\xAC00-\xD7A3]+"))
            {
                //当截取的起始位置超出字段串长度时
                if (startIndex >= sourceString.Length)
                {
                    return string.Empty;
                }
                else
                {
                    return sourceString.Substring(startIndex,
                                                  length + startIndex > sourceString.Length
                                                   ? sourceString.Length - startIndex
                                                   : length);
                }
            }

            //中文字符，如"中国人民abcd123"
            if (length <= 0)
            {
                return string.Empty;
            }

            byte[] bytesSource = Encoding.Default.GetBytes(sourceString);

            //当字符串长度大于起始位置
            if (bytesSource.Length > startIndex)
            {
                int endIndex = bytesSource.Length;

                //当要截取的长度在字符串的有效长度范围内
                if (bytesSource.Length > (startIndex + length))
                {
                    endIndex = length + startIndex;
                }
                else
                {   //当不在有效范围内时,只取到字符串的结尾
                    length = bytesSource.Length - startIndex;
                    tailString = "";
                }

                int[] anResultFlag = new int[length];
                int nFlag = 0;
                //字节大于127为双字节字符
                for (int i = startIndex; i < endIndex; i++)
                {
                    if (bytesSource[i] > 127)
                    {
                        nFlag++;
                        if (nFlag == 3)
                        {
                            nFlag = 1;
                        }
                    }
                    else
                    {
                        nFlag = 0;
                    }
                    anResultFlag[i] = nFlag;
                }
                //最后一个字节为双字节字符的一半
                if ((bytesSource[endIndex - 1] > 127) && (anResultFlag[length - 1] == 1))
                {
                    length = length + 1;
                }

                byte[] bsResult = new byte[length];
                Array.Copy(bytesSource, startIndex, bsResult, 0, length);
                var myResult = Encoding.Default.GetString(bsResult);
                myResult = myResult + tailString;

                return myResult;
            }

            return string.Empty;
        }
        #endregion
    }
}