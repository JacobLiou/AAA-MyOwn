using System.Collections.Generic;
using System.Collections.Specialized;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 NameValueCollection 集合转换为字典 
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static IDictionary<string, object> ToDictionary(this NameValueCollection @this)
        {
            var dict = new Dictionary<string, object>();

            if(@this != null)
            {
                foreach(string key in @this.AllKeys)
                {
                    dict.Add(key, @this[key]);
                }
            }

            return dict;
        }
    }
}