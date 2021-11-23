using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：批量删除集合中的文件信息
        /// </summary>
        /// <param name="this">扩展对象。文件信息集合</param>
        public static void Delete(this IEnumerable<FileInfo> @this)
        {
            foreach (FileInfo t in @this)
            {
                t.Delete();
            }
        }

        /// <summary>
        ///  自定义扩展方法：循环将文件信息集合中的对象作为参数传入指定的方法中并执行方法，最后返回文件信息集合
        /// </summary>
        /// <param name="this">扩展对象。文件信息集合</param>
        /// <param name="action"></param>
        public static IEnumerable<FileInfo> ForEach(this IEnumerable<FileInfo> @this, Action<FileInfo> action)
        {
            var fileInfos = @this as FileInfo[] ?? @this.ToArray();
            foreach (FileInfo t in fileInfos)
            {
                action(t);
            }
            return fileInfos;
        }
    }
}