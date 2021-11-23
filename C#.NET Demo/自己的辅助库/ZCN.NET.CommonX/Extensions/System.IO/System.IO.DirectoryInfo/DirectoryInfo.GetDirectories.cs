using System;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回当前 System.IO.DirectoryInfo 中、与给定搜索条件匹配的目录的数组
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <param name="searchPatterns">要与 path 中的目录名称匹配的搜索字符串数组</param>
        /// <returns></returns>
        public static DirectoryInfo[] GetDirectories(this DirectoryInfo @this,String[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x)).Distinct().ToArray();
        }

        /// <summary>
        ///  自定义扩展方法：返回当前 System.IO.DirectoryInfo 中与给定的搜索条件匹配并使用某个值确定是否在子目录中搜索的目录的数组
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <param name="searchPatterns">要与 path 中的目录名称匹配的搜索字符串数组</param>
        /// <param name="searchOption">System.IO.SearchOption 枚举的一个值，指定搜索操作是应仅包含当前目录还是应包含所有子目录。
        ///  默认值为 System.IO.SearchOption.TopDirectoryOnly</param>
        /// <returns></returns>
        public static DirectoryInfo[] GetDirectories(this DirectoryInfo @this,
            String[] searchPatterns,
            SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x,searchOption)).Distinct().ToArray();
        }
    }
}