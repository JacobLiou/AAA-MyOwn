using System;
using System.Text;
using System.Web;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ʹ��ָ���Ľ������ URL ������ֽ�����ת��Ϊ�ѽ�����ַ���
        /// </summary>
        /// <param name="bytes">Ҫ������ֽ�����</param>
        /// <param name="e">ָ�����뷽���� System.Text.Encoding</param>
        /// <returns></returns>
        public static String UrlDecode(this Byte[] bytes, Encoding e)
        {
            return HttpUtility.UrlDecode(bytes, e);
        }

        /// <summary>
        /// �Զ�����չ������ʹ��ָ���ı�����󣬴������е�ָ��λ�ÿ�ʼ��ָ�����ֽ���Ϊֹ���� URL ������ֽ�����ת��Ϊ�ѽ�����ַ���
        /// </summary>
        /// <param name="bytes">Ҫ������ֽ�����</param>
        /// <param name="offset">�ֽ��п�ʼ�����λ��</param>
        /// <param name="count">Ҫ������ֽ���</param>
        /// <param name="e">ָ�����뷽���� System.Text.Encoding ����</param>
        /// <returns></returns>
        public static String UrlDecode(this Byte[] bytes, Int32 offset, Int32 count, Encoding e)
        {
            return HttpUtility.UrlDecode(bytes, offset, count, e);
        }
    }
}