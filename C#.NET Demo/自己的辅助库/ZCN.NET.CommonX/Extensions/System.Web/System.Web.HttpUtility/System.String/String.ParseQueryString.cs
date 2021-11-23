using System;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定 System.Text.Encoding 将查询字符串分析成一个 System.Collections.Specialized.NameValueCollection
        /// </summary>
        /// <param name="query">要分析的查询字符串</param>
        /// <returns>查询参数和值的 System.Collections.Specialized.NameValueCollection</returns>
        public static NameValueCollection ParseQueryString(this String query)
        {
            return HttpUtility.ParseQueryString(query);
        }

        /// <summary>
        /// 自定义扩展方法：将指定 System.Text.Encoding 将查询字符串分析成一个 System.Collections.Specialized.NameValueCollection
        /// </summary>
        /// <param name="query">要分析的查询字符串</param>
        /// <param name="encoding">要使用的 System.Text.Encoding</param>
        /// <returns>查询参数和值的 System.Collections.Specialized.NameValueCollection</returns>
        public static NameValueCollection ParseQueryString(this String query, Encoding encoding)
        {
            return HttpUtility.ParseQueryString(query, encoding);
        }
    }
}