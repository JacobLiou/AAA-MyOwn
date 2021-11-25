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

using BIMFace.SDK.CSharp.Common.Enums;

namespace BIMFace.SDK.CSharp.Common.Utils
{
    public static partial class CryptoUtility
    {
        #region SHA1

        /// <summary>
        ///   自定义扩展方法：使用 SHA1(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this">扩展对象。待加密的字符串</param>
        /// <param name="encoding">字符串编码方式。如果设置为null，则默认使用 Encoding.UTF8进行编码</param>
        /// <returns>SHA1结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA1(this string @this, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            byte[] buffer = encoding.GetBytes(@this);
            return EncryptBySHA1(buffer); //返回长度为44字节的字符串
        }

        /// <summary>
        ///   自定义扩展方法：使用 SHA1(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this">扩展对象。待加密的字符串</param>
        /// <param name="encodingName">字符串编码名称。建议使用 EncodingNames 类获取编码名称</param>
        /// <returns>SHA1结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA1(this string @this, string encodingName = EncodingNames.UTF_8)
        {
            if (string.IsNullOrWhiteSpace(encodingName))
            {
                encodingName = EncodingNames.UTF_8;
            }
            byte[] buffer = Encoding.GetEncoding(encodingName).GetBytes(@this);
            return EncryptBySHA1(buffer); //返回长度为44字节的字符串
        }

        /// <summary>
        ///   自定义扩展方法：使用 SHA1(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this"></param>
        /// <returns>SHA1结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA1(this byte[] @this)
        {
            SHA1Managed sha = new SHA1Managed();
            byte[] result = sha.ComputeHash(@this);
            return Convert.ToBase64String(result); //返回长度为44字节的字符串
        }

        #endregion

        #region SHA256

        /// <summary>
        ///   自定义扩展方法：使用 SHA256(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoding">字符串编码方式。如果设置为null，则默认使用 Encoding.UTF8进行编码</param>
        /// <returns>SHA256结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA256(this string @this, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            byte[] buffer = encoding.GetBytes(@this);
            return EncryptBySHA256(buffer); //返回长度为44字节的字符串
        }

        /// <summary>
        ///   自定义扩展方法：使用 SHA256(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this">扩展对象。待加密的字符串</param>
        /// <param name="encodingName">字符串编码名称。建议使用 EncodingNames 类获取编码名称</param>
        /// <returns>SHA1结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA256(this string @this, string encodingName = EncodingNames.UTF_8)
        {
            if (string.IsNullOrWhiteSpace(encodingName))
            {
                encodingName = EncodingNames.UTF_8;
            }
            byte[] buffer = Encoding.GetEncoding(encodingName).GetBytes(@this);
            return EncryptBySHA256(buffer); //返回长度为44字节的字符串
        }

        /// <summary>
        ///   自定义扩展方法：使用 SHA256(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this"></param>
        /// <returns>SHA256结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA256(this byte[] @this)
        {
            SHA256Managed sha = new SHA256Managed();
            byte[] result = sha.ComputeHash(@this);
            return Convert.ToBase64String(result); //返回长度为44字节的字符串
        }

        #endregion

        #region SHA384

        /// <summary>
        ///   自定义扩展方法：使用 SHA384(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this">扩展对象。待加密的字符串</param>
        /// <param name="encoding">字符串编码方式。如果设置为null，则默认使用 Encoding.UTF8进行编码</param>
        /// <returns>SHA384结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA384(this string @this, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            byte[] buffer = encoding.GetBytes(@this);
            return EncryptBySHA384(buffer); //返回长度为44字节的字符串
        }

        /// <summary>
        ///   自定义扩展方法：使用 SHA384(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this">扩展对象。待加密的字符串</param>
        /// <param name="encodingName">字符串编码名称。建议使用 EncodingNames 类获取编码名称</param>
        /// <returns>SHA1结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA384(this string @this, string encodingName = EncodingNames.UTF_8)
        {
            if (string.IsNullOrWhiteSpace(encodingName))
            {
                encodingName = EncodingNames.UTF_8;
            }
            byte[] buffer = Encoding.GetEncoding(encodingName).GetBytes(@this);
            return EncryptBySHA384(buffer); //返回长度为44字节的字符串
        }

        /// <summary>
        ///   自定义扩展方法：使用 SHA384(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this"></param>
        /// <returns>SHA1结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA384(this byte[] @this)
        {
            SHA384Managed sha = new SHA384Managed();
            byte[] result = sha.ComputeHash(@this);
            return Convert.ToBase64String(result); //返回长度为44字节的字符串
        }

        #endregion

        #region SHA512

        /// <summary>
        ///   自定义扩展方法：使用 SHA512(不可逆加密)方式加密字符串。  返回长度为44字节的字符串
        /// </summary>
        /// <param name="this">扩展对象。待加密的字符串</param>
        /// <param name="encoding">字符串编码方式。如果设置为null，则默认使用 Encoding.UTF8进行编码</param>
        /// <returns>SHA512结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA512(this string @this, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            byte[] buffer = encoding.GetBytes(@this);
            return EncryptBySHA512(buffer); //返回长度为44字节的字符串
        }

        /// <summary>
        ///   自定义扩展方法：使用 SHA512(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this">扩展对象。待加密的字符串</param>
        /// <param name="encodingName">字符串编码名称。建议使用 EncodingNames 类获取编码名称</param>
        /// <returns>SHA1结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA512(this string @this, string encodingName = EncodingNames.UTF_8)
        {
            if (string.IsNullOrWhiteSpace(encodingName))
            {
                encodingName = EncodingNames.UTF_8;
            }
            byte[] buffer = Encoding.GetEncoding(encodingName).GetBytes(@this);
            return EncryptBySHA512(buffer); //返回长度为44字节的字符串
        }

        /// <summary>
        ///   自定义扩展方法：使用 SHA512(不可逆加密)方式加密字符串。返回长度为44字节的字符串
        /// </summary>
        /// <param name="this"></param>
        /// <returns>SHA1结果(返回长度为44字节的字符串)</returns>
        public static string EncryptBySHA512(this byte[] @this)
        {
            SHA512Managed sha = new SHA512Managed();
            byte[] result = sha.ComputeHash(@this);
            return Convert.ToBase64String(result); //返回长度为44字节的字符串
        }

        #endregion

        #region Hash(不可逆加密)

        /// <summary>
        ///  自定义扩展方法：使用 自定义 Hash(不可逆加密) 算法加密字符串
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static int EncryptByHash(this string @this)
        {
            const int salt = 958174;     // 盐值
            @this += "EncryptByHash";    // 增加一个常量字符串

            int len = @this.Length;
            int result = (@this[len - 1] - 31) * 95 + salt;
            for (int i = 0; i < len - 1; i++)
            {
                result = (result * 95) + (@this[i] - 32);
            }

            return result;
        }

        #endregion

        #region MD5(不可逆加密)

        /// <summary>
        ///  自定义扩展方法：使用 MD5(不可逆加密) 算法加密字符串。返回二进制形式的字符串。字符串的编码方式为UTF8。
        /// </summary>
        /// <param name="this">扩展对象。字符串。编码方式为UTF8</param>
        /// <param name="caseType">字符串大小写。默认小写</param>
        /// <returns></returns>
        public static string EncryptByMD5(this string @this, CaseType caseType = CaseType.Lower)
        {
            using (MD5 md5 = MD5.Create())
            {
                var sb = new StringBuilder();
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(@this));
                foreach (byte bytes in hashBytes)
                {
                    sb.Append(bytes.ToString("X2"));//X2 表示二进制
                }

                return caseType == CaseType.Upper ? sb.ToString() : sb.ToString().ToLower();
            }
        }

        /// <summary>
        ///  自定义扩展方法：使用 MD5(不可逆加密) 算法加密字符串(可多次加密)
        /// </summary>
        /// <param name="this">扩展对象。字符串</param>
        /// <param name="count">使用MD5方式加密的次数(介于1到10之间)</param>
        /// <param name="caseType">字符串大小写。默认小写</param>
        /// <returns></returns>
        public static string EncryptByMD5(this string @this, int count, CaseType caseType = CaseType.Lower)
        {
            if (count <= 0)
            {
                count = 1;
            }
            if (count > 10)
            {
                count = 10;
            }

            for (int i = 0; i < count; i++)
            {
                @this = @this.EncryptByMD5();
            }

            return @this;
        }

        /// <summary>
        ///  自定义扩展方法：使用 MD5(不可逆加密) 算法加密字节数组
        /// </summary>
        /// <param name="data">待加密数据</param>
        /// <returns>加密后的字串</returns>
        public static byte[] EncryptByMD5(this byte[] data)
        {
            return MD5.Create().ComputeHash(data);
        }

        /// <summary>
        ///  自定义扩展方法：使用 MD5(不可逆加密) 算法加密字节流
        /// </summary>
        /// <param name="stream">待加密流</param>
        /// <returns>加密后的字串</returns>
        public static byte[] EncryptByMD5(this Stream stream)
        {
            return MD5.Create().ComputeHash(stream);
        }

        #endregion

        #region GetMD5
        /// <summary>
        /// 自定义扩展方法： 获得32位长度的MD5加密字符串
        /// </summary>
        public static string GetMD5_32(this string input)
        {
            return input.EncryptByMD5();
        }

        /// <summary>
        /// 自定义扩展方法：获得16位长度的MD5加密字符串
        /// </summary>
        public static string GetMD5_16(this string input)
        {
            return GetMD5_32(input).Substring(8, 16);
        }

        /// <summary>
        ///  自定义扩展方法：获得8位长度的MD5加密字符串
        /// </summary>
        public static string GetMD5_8(this string input)
        {
            return GetMD5_32(input).Substring(8, 8);
        }

        /// <summary>
        /// 自定义扩展方法： 获得4位长度的MD5加密字符串
        /// </summary>
        public static string GetMD5_4(this string input)
        {
            return GetMD5_32(input).Substring(8, 4);
        }

        /// <summary>
        ///  添加MD5的前缀，便于检查有无篡改
        /// </summary>
        public static string AddMD5Profix(string input)
        {
            return GetMD5_4(input) + input;
        }

        /// <summary>
        /// 移除MD5的前缀
        /// </summary>
        public static string RemoveMD5Profix(string input)
        {
            return input.Substring(4);
        }

        /// <summary>
        ///  验证MD5前缀处理的字符串有无被篡改
        /// </summary>
        public static bool ValidateValue(string input)
        {
            bool res = false;
            if (input.Length >= 4)
            {
                string tmp = input.Substring(4);
                if (input.Substring(0, 4) == GetMD5_4(tmp))
                {
                    res = true;
                }
            }
            return res;
        }

        #endregion

        #region MD5签名验证

        /// <summary>
        ///  对给定文件路径的文件加上标签
        /// </summary>
        /// <param name="path">要加密的文件的路径</param>
        /// <returns>标签的值</returns>
        public static bool AddMD5(string path)
        {
            bool isNeed = !CheckMD5(path);

            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] fileByteArray = new byte[fileStream.Length];
                fileStream.Read(fileByteArray, 0, (int)fileStream.Length);               // 将文件流读取到Buffer中
                fileStream.Close();

                if (isNeed)
                {
                    string result = MD5Buffer(fileByteArray, 0, fileByteArray.Length); // 对Buffer中的字节内容算MD5
                    byte[] md5 = Encoding.ASCII.GetBytes(result);        // 将字符串转换成字节数组以便写人到文件中
                    FileStream fsWrite = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                    fsWrite.Write(fileByteArray, 0, fileByteArray.Length);             // 将文件，MD5值 重新写入到文件中
                    fsWrite.Write(md5, 0, md5.Length);
                    fsWrite.Close();
                }
                else
                {
                    FileStream fsWrite = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                    fsWrite.Write(fileByteArray, 0, fileByteArray.Length);
                    fsWrite.Close();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 对给定路径的文件进行验证，如果一致返回True，否则返回False
        /// </summary>
        /// <param name="path"></param>
        /// <returns>是否加了标签或是否标签值与内容值一致</returns>
        public static bool CheckMD5(string path)
        {
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] fileByteArray = new byte[fileStream.Length];       // 读入文件
                fileStream.Read(fileByteArray, 0, (int)fileStream.Length);
                fileStream.Close();

                // 对文件除最后32位以外的字节计算MD5，这个32是因为标签位为32位
                string result = MD5Buffer(fileByteArray, 0, fileByteArray.Length - 32);
                string md5 = Encoding.ASCII.GetString(fileByteArray, fileByteArray.Length - 32, 32); //读取文件最后32位，其中保存的就是MD5值
                return result == md5;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 计算文件的MD5值
        /// </summary>
        /// <param name="fileByteArray">MD5签名文件字符数组</param>
        /// <param name="index">计算起始位置</param>
        /// <param name="count">计算终止位置</param>
        /// <returns>计算结果</returns>
        private static string MD5Buffer(byte[] fileByteArray, int index, int count)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(fileByteArray, index, count);
            string result = System.BitConverter.ToString(hashBytes);

            result = result.Replace("-", "");
            return result;
        }
        #endregion
    }
}
