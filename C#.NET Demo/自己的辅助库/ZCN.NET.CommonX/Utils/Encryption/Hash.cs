using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

using ZCN.NET.CommonX.Constants;
using ZCN.NET.CommonX.Enums;

namespace ZCN.NET.CommonX.Utils
{
    public static partial class CryptoUtils
    {
        #region SHA1

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA1(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this">��չ���󡣴����ܵ��ַ���</param>
        /// <param name="encoding">�ַ������뷽ʽ���������Ϊnull����Ĭ��ʹ�� Encoding.UTF8���б���</param>
        /// <returns>SHA1���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA1(this string @this, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            byte[] buffer = encoding.GetBytes(@this);
            return EncryptBySHA1(buffer); //���س���Ϊ44�ֽڵ��ַ���
        }

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA1(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this">��չ���󡣴����ܵ��ַ���</param>
        /// <param name="encodingName">�ַ����������ơ�����ʹ�� EncodingNames ���ȡ��������</param>
        /// <returns>SHA1���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA1(this string @this, string encodingName = EncodingNames.UTF_8)
        {
            if (string.IsNullOrWhiteSpace(encodingName))
            {
                encodingName = EncodingNames.UTF_8;
            }
            byte[] buffer = Encoding.GetEncoding(encodingName).GetBytes(@this);
            return EncryptBySHA1(buffer); //���س���Ϊ44�ֽڵ��ַ���
        }

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA1(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this"></param>
        /// <returns>SHA1���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA1(this byte[] @this)
        {
            SHA1Managed sha = new SHA1Managed();
            byte[] result = sha.ComputeHash(@this);
            return Convert.ToBase64String(result); //���س���Ϊ44�ֽڵ��ַ���
        }

        #endregion

        #region SHA256

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA256(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoding">�ַ������뷽ʽ���������Ϊnull����Ĭ��ʹ�� Encoding.UTF8���б���</param>
        /// <returns>SHA256���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA256(this string @this, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            byte[] buffer = encoding.GetBytes(@this);
            return EncryptBySHA256(buffer); //���س���Ϊ44�ֽڵ��ַ���
        }

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA256(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this">��չ���󡣴����ܵ��ַ���</param>
        /// <param name="encodingName">�ַ����������ơ�����ʹ�� EncodingNames ���ȡ��������</param>
        /// <returns>SHA1���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA256(this string @this, string encodingName = EncodingNames.UTF_8)
        {
            if (string.IsNullOrWhiteSpace(encodingName))
            {
                encodingName = EncodingNames.UTF_8;
            }
            byte[] buffer = Encoding.GetEncoding(encodingName).GetBytes(@this);
            return EncryptBySHA256(buffer); //���س���Ϊ44�ֽڵ��ַ���
        }

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA256(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this"></param>
        /// <returns>SHA256���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA256(this byte[] @this)
        {
            SHA256Managed sha = new SHA256Managed();
            byte[] result = sha.ComputeHash(@this);
            return Convert.ToBase64String(result); //���س���Ϊ44�ֽڵ��ַ���
        }

        #endregion

        #region SHA384

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA384(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this">��չ���󡣴����ܵ��ַ���</param>
        /// <param name="encoding">�ַ������뷽ʽ���������Ϊnull����Ĭ��ʹ�� Encoding.UTF8���б���</param>
        /// <returns>SHA384���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA384(this string @this, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            byte[] buffer = encoding.GetBytes(@this);
            return EncryptBySHA384(buffer); //���س���Ϊ44�ֽڵ��ַ���
        }

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA384(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this">��չ���󡣴����ܵ��ַ���</param>
        /// <param name="encodingName">�ַ����������ơ�����ʹ�� EncodingNames ���ȡ��������</param>
        /// <returns>SHA1���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA384(this string @this, string encodingName = EncodingNames.UTF_8)
        {
            if (string.IsNullOrWhiteSpace(encodingName))
            {
                encodingName = EncodingNames.UTF_8;
            }
            byte[] buffer = Encoding.GetEncoding(encodingName).GetBytes(@this);
            return EncryptBySHA384(buffer); //���س���Ϊ44�ֽڵ��ַ���
        }

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA384(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this"></param>
        /// <returns>SHA1���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA384(this byte[] @this)
        {
            SHA384Managed sha = new SHA384Managed();
            byte[] result = sha.ComputeHash(@this);
            return Convert.ToBase64String(result); //���س���Ϊ44�ֽڵ��ַ���
        }

        #endregion

        #region SHA512

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA512(���������)��ʽ�����ַ�����  ���س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this">��չ���󡣴����ܵ��ַ���</param>
        /// <param name="encoding">�ַ������뷽ʽ���������Ϊnull����Ĭ��ʹ�� Encoding.UTF8���б���</param>
        /// <returns>SHA512���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA512(this string @this, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            byte[] buffer = encoding.GetBytes(@this);
            return EncryptBySHA512(buffer); //���س���Ϊ44�ֽڵ��ַ���
        }

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA512(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this">��չ���󡣴����ܵ��ַ���</param>
        /// <param name="encodingName">�ַ����������ơ�����ʹ�� EncodingNames ���ȡ��������</param>
        /// <returns>SHA1���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA512(this string @this, string encodingName = EncodingNames.UTF_8)
        {
            if (string.IsNullOrWhiteSpace(encodingName))
            {
                encodingName = EncodingNames.UTF_8;
            }
            byte[] buffer = Encoding.GetEncoding(encodingName).GetBytes(@this);
            return EncryptBySHA512(buffer); //���س���Ϊ44�ֽڵ��ַ���
        }

        /// <summary>
        ///   �Զ�����չ������ʹ�� SHA512(���������)��ʽ�����ַ��������س���Ϊ44�ֽڵ��ַ���
        /// </summary>
        /// <param name="this"></param>
        /// <returns>SHA1���(���س���Ϊ44�ֽڵ��ַ���)</returns>
        public static string EncryptBySHA512(this byte[] @this)
        {
            SHA512Managed sha = new SHA512Managed();
            byte[] result = sha.ComputeHash(@this);
            return Convert.ToBase64String(result); //���س���Ϊ44�ֽڵ��ַ���
        }

        #endregion

        #region Hash(���������)

        /// <summary>
        ///  �Զ�����չ������ʹ�� �Զ��� Hash(���������) �㷨�����ַ���
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static int EncryptByHash(this string @this)
        {
            const int salt = 958174;     // ��ֵ
            @this += "EncryptByHash";    // ����һ�������ַ���

            int len = @this.Length;
            int result = (@this[len - 1] - 31) * 95 + salt;
            for (int i = 0; i < len - 1; i++)
            {
                result = (result * 95) + (@this[i] - 32);
            }

            return result;
        }

        #endregion

        #region MD5(���������)

        /// <summary>
        ///  �Զ�����չ������ʹ�� MD5(���������) �㷨�����ַ��������ض�������ʽ���ַ������ַ����ı��뷽ʽΪUTF8��
        /// </summary>
        /// <param name="this">��չ�����ַ��������뷽ʽΪUTF8</param>
        /// <param name="caseType">�ַ�����Сд��Ĭ��Сд</param>
        /// <returns></returns>
        public static string EncryptByMD5(this string @this, CaseType caseType = CaseType.Lower)
        {
            using (MD5 md5 = MD5.Create())
            {
                var sb = new StringBuilder();
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(@this));
                foreach (byte bytes in hashBytes)
                {
                    sb.Append(bytes.ToString("X2"));//X2 ��ʾ������
                }

                return caseType == CaseType.Upper ? sb.ToString() : sb.ToString().ToLower();
            }
        }

        /// <summary>
        ///  �Զ�����չ������ʹ�� MD5(���������) �㷨�����ַ���(�ɶ�μ���)
        /// </summary>
        /// <param name="this">��չ�����ַ���</param>
        /// <param name="count">ʹ��MD5��ʽ���ܵĴ���(����1��10֮��)</param>
        /// <param name="caseType">�ַ�����Сд��Ĭ��Сд</param>
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
        ///  �Զ�����չ������ʹ�� MD5(���������) �㷨�����ֽ�����
        /// </summary>
        /// <param name="data">����������</param>
        /// <returns>���ܺ���ִ�</returns>
        public static byte[] EncryptByMD5(this byte[] data)
        {
            return MD5.Create().ComputeHash(data);
        }

        /// <summary>
        ///  �Զ�����չ������ʹ�� MD5(���������) �㷨�����ֽ���
        /// </summary>
        /// <param name="stream">��������</param>
        /// <returns>���ܺ���ִ�</returns>
        public static byte[] EncryptByMD5(this Stream stream)
        {
            return MD5.Create().ComputeHash(stream);
        }

        #endregion

        #region GetMD5
        /// <summary>
        /// �Զ�����չ������ ���32λ���ȵ�MD5�����ַ���
        /// </summary>
        public static string GetMD5_32(this string input)
        {
            return input.EncryptByMD5();
        }

        /// <summary>
        /// �Զ�����չ���������16λ���ȵ�MD5�����ַ���
        /// </summary>
        public static string GetMD5_16(this string input)
        {
            return GetMD5_32(input).Substring(8, 16);
        }

        /// <summary>
        ///  �Զ�����չ���������8λ���ȵ�MD5�����ַ���
        /// </summary>
        public static string GetMD5_8(this string input)
        {
            return GetMD5_32(input).Substring(8, 8);
        }

        /// <summary>
        /// �Զ�����չ������ ���4λ���ȵ�MD5�����ַ���
        /// </summary>
        public static string GetMD5_4(this string input)
        {
            return GetMD5_32(input).Substring(8, 4);
        }

        /// <summary>
        ///  ���MD5��ǰ׺�����ڼ�����޴۸�
        /// </summary>
        public static string AddMD5Profix(string input)
        {
            return GetMD5_4(input) + input;
        }

        /// <summary>
        /// �Ƴ�MD5��ǰ׺
        /// </summary>
        public static string RemoveMD5Profix(string input)
        {
            return input.Substring(4);
        }

        /// <summary>
        ///  ��֤MD5ǰ׺������ַ������ޱ��۸�
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

        #region MD5ǩ����֤

        /// <summary>
        ///  �Ը����ļ�·�����ļ����ϱ�ǩ
        /// </summary>
        /// <param name="path">Ҫ���ܵ��ļ���·��</param>
        /// <returns>��ǩ��ֵ</returns>
        public static bool AddMD5(string path)
        {
            bool isNeed = !CheckMD5(path);

            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] fileByteArray = new byte[fileStream.Length];
                fileStream.Read(fileByteArray, 0, (int)fileStream.Length);               // ���ļ�����ȡ��Buffer��
                fileStream.Close();

                if (isNeed)
                {
                    string result = MD5Buffer(fileByteArray, 0, fileByteArray.Length); // ��Buffer�е��ֽ�������MD5
                    byte[] md5 = Encoding.ASCII.GetBytes(result);        // ���ַ���ת�����ֽ������Ա�д�˵��ļ���
                    FileStream fsWrite = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                    fsWrite.Write(fileByteArray, 0, fileByteArray.Length);             // ���ļ���MD5ֵ ����д�뵽�ļ���
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
        /// �Ը���·�����ļ�������֤�����һ�·���True�����򷵻�False
        /// </summary>
        /// <param name="path"></param>
        /// <returns>�Ƿ���˱�ǩ���Ƿ��ǩֵ������ֵһ��</returns>
        public static bool CheckMD5(string path)
        {
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] fileByteArray = new byte[fileStream.Length];       // �����ļ�
                fileStream.Read(fileByteArray, 0, (int)fileStream.Length);
                fileStream.Close();

                // ���ļ������32λ������ֽڼ���MD5�����32����Ϊ��ǩλΪ32λ
                string result = MD5Buffer(fileByteArray, 0, fileByteArray.Length - 32);
                string md5 = Encoding.ASCII.GetString(fileByteArray, fileByteArray.Length - 32, 32); //��ȡ�ļ����32λ�����б���ľ���MD5ֵ
                return result == md5;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// �����ļ���MD5ֵ
        /// </summary>
        /// <param name="fileByteArray">MD5ǩ���ļ��ַ�����</param>
        /// <param name="index">������ʼλ��</param>
        /// <param name="count">������ֹλ��</param>
        /// <returns>������</returns>
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
