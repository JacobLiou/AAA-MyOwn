namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region IsNullOrEmpty

        /// <summary>
        ///  自定义扩展方法：判断字符串是否为 null 或者空字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string @this)
        {
            return string.IsNullOrEmpty(@this);
        }

        /// <summary>
        ///  自定义扩展方法：判断字符串是否不为 null 且不为空字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotNullAndEmpty(this string @this)
        {
            return string.IsNullOrEmpty(@this) == false;
        }

        #endregion

        #region IsNullOrWhiteSpace

        /// <summary>
        ///  自定义扩展方法：判断字符串是否不为 null 且是空白字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsWhitespace(this string @this)
        {
            return !string.IsNullOrEmpty(@this) && @this.Trim().Length == 0;
        }

        /// <summary>
        ///  自定义扩展方法：判断字符串是否为 null 、空字符串或者空白字符串
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        ///  自定义扩展方法：判断字符串是否不为 null、空字符串、空白字符串
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotNullAndWhiteSpace(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        #endregion
    }
}