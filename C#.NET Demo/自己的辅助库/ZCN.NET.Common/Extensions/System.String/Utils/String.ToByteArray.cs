using System;
using System.Text;

using ZCN.NET.Common.Constants;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ��������ָ���ı��뷽ʽ���ַ���ת��Ϊ�ֽ����� 
        /// </summary>
        /// <param name="sourceString">��չ����</param>
        /// <param name="encoding">���뷽ʽ�����Ϊnull����ʹ��ϵͳĬ�ϵı��뷽ʽ</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArray(this string sourceString, Encoding encoding)
        {
            if (encoding == null)
            {
                encoding = Encoding.Default;
            }

            return encoding.GetBytes(sourceString);
        }

        /// <summary>
        ///   �Զ�����չ��������ָ���ı��뷽ʽ���ַ���ת��Ϊ�ֽ����� 
        /// </summary>
        /// <param name="sourceString">��չ����</param>
        /// <param name="encodingName">���뷽ʽ������ʹ�� EncodingNames ���еĳ���ֵ</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArray(this string sourceString, string encodingName)
        {
            byte[] bytes = null;

            if (!string.IsNullOrWhiteSpace(encodingName))
            {
                bytes = Encoding.GetEncoding(encodingName).GetBytes(sourceString);
            }
            
            return bytes;
        }

        /// <summary>
        ///   �Զ�����չ��������ASCIIEncoding���뷽ʽ���ַ���ת��Ϊ�ֽ����� 
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArrayByAscii(this string @this)
        {
            return Encoding.ASCII.GetBytes(@this);
        }

        /// <summary>
        ///   �Զ�����չ��������ָ���ַ������������������ݱ���Ϊ Base64 ���֣�ת��Ϊ��Ч�� 8 λ�޷����������顣
        ///   ����ַ��������ɶ��������ݱ���Ϊ Base64 ���ֵ��ַ��������ת��ʧ�ܡ����� null��
        /// </summary>
        /// <param name="sourceString">��չ���󡣶��������ݱ���Ϊ Base64 �����ַ���</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArrayByBase64(this string sourceString)
        {
            try
            {
                return Convert.FromBase64String(sourceString);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///   �Զ�����չ������ʹ�� Big Endian �ֽ�˳��� UTF-16 ��ʽ�ı��뽫�ַ���ת��Ϊ�ֽ����� 
        /// </summary>
        /// <param name="sourceString">��չ����</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArrayByBigEndianUnicode(this string sourceString)
        {
            return Encoding.BigEndianUnicode.GetBytes(sourceString);
        }

        /// <summary>
        ///   �Զ�����չ������ʹ�ò���ϵͳ�ĵ�ǰ ANSI ����ҳ�ı��뽫�ַ���ת��Ϊ�ֽ����� 
        /// </summary>
        /// <param name="sourceString">��չ����</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArrayByDefault(this string sourceString)
        {
            return Encoding.Default.GetBytes(sourceString);
        }

        /// <summary>
        ///   �Զ�����չ�������� UTF7 ���뷽ʽ���ַ���ת��Ϊ�ֽ����� 
        /// </summary>
        /// <param name="sourceString">��չ����</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArrayByGB2312(this string sourceString)
        {
            return Encoding.GetEncoding(EncodingNames.GB2312).GetBytes(sourceString);
        }

        /// <summary>
        ///   �Զ�����չ�������� UTF7 ���뷽ʽ���ַ���ת��Ϊ�ֽ����� 
        /// </summary>
        /// <param name="sourceString">��չ����</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArrayByUtf7(this string sourceString)
        {
            return Encoding.UTF7.GetBytes(sourceString);
        }

        /// <summary>
        ///   �Զ�����չ�������� UTF8 ���뷽ʽ���ַ���ת��Ϊ�ֽ����� 
        /// </summary>
        /// <param name="sourceString">��չ����</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArrayByUtf8(this string sourceString)
        {
            return Encoding.UTF8.GetBytes(sourceString);
        }

        /// <summary>
        ///   �Զ�����չ�������� UTF32 ���뷽ʽ���ַ���ת��Ϊ�ֽ����� 
        /// </summary>
        /// <param name="sourceString">��չ����</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArrayByUtf32(this string sourceString)
        {
            return Encoding.UTF32.GetBytes(sourceString);
        }

        /// <summary>
        ///   �Զ�����չ�������� Unicode ���뷽ʽ���ַ���ת��Ϊ�ֽ����� 
        /// </summary>
        /// <param name="sourceString">��չ����</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] ToByteArrayByUnicode(this string sourceString)
        {
            return Encoding.Unicode.GetBytes(sourceString);
        }
    }
}