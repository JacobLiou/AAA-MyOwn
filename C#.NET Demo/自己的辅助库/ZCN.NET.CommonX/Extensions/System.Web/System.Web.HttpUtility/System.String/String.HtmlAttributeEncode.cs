using System;
using System.IO;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ���������ַ�����С�޶ȵ�ת��Ϊ HTML ������ַ���
        /// </summary>
        /// <param name="s">��չ����Ҫ������ַ���</param>
        /// <returns>һ���ѱ�����ַ���</returns>
        public static String HtmlAttributeEncode(this String s)
        {
            return HttpUtility.HtmlAttributeEncode(s);
        }

        /// <summary>
        ///   �Զ�����չ���������ַ�����С�޶ȵ�ת��Ϊ HTML ������ַ����������ѱ�����ַ������͸� System.IO.TextWriter �����
        /// </summary>
        /// <param name="s">��չ����Ҫ������ַ���</param>
        /// <param name="output">System.IO.TextWriter �����</param>
        public static void HtmlAttributeEncode(this String s, TextWriter output)
        {
            HttpUtility.HtmlAttributeEncode(s, output);
        }
    }
}