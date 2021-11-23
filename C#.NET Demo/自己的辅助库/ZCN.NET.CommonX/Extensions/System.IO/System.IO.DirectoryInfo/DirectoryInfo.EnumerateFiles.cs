using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回指定路径中的文件名的可枚举集合
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <returns></returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this)
        {
            return Directory.EnumerateFiles(@this.FullName).Select(x => new FileInfo(x));
        }

        /// <summary>
        ///  自定义扩展方法：返回指定路径中的文件名的可枚举集合
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <param name="searchPattern">要与 path 中的目录名称匹配的搜索字符串</param>
        /// <returns></returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this,String searchPattern)
        {
            return Directory.EnumerateFiles(@this.FullName,searchPattern).Select(x => new FileInfo(x));
        }

        /// <summary>
        ///  自定义扩展方法：返回指定路径中与搜索模式匹配的文件名称的可枚举集合，还可以搜索子目录
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <param name="searchPattern">要与 path 中的目录名称匹配的搜索字符串</param>
        /// <param name="searchOption">System.IO.SearchOption 枚举的一个值，指定搜索操作是应仅包含当前目录还是应包含所有子目录。
        ///  默认值为 System.IO.SearchOption.TopDirectoryOnly</param>
        /// <returns></returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this,
            String searchPattern,
            SearchOption searchOption)
        {
            return Directory.EnumerateFiles(@this.FullName,searchPattern,searchOption).Select(x => new FileInfo(x));
        }

        /// <summary>
        ///  自定义扩展方法：返回指定路径中的文件名的可枚举集合
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <param name="searchPatterns">要与 path 中的目录名称匹配的搜索字符串数组</param>
        /// <returns></returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this,String[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct();
        }

        /// <summary>
        ///  自定义扩展方法：返回指定路径中与搜索模式匹配的文件名称的可枚举集合，还可以搜索子目录
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <param name="searchPatterns">要与 path 中的目录名称匹配的搜索字符串数组</param>
        /// <param name="searchOption">System.IO.SearchOption 枚举的一个值，指定搜索操作是应仅包含当前目录还是应包含所有子目录。
        ///  默认值为 System.IO.SearchOption.TopDirectoryOnly</param>
        /// <returns></returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this,
            String[] searchPatterns,
            SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x,searchOption)).Distinct();
        }
    }
}