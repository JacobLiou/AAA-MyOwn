using System;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回当前目录中与给定的搜索模式匹配的文件列表
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <param name="searchPatterns">要与 path 中的目录名称匹配的搜索字符串数组</param>
        /// <returns></returns>
        public static FileInfo[] GetFiles(this DirectoryInfo @this, String[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct().ToArray();
        }

        /// <summary>
        ///  自定义扩展方法：返回当前目录中与给定的搜索模式匹配的文件列表
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <param name="searchPatterns">要与 path 中的目录名称匹配的搜索字符串数组</param>
        /// <param name="searchOption">System.IO.SearchOption 枚举的一个值，指定搜索操作是应仅包含当前目录还是应包含所有子目录。
        ///   默认值为 System.IO.SearchOption.TopDirectoryOnly
        /// </param>
        /// <returns></returns>
        public static FileInfo[] GetFiles(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct().ToArray();
        }
    }
}