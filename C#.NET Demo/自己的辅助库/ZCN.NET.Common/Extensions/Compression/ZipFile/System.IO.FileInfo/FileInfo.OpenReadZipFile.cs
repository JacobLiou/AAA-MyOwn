#if NET45 || NETSTANDARD

using System.IO;
using System.IO.Compression;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {

        /// <summary>
        ///  自定义扩展方法：打开在指定路径用于读取的 zip 存档
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static ZipArchive OpenReadZipFile(this FileInfo @this)
        {
            return ZipFile.OpenRead(@this.FullName);
        }
    }
}

#endif