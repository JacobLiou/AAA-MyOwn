using System;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：根据指定的条件删除当前目录下的文件
        /// </summary>
        /// <param name="obj">扩展对象。目录信息对象</param>
        /// <param name="predicate">过滤条件</param>
        public static void DeleteFilesWhere(this DirectoryInfo obj,Func<FileInfo,bool> predicate)
        {
            obj.GetFiles().Where(predicate).ForEach(x => x.Delete());
        }

        /// <summary>
        ///  自定义扩展方法：根据指定的条件删除目录以及子目录下的文件
        /// </summary>
        /// <param name="obj">扩展对象。目录信息对象</param>
        /// <param name="predicate">过滤条件</param>
        /// <param name="searchOption">指定是搜索当前目录，还是搜索当前目录及其所有子目录</param>
        public static void DeleteFilesWhere(this DirectoryInfo obj,
            Func<FileInfo,bool> predicate,SearchOption searchOption)
        {
            obj.GetFiles("*.*",searchOption).Where(predicate).ForEach(x => x.Delete());
        }
    }
}