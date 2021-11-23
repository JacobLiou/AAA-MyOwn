using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：更改路径字符串的扩展名。
        ///  返回包含修改的路径信息的字符串。
        ///  在基于 Windows 的桌面平台上，如果 path 是 null 或空字符串 ("")，则返回的路径信息是未修改的。
        ///  如果 extension 是 null，则返回的字符串包含指定的路径，其扩展名已移除。
        ///  如果 path 不具有扩展名，并且 extension 不是 null，则返回的路径字符串包含 extension，它追加到 path 的结尾
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="extension">新的扩展名（有或没有前导句点）。指定 null 以从 path 移除现有扩展名</param>
        public static string ChangeExtension(this FileInfo @this, string extension)
        {
            return Path.ChangeExtension(@this.FullName, extension);
        }
    }
}