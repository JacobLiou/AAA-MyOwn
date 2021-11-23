using System;

namespace ZCN.NET.CommonX.Extensions 
{ 
    public static partial class CommonExtensions
    {
        #region Null

        /// <summary>
        ///  自定义扩展方法：判断指定的对象的值是否为 null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNull(this object @this)
        {
            return @this == null;
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象的值是否不为 null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotNull(this object @this)
        {
            return @this != null;
        }

        #endregion

        #region DBNull

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否为 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsDBNull(this object @this)
        {
            return Convert.IsDBNull(@this);
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否不为 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotDBNull(this object @this)
        {
            return Convert.IsDBNull(@this) == false;
        }

        #endregion

        #region NullOrDBNull

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否为 null 或者 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsDBNullOrNull(this object @this)
        {
            if (Convert.IsDBNull(@this) || @this == null)
                return true;

            return false;
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否不为 DBNull 且不为 null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotDBNullAndNull(this object @this)
        {
            if (Convert.IsDBNull(@this) == false && @this != null)
                return true;

            return false;
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否为 null 或者 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        internal static bool IsNullOrDBNull(this object @this)
        {
            if (@this == null || Convert.IsDBNull(@this))
                return true;

            return false;
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否不为 null 且不为 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotNullAndDBNull(this object @this)
        {
            if (@this != null && Convert.IsDBNull(@this) == false)
                return true;

            return false;
        }

        #endregion

        #region IsNullOrDBNullOrEmpty

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否为 DBNull 或者 null 或者空字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsDBNullOrNullOrEmpty(this object @this)
        {
            if (Convert.IsDBNull(@this) || @this == null)
                return true;

            if (string.IsNullOrEmpty(@this.ToString()))
                return true;

            return false;
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否不是 DBNull 且不是 null 且不是空字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotDBNullAndNullAndEmpty(this object @this)
        {
            return @this.IsDBNullOrNullOrEmpty() == false;
        }


        #endregion

        #region IsNullOrDBNullOrWhitespace

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否为 DBNull 或者 null 或者空白字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsDBNullOrNullOrWhitespace(this object @this)
        {
            if (Convert.IsDBNull(@this) || @this == null)
                return true;

            if (string.IsNullOrWhiteSpace(@this.ToString()))
                return true;

            return false;
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否不是 DBNull 且不是 null 且不是空白字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotDBNullAndNullAndWhitespace(this object @this)
        {
            return @this.IsDBNullOrNullOrWhitespace() == false;
        }


        #endregion
    }
}