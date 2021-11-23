using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取目录或文件的完整目录
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <returns></returns>
        public static string GetDirectoryFullName(this FileInfo @this)
        {
            return @this.Directory.FullName;
        }
    }
}