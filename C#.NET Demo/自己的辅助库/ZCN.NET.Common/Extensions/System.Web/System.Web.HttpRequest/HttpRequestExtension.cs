#if NETFRAMEWORK

using System.Collections.Generic;
using System.Web;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        private static Dictionary<string, object> _requestDictionary;

        /// <summary>
        /// 自定义扩展方法：设置 HttpRequest 的请求内容，保存到字段中
        /// </summary>
        /// <param name="request">扩展对象</param>
        /// <param name="dic"></param>
        public static void SetDictionary(this HttpRequest request, Dictionary<string, object> dic)
        {
            _requestDictionary = dic;
        }

        /// <summary>
        /// 自定义扩展方法：从字典中获取 HttpRequest 请求的内容
        /// </summary>
        /// <param name="request">扩展对象</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetDictionary(this HttpRequest request)
        {
            return _requestDictionary;
        }
    }
}

#elif NETSTANDARD

using System.Collections.Generic;

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        private static Dictionary<string, object> _requestDictionary;

        /// <summary>
        /// 自定义扩展方法：设置 HttpRequest 的请求内容，保存到字段中
        /// </summary>
        /// <param name="request">扩展对象</param>
        /// <param name="dic"></param>
        public static void SetDictionary(this HttpRequest request, Dictionary<string, object> dic)
        {
            _requestDictionary = dic;
        }

        /// <summary>
        /// 自定义扩展方法：从字典中获取 HttpRequest 请求的内容
        /// </summary>
        /// <param name="request">扩展对象</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetDictionary(this HttpRequest request)
        {
            return _requestDictionary;
        }
    }
}

#endif



