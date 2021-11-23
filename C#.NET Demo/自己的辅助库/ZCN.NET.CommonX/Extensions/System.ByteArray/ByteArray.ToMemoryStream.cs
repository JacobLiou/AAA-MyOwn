using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 8 位无符号整数的数组转换为 MemoryStream 内存流对象
        /// </summary>
        /// <param name="this">扩展对象。8位无符号整数的数组</param>
        /// <returns></returns>
        public static MemoryStream ToMemoryStream(this byte[] @this)
        {
            return new MemoryStream(@this);
        }
    }
}