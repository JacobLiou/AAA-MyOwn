using System;
using System.Text;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ��������� URL ������ַ���ת��Ϊ�ѽ�����ֽ�����
        /// </summary>
        /// <param name="str">Ҫ������ַ���</param>
        /// <returns>һ���ѽ�����ֽ�����</returns>
        public static Byte[] UrlDecodeToBytes(this String str)
        {
            return HttpUtility.UrlDecodeToBytes(str);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ��������� URL ������ַ���ת��Ϊ�ѽ�����ֽ�����
        /// </summary>
        /// <param name="str">Ҫ������ַ���</param>
        /// <param name="e">ָ�����뷽���� System.Text.Encoding ����</param>
        /// <returns>һ���ѽ�����ֽ�����</returns>
        public static Byte[] UrlDecodeToBytes(this String str, Encoding e)
        {
            return HttpUtility.UrlDecodeToBytes(str, e);
        }
    }
}