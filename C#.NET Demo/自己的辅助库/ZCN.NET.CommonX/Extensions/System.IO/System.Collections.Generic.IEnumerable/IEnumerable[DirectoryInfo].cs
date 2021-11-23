using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：如果集合中的 DirectoryInfo 为空，则删除该目录
        /// </summary>
        /// <param name="this"></param>
        public static void Delete(this IEnumerable<DirectoryInfo> @this)
        {
            foreach (DirectoryInfo t in @this)
            {
                t.Delete();
            }
        }

        /// <summary>
        ///   自定义扩展方法：循环目录集合，并执行指定的方法
        /// </summary>
        /// <param name="this"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static IEnumerable<DirectoryInfo> ForEach(this IEnumerable<DirectoryInfo> @this, Action<DirectoryInfo> action)
        {
            var directoryInfos = @this as DirectoryInfo[] ?? @this.ToArray();
            foreach (DirectoryInfo t in directoryInfos)
            {
                action(t);
            }

            return directoryInfos;
        }
    }
}