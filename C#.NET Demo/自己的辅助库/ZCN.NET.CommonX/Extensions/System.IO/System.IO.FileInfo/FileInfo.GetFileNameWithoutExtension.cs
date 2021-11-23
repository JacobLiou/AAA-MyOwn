using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回不具有扩展名的指定路径字符串的文件名
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <returns></returns>
        public static string GetFileNameWithoutExtension(this FileInfo @this)
        {
            return Path.GetFileNameWithoutExtension(@this.FullName);
        }
    }
}