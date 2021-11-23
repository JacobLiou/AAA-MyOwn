using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：重命名文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="newName">新的名称</param>
        /// <returns></returns>
        public static void Rename(this FileInfo @this, string newName)
        {
            string filePath = Path.Combine(@this.Directory.FullName, newName);
            @this.MoveTo(filePath);
        }
    }
}