using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取此 System.IO.DirectoryInfo 实例的名称
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <returns></returns>
        public static string GetDirectoryName(this FileInfo @this)
        {
            return @this.Directory.Name;
        }
    }
}