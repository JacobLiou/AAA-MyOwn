// /* ---------------------------------------------------------------------------------------
//    �ļ�����Base64Utility.cs
//    �ļ�����������
// 
//    ������ʶ��20200308
//    ��   �ߣ��Ŵ��� ��QQ��905442693  ΢�ţ�savionzhang��  
//    ���߲��ͣ�https://www.cnblogs.com/SavionZhang/
//    BIMFaceר����ַ��https://www.cnblogs.com/SavionZhang/p/11424431.html
// 
//    �޸ı�ʶ�� 
//    �޸�������
//  ------------------------------------------------------------------------------------------*/

using System;
using System.Security.Cryptography;
using System.Text;

namespace BIMFace.SDK.CSharp.Common.Utils
{
    public static partial class CryptoUtility
    {
        #region C#.NET RSA �ӽ���

        /* .NET ��RSA����֧�ֹ�Կ���ܡ�˽Կ���ܡ�
         * ����˽Կ���ܣ������Ƿ��ع�Կ���ܽ����
         * ���ù�Կ���ܣ������ System.Security.Cryptography.CryptographicException: ����ȷ��� �쳣.\
         *
         * C# �� Java RSA ��������ܻ�ͨ https://www.cnblogs.com/lyqf365/p/3998577.html
         * RSA�����㷨ʵ���Լ�C#��java��ͨ�ӽ���:https://www.cnblogs.com/goodjin/archive/2012/03/30/2426120.html
         */

        #region RSA�ǶԳƼ���

        /// <summary>
        ///  �Զ�����չ������ʹ��RSA(�ǶԳƼ���)�㷨�����ַ������ַ����ı��뷽ʽΪUTF8��
        /// </summary>
        /// <param name="this">��չ���󣬴����ܵ��ַ��������뷽ʽΪUTF8</param>
        /// <param name="publicKey">��Կ��xml��ʽ</param>
        /// <returns>�����ܺ���ַ���</returns>
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
        ///  �Զ�����չ������ʹ��(�ǶԳƼ���)�㷨�����ַ������ַ����ı��뷽ʽΪUTF8��
        /// </summary>
        /// <param name="this">��չ���󣬴����ܵ��ַ��������뷽ʽΪUTF8��</param>
        /// <param name="privateKey">˽Կ��xml��ʽ</param>
        /// <returns>���ܺ���ַ���</returns>
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
        ///  �Զ�����չ������ʹ��RSA(�ǶԳƼ���)�㷨�����ֽ�����
        /// </summary>
        /// <param name="this">��չ���󣬴������ֽ�����</param>
        /// <param name="publicKey">��Կ��xml��ʽ</param>
        /// <returns>�����ܺ���ַ���</returns>
        public static string EncryptByRSA(this byte[] @this, string publicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);

            byte[] cypherTextByteArray = rsa.Encrypt(@this, false);
            string result = Convert.ToBase64String(cypherTextByteArray);

            return result;
        }

        /// <summary>
        ///  �Զ�����չ������ʹ��RSA(�ǶԳƼ���)�㷨�����ֽ�����
        /// </summary>
        /// <param name="this">��չ���󣬴������ֽ�����</param>
        /// <param name="privateKey">˽Կ</param>
        /// <returns>���ܺ���ַ���</returns>
        public static string DecryptByRSA(this byte[] @this, string privateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKey);

            byte[] dypherTextByteArray = rsa.Decrypt(@this, false);
            string result = (new UnicodeEncoding()).GetString(dypherTextByteArray);

            return result;
        }

        #endregion

        #region �ǶԳƼ���ǩ������֤

        /// <summary>
        ///  �Զ�����չ������ʹ��RSA(�ǶԳƼ���)�㷨ǩ�����ݡ��ַ����ı��뷽ʽΪUTF8��
        /// </summary>
        /// <param name="this">��չ���󣬴�ǩ�����ַ��������뷽ʽΪUTF8</param>
        /// <param name="privateKey">˽Կ��xml��ʽ</param>
        /// <returns>���ܺ������</returns>
        public static string SignatureByRSA(this string @this, string privateKey)
        {
            if(string.IsNullOrWhiteSpace(@this))
                throw new ArgumentException("�����ܵ��ַ���Ϊ�ա�");
            if (string.IsNullOrWhiteSpace(privateKey))
                throw new ArgumentException("˽ԿΪ�ա�");

            byte[] rgbSource = Encoding.UTF8.GetBytes(@this);
            return SignatureByRSA(rgbSource,privateKey);
        }

        /// <summary>
        ///  �Զ�����չ������ʹ��RSA(�ǶԳƼ���)�㷨ǩ������
        /// </summary>
        /// <param name="this">�����ܵ��ַ���</param>
        /// <param name="privateKey">˽Կ��xml��ʽ</param>
        /// <returns>���ܺ������</returns>
        public static string SignatureByRSA(this byte[] @this, string privateKey)
        {
            string signature;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);                                                               //˽Կ
                RSAPKCS1SignatureFormatter rsaPKCS1SignatureFormatter = new RSAPKCS1SignatureFormatter(rsa); // ���ܶ��� 
                rsaPKCS1SignatureFormatter.SetHashAlgorithm(HashNames.SHA1);
                
                SHA1Managed sha1 = new SHA1Managed();
                byte[] rgbComputeHash = sha1.ComputeHash(@this);
                byte[] rgbSignature = rsaPKCS1SignatureFormatter.CreateSignature(rgbComputeHash);
                signature = Convert.ToBase64String(rgbSignature);
            }

            return signature;
        }

        /// <summary>
        ///  �Զ�����չ��������˽Կ���ܵ��ַ�����ʹ�ù�Կ���������֤���ַ����ı��뷽ʽΪUTF8��
        /// </summary>
        /// <param name="originalString">δ���ܵ��ı���������롣�ַ����ı��뷽ʽΪUTF8��</param>
        /// <param name="encrytedString">���ܺ���ı�����ע�����к�</param>
        /// <param name="publicKey">�ǶԳƼ��ܵĹ�Կ��xml��ʽ</param>
        /// <returns>�����֤�ɹ�����True������ΪFalse</returns>
        public static bool VerifySignatureByRSA(string originalString, string encrytedString, string publicKey)
        {
            bool success = false;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.FromXmlString(publicKey); //��Կ
                    RSAPKCS1SignatureDeformatter rsaPkcs1SignatureDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    rsaPkcs1SignatureDeformatter.SetHashAlgorithm("SHA1");

                    byte[] rgbSignature = Convert.FromBase64String(encrytedString); //��֤
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
        ///  �������һ�ԷǶԳƼ��ܵ�˽Կ�͹�Կ
        /// </summary>
        /// <param name="privateKey">���������˽Կ</param>
        /// <param name="publicKey">�����������Կ</param>
        public static void GenerateRSAKeyPair(out string privateKey, out string publicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            privateKey = rsa.ToXmlString(true);
            publicKey = rsa.ToXmlString(false);
        }

        #endregion
    }
}