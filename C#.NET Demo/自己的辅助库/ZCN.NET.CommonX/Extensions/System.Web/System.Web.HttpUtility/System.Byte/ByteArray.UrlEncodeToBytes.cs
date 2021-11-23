using System;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ֽ�����ת��Ϊ URL ������ֽ�����
        /// </summary>
        /// <param name="bytes">Ҫ������ֽ�����</param>
        /// <returns>һ���ѱ�����ֽ�����</returns>
        public static Byte[] UrlEncodeToBytes(this Byte[] bytes)
        {
            return HttpUtility.UrlEncodeToBytes(bytes);
        }

        /// <summary>
        /// �Զ�����չ�������������е�ָ��λ�ÿ�ʼһֱ��ָ�����ֽ���Ϊֹ�����ֽ�����ת��Ϊ URL ������ֽ�����
        /// </summary>
        /// <param name="bytes">Ҫ������ֽ�����</param>
        /// <param name="offset">�ֽ������п�ʼ�����λ��</param>
        /// <param name="count">Ҫ������ֽ���</param>
        /// <returns>һ���ѱ�����ֽ�����</returns>
        public static Byte[] UrlEncodeToBytes(this Byte[] bytes,Int32 offset,Int32 count)
        {
            return HttpUtility.UrlEncodeToBytes(bytes,offset,count);
        }
    }
}