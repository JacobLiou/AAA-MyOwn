using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：将扩展对象的值保存为一个文件
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="fileName">文件名称(包含全路径)</param>
        /// <param name="append">（可选）如果文本存在，则应将其附加到文件</param>
        public static void SaveAs(this string @this, string fileName, bool append = false)
        {
            using(TextWriter tw = new StreamWriter(fileName, append))
            {
                tw.Write(@this);
            }
        }

        /// <summary>
        ///   自定义扩展方法：将扩展对象的值保存为一个文件
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="file">文件操作对象</param>
        /// <param name="append">（可选）如果文本存在，则应将其附加到文件</param>
        public static void SaveAs(this string @this, FileInfo file, bool append = false)
        {
            using(TextWriter tw = new StreamWriter(file.FullName, append))
            {
                tw.Write(@this);
            }
        }
    }
}