using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：重命名文件，保持原来的扩展名
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="newName">新的名称(不含文件扩展名)</param>
        /// <returns></returns>
        public static void RenameFileWithoutExtension(this FileInfo @this, string newName)
        {
            string fileName = string.Concat(newName, @this.Extension);
            string filePath = Path.Combine(@this.Directory.FullName, fileName);
            @this.MoveTo(filePath);
        }
    }
}