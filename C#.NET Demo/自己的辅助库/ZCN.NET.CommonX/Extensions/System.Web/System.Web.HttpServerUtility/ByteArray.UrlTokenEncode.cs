#if NETFRAMEWORK

using System;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ��������һ���ֽ��������Ϊʹ�� Base64 ���뷽���ĵ�Ч�ַ�����ʾ��ʽ��Base64 ��һ������ͨ�� URL �������ݵı��뷽��
        /// </summary>
        /// <param name="input">��չ����</param>
        /// <returns></returns>
        public static string UrlTokenEncode(this byte[] input)
        {
            return HttpServerUtility.UrlTokenEncode(input);
        }

        /// <summary>
        ///   �Զ�����չ�������� URL �ַ�����ǽ���Ϊʹ�� 64 �������ֵĵ�Ч�ֽ�����
        /// </summary>
        /// <param name="input">��չ����</param>
        /// <returns></returns>
        public static byte[] UrlTokenEncode(this string input)
        {
            return HttpServerUtility.UrlTokenDecode(input);
        }
    }
}

#endif