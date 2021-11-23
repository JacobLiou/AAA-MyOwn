using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将集合中的路径信息字符串拼接成一个完整的路径，并返回该路径
        /// </summary>
        /// <param name="this">扩展对象。路径信息集合</param>
        public static string PathCombine(this IEnumerable<string> @this)
        {
            return Path.Combine(@this.ToArray());
        }
    }
}