
namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region IsEmpty

        /// <summary>
        /// 自定义扩展方法：判断字符串是否不为 null 且长度等于0
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsEmpty(this string @this)
        {
            return @this != null && @this == "";
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串是否不为 null 且长度大于0。
        /// 该方法与 String.IsNotNullAndEmpty()方法功能一样
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotEmpty(this string @this)
        {
            return !string.IsNullOrEmpty(@this);
        }

        #endregion
    }
}