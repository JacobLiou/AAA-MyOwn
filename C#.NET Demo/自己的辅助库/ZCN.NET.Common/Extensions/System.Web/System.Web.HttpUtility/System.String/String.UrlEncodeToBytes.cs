using System;
using System.Text;
using System.Web;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ʹ��ָ���ı�������ַ���ת��Ϊ URL ������ֽ�����
        /// </summary>
        /// <param name="str">Ҫ������ı�</param>
        /// <returns>һ���ѱ�����ֽ�����</returns>
        public static Byte[] UrlEncodeToBytes(this String str)
        {
            return HttpUtility.UrlEncodeToBytes(str);
        }

        /// <summary>
        /// �Զ�����չ������ʹ��ָ���ı�������ַ���ת��Ϊ URL ������ֽ�����
        /// </summary>
        /// <param name="str">Ҫ������ı�</param>
        /// <param name="e">ָ�����뷽���� System.Text.Encoding ����</param>
        /// <returns>һ���ѱ�����ֽ�����</returns>
        public static Byte[] UrlEncodeToBytes(this String str, Encoding e)
        {
            return HttpUtility.UrlEncodeToBytes(str, e);
        }
    }
}