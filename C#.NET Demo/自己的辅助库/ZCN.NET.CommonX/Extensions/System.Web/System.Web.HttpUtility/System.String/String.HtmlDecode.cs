using System;
using System.IO;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������Ѿ��� HTML ������ַ���ת��Ϊ�ѽ�����ַ��������䷢�͸� System.IO.TextWriter �����
        /// </summary>
        /// <param name="s">Ҫ������ַ���</param>
        /// <returns>һ���ѽ�����ַ���</returns>
        public static String HtmlDecode(this String s)
        {
            return HttpUtility.HtmlDecode(s);
        }

        /// <summary>
        /// �Զ�����չ���������Ѿ��� HTML ������ַ���ת��Ϊ�ѽ�����ַ��������䷢�͸� System.IO.TextWriter �����output
        /// </summary>
        /// <param name="s">Ҫ������ַ���</param>
        /// <param name="output">System.IO.TextWriter �����</param>
        public static void HtmlDecode(this String s, TextWriter output)
        {
            HttpUtility.HtmlDecode(s, output);
        }
    }
}