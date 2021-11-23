using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：从指定位置开始截取扩展对象实例中的字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">起始位置</param>
        /// <returns>字符串</returns>
        public static string Substring(this StringBuilder @this, int startIndex)
        {
            return @this.ToString(startIndex, @this.Length - startIndex);
        }

        /// <summary>
        /// 自定义扩展方法：从指定位置开始截取扩展对象实例中的字符串中的指定长度的字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">起始位置</param>
        /// <param name="length"></param>
        /// <returns>字符串</returns>
        public static string Substring(this StringBuilder @this, int startIndex, int length)
        {
            return @this.ToString(startIndex, length);
        }
    }
}