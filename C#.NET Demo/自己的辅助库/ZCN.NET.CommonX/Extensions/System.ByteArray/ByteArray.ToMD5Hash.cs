using System;
using System.Security.Cryptography;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� 8 λ�޷�������������ת��Ϊ MD5 ��ʽ���ܵ��ַ���
        /// </summary>
        /// <param name="this">��չ�����ֽ�����</param>
        /// <returns></returns>
        public static string ToMd5Hash(this Byte[] @this)
        {
            using (MD5 md5 = MD5.Create())
            {
                var sb = new StringBuilder();
                byte[] hashBytes = md5.ComputeHash(@this);
                foreach (byte bytes in hashBytes)
                {
                    sb.Append(bytes.ToString("X2"));//X2 ��ʾ������
                }

                return sb.ToString();
            }
        }

    }
}