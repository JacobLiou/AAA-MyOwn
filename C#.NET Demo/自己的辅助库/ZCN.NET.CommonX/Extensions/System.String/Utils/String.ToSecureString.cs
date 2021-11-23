using System;
using System.Security;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ���������ַ���ת��Ϊ���ܵ��ı�����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>���ܵ��ַ���</returns>
        public static SecureString ToSecureString(this string @this)
        {
            var secureString = new SecureString();
            foreach(Char c in @this)
            {
                secureString.AppendChar(c);
            }

            return secureString;
        }

        /// <summary>
        ///  �Զ�����չ��������ȡ SecureString �����ԭʼ�ַ�������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static string GetOriginalString(this SecureString @this)
        {
            string result;

            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(@this);
            try
            {
                //�����й� System.String�������临�ƴ洢�ڷ��й��ڴ��е� BSTR �ַ���
                result = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);//�ͷ�ָ��
            }

            return result;
        }
    }
}