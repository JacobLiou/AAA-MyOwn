using System.IO;

#if NETFRAMEWORK
using System.Security.AccessControl;
#endif

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：按 path 的指定创建所有目录和子目录
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <returns></returns>
        public static DirectoryInfo CreateAllDirectories(this DirectoryInfo @this)
        {
            return Directory.CreateDirectory(@this.FullName);
        }

#if NETFRAMEWORK

        /// <summary>
        ///  自定义扩展方法：创建指定路径中的所有目录，并应用指定的 Windows 安全性
        /// </summary>
        /// <param name="this">扩展对象。目录信息对象</param>
        /// <param name="directorySecurity">要应用于此目录的访问控制</param>
        /// <returns></returns>
        public static DirectoryInfo CreateAllDirectories(this DirectoryInfo @this,DirectorySecurity directorySecurity)
        {
            return Directory.CreateDirectory(@this.FullName,directorySecurity);
        }

#endif

    }
}