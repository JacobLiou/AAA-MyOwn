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
using System.Security.Cryptography;
using System.Text;

namespace BIMFace.SDK.CSharp.Common.Utils
{
    public static partial class CryptoUtility
    {
        #region C#.NET RSA 加解密

        /* .NET 的RSA，仅支持公钥加密、私钥解密。
         * 若用私钥加密，则仍是返回公钥加密结果。
         * 若用公钥解密，会出现 System.Security.Cryptography.CryptographicException: 不正确的项。 异常.\
         *
         * C# 与 Java RSA 加密与解密互通 https://www.cnblogs.com/lyqf365/p/3998577.html
         * RSA加密算法实现以及C#与java互通加解密:https://www.cnblogs.com/goodjin/archive/2012/03/30/2426120.html
         */

        #region RSA非对称加密

        /// <summary>
        ///  自定义扩展方法：使用RSA(非对称加密)算法加密字符串。字符串的编码方式为UTF8。
        /// </summary>
        /// <param name="this">扩展对象，待加密的字符串。编码方式为UTF8</param>
        /// <param name="publicKey">公钥。xml格式</param>
        /// <returns>加密密后的字符串</returns>
        public static string EncryptByRSA(this string @this, string publicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);

            byte[] plainTextByteArray = Encoding.UTF8.GetBytes(@this);
            byte[] cypherTextByteArray = rsa.Encrypt(plainTextByteArray, false);
            string result = Convert.ToBase64String(cypherTextByteArray);

            return result;
        }

        /// <summary>
        ///  自定义扩展方法：使用(非对称加密)算法解密字符串。字符串的编码方式为UTF8。
        /// </summary>
        /// <param name="this">扩展对象，待解密的字符串。编码方式为UTF8。</param>
        /// <param name="privateKey">私钥。xml格式</param>
        /// <returns>解密后的字符串</returns>
        public static string DecryptByRSA(this string @this, string privateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKey);

            byte[] plainTextByteArray = Convert.FromBase64String(@this);
            byte[] dypherTextByteArray = rsa.Decrypt(plainTextByteArray, false);
            string result = Encoding.UTF8.GetString(dypherTextByteArray);

            return result;
        }

        /// <summary>
        ///  自定义扩展方法：使用RSA(非对称加密)算法加密字节数组
        /// </summary>
        /// <param name="this">扩展对象，待加密字节数组</param>
        /// <param name="publicKey">公钥。xml格式</param>
        /// <returns>加密密后的字符串</returns>
        public static string EncryptByRSA(this byte[] @this, string publicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);

            byte[] cypherTextByteArray = rsa.Encrypt(@this, false);
            string result = Convert.ToBase64String(cypherTextByteArray);

            return result;
        }

        /// <summary>
        ///  自定义扩展方法：使用RSA(非对称加密)算法解密字节数组
        /// </summary>
        /// <param name="this">扩展对象，待解密字节数组</param>
        /// <param name="privateKey">私钥</param>
        /// <returns>解密后的字符串</returns>
        public static string DecryptByRSA(this byte[] @this, string privateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKey);

            byte[] dypherTextByteArray = rsa.Decrypt(@this, false);
            string result = (new UnicodeEncoding()).GetString(dypherTextByteArray);

            return result;
        }

        #endregion

        #region 非对称加密签名、验证

        /// <summary>
        ///  自定义扩展方法：使用RSA(非对称加密)算法签名数据。字符串的编码方式为UTF8。
        /// </summary>
        /// <param name="this">扩展对象，待签名的字符串。编码方式为UTF8</param>
        /// <param name="privateKey">私钥。xml格式</param>
        /// <returns>加密后的数据</returns>
        public static string SignatureByRSA(this string @this, string privateKey)
        {
            if(string.IsNullOrWhiteSpace(@this))
                throw new ArgumentException("待加密的字符串为空。");
            if (string.IsNullOrWhiteSpace(privateKey))
                throw new ArgumentException("私钥为空。");

            byte[] rgbSource = Encoding.UTF8.GetBytes(@this);
            return SignatureByRSA(rgbSource,privateKey);
        }

        /// <summary>
        ///  自定义扩展方法：使用RSA(非对称加密)算法签名数据
        /// </summary>
        /// <param name="this">待加密的字符串</param>
        /// <param name="privateKey">私钥。xml格式</param>
        /// <returns>加密后的数据</returns>
        public static string SignatureByRSA(this byte[] @this, string privateKey)
        {
            string signature;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);                                                               //私钥
                RSAPKCS1SignatureFormatter rsaPKCS1SignatureFormatter = new RSAPKCS1SignatureFormatter(rsa); // 加密对象 
                rsaPKCS1SignatureFormatter.SetHashAlgorithm(HashNames.SHA1);
                
                SHA1Managed sha1 = new SHA1Managed();
                byte[] rgbComputeHash = sha1.ComputeHash(@this);
                byte[] rgbSignature = rsaPKCS1SignatureFormatter.CreateSignature(rgbComputeHash);
                signature = Convert.ToBase64String(rgbSignature);
            }

            return signature;
        }

        /// <summary>
        ///  自定义扩展方法：对私钥加密的字符串，使用公钥对其进行验证。字符串的编码方式为UTF8。
        /// </summary>
        /// <param name="originalString">未加密的文本，如机器码。字符串的编码方式为UTF8。</param>
        /// <param name="encrytedString">加密后的文本，如注册序列号</param>
        /// <param name="publicKey">非对称加密的公钥。xml格式</param>
        /// <returns>如果验证成功返回True，否则为False</returns>
        public static bool VerifySignatureByRSA(string originalString, string encrytedString, string publicKey)
        {
            bool success = false;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.FromXmlString(publicKey); //公钥
                    RSAPKCS1SignatureDeformatter rsaPkcs1SignatureDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    rsaPkcs1SignatureDeformatter.SetHashAlgorithm("SHA1");

                    byte[] rgbSignature = Convert.FromBase64String(encrytedString); //验证
                    SHA1Managed sha1 = new SHA1Managed();
                    byte[] rgbComputeHash = sha1.ComputeHash(Encoding.UTF8.GetBytes(originalString));
                    if (rsaPkcs1SignatureDeformatter.VerifySignature(rgbComputeHash, rgbSignature))
                    {
                        success = true;
                    }
                }
                catch
                {
                }
            }

            return success;
        }

        #endregion

        /// <summary>
        ///  随机生成一对非对称加密的私钥和公钥
        /// </summary>
        /// <param name="privateKey">输出参数，私钥</param>
        /// <param name="publicKey">输出参数，公钥</param>
        public static void GenerateRSAKeyPair(out string privateKey, out string publicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            privateKey = rsa.ToXmlString(true);
            publicKey = rsa.ToXmlString(false);
        }

        #endregion
    }
}