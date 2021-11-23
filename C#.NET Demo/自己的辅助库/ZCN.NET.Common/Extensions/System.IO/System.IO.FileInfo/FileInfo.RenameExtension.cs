using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：重命名文件扩展名
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="extension">新的扩展名</param>
        /// <returns></returns>
        public static void RenameExtension(this FileInfo @this, string extension)
        {
            string filePath = Path.ChangeExtension(@this.FullName, extension);
            @this.MoveTo(filePath);
        }
    }
}