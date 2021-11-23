using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将当前目录或文件的全名称与数组中的路径拼接在一起，返回拼接后的字符串
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <param name="paths">目录数组</param>
        /// <returns></returns>
        public static string PathCombine(this DirectoryInfo @this, params string[] paths)
        {
            List<string> list = paths.ToList();
            list.Insert(0, @this.FullName);
            return Path.Combine(list.ToArray());
        }
    }
}