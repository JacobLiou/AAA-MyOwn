using System;
using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：清除目录下的所有文件以及目录
        /// </summary>
        /// <param name="obj">扩展对象。目录信息</param>
        public static void Clear(this DirectoryInfo obj)
        {
            Array.ForEach(obj.GetFiles(), x => x.Delete());
            Array.ForEach(obj.GetDirectories(), x => x.Delete(true));
        }
    }
}