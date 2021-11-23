using System;
using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取指定路径的根目录信息
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <returns></returns>
        public static String GetPathRoot(this FileInfo @this)
        {
            return Path.GetPathRoot(@this.FullName);
        }
    }
}