using System;
using System.IO;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ַ���ת��Ϊ HTML ������ַ���
        /// </summary>
        /// <param name="s">Ҫ������ַ���</param>
        /// <returns>һ���ѱ�����ַ���</returns>
        public static String HtmlEncode(this String s)
        {
            return HttpUtility.HtmlEncode(s);
        }

        /// <summary>
        /// �Զ�����չ���������ַ���ת��Ϊ HTML ������ַ������������Ϊ System.IO.TextWriter ���������
        /// </summary>
        /// <param name="s">Ҫ������ַ���</param>
        /// <param name="output">System.IO.TextWriter �����</param>
        public static void HtmlEncode(this String s, TextWriter output)
        {
            HttpUtility.HtmlEncode(s, output);
        }
    }
}