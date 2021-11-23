using System;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ�� System.Text.Encoding ����ѯ�ַ���������һ�� System.Collections.Specialized.NameValueCollection
        /// </summary>
        /// <param name="query">Ҫ�����Ĳ�ѯ�ַ���</param>
        /// <returns>��ѯ������ֵ�� System.Collections.Specialized.NameValueCollection</returns>
        public static NameValueCollection ParseQueryString(this String query)
        {
            return HttpUtility.ParseQueryString(query);
        }

        /// <summary>
        /// �Զ�����չ��������ָ�� System.Text.Encoding ����ѯ�ַ���������һ�� System.Collections.Specialized.NameValueCollection
        /// </summary>
        /// <param name="query">Ҫ�����Ĳ�ѯ�ַ���</param>
        /// <param name="encoding">Ҫʹ�õ� System.Text.Encoding</param>
        /// <returns>��ѯ������ֵ�� System.Collections.Specialized.NameValueCollection</returns>
        public static NameValueCollection ParseQueryString(this String query, Encoding encoding)
        {
            return HttpUtility.ParseQueryString(query, encoding);
        }
    }
}