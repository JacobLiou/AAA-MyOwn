using System.IO;

#if NETFRAMEWORK
using System.Security.AccessControl;
#endif

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：按 path 的指定创建所有目录和子目录。返回目录信息对象
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <returns></returns>
        public static DirectoryInfo CreateDirectory(this FileInfo @this)
        {
            return Directory.CreateDirectory(@this.Directory.FullName);
        }

#if NETFRAMEWORK

        /// <summary>
        ///  自定义扩展方法：创建指定路径中的所有目录，并应用指定的 Windows 安全性
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="directorySecurity">要应用于此目录的访问控制</param>
        /// <returns></returns>
        public static DirectoryInfo CreateDirectory(this FileInfo @this,DirectorySecurity directorySecurity)
        {
            return Directory.CreateDirectory(@this.Directory.FullName,directorySecurity);
        }

#endif
    }
}