using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：指示指定的路径字符串是否包含根
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsPathRooted(this FileInfo @this)
        {
            return Path.IsPathRooted(@this.FullName);
        }
    }
}