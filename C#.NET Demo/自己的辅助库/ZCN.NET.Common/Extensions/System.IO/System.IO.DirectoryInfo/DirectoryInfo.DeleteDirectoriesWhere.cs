using System;
using System.IO;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：根据指定的条件删除当前目录下的目录。
        ///  如果此 System.IO.DirectoryInfo 为空，则删除它
        /// </summary>
        /// <param name="obj">扩展对象。目录信息对象</param>
        /// <param name="predicate">过滤条件</param>
        public static void DeleteDirectoriesWhere(this DirectoryInfo obj,Func<DirectoryInfo,bool> predicate)
        {
            obj.GetDirectories().Where(predicate).ForEach(x => x.Delete());
        }

        /// <summary>
        ///  自定义扩展方法：根据指定的条件删除目录以及子目录下的目录。
        ///  如果此 System.IO.DirectoryInfo 为空，则删除它
        /// </summary>
        /// <param name="obj">扩展对象。目录信息对象</param>
        /// <param name="predicate">过滤条件</param>
        /// <param name="searchOption">指定是搜索当前目录，还是搜索当前目录及其所有子目录</param>
        public static void DeleteDirectoriesWhere(this DirectoryInfo obj,
            Func<DirectoryInfo,bool> predicate,SearchOption searchOption)
        {
            obj.GetDirectories("*.*",searchOption).Where(predicate).ForEach(x => x.Delete());
        }
    }
}