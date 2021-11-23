using System;
using System.Web;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� URL ������ֽ�����ת��Ϊ�ѽ�����ֽ�����
        /// </summary>
        /// <param name="bytes">Ҫ������ֽ�����</param>
        /// <returns>һ���ѽ�����ֽ�����</returns>
        public static Byte[] UrlDecodeToBytes(this Byte[] bytes)
        {
            return HttpUtility.UrlDecodeToBytes(bytes);
        }

        /// <summary>
        ///  �Զ�����չ�������������е�ָ��λ�ÿ�ʼһֱ��ָ�����ֽ���Ϊֹ���� URL ������ֽ�����ת��Ϊ�ѽ�����ֽ�����
        /// </summary>
        /// <param name="bytes">Ҫ������ֽ�����</param>
        /// <param name="offset">�ֽ������п�ʼ�����λ��</param>
        /// <param name="count">Ҫ������ֽ���</param>
        /// <returns>һ���ѽ�����ֽ�����</returns>
        public static Byte[] UrlDecodeToBytes(this Byte[] bytes, Int32 offset, Int32 count)
        {
            return HttpUtility.UrlDecodeToBytes(bytes, offset, count);
        }
    }
}