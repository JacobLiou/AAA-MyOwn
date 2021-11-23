using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将文件信息对象转换为文件流。
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        public static FileStream ToFileStream(this FileInfo @this)
        {
            return new FileStream(@this.FullName, FileMode.Open, FileAccess.Read);
        }
    }
}