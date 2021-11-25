using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
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
        public static bool IsDbNull(this object @this)
        {
            return Convert.IsDBNull(@this);
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否不为 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotDbNull(this object @this)
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
        public static bool IsNullOrDbNull(this object @this)
        {
            if (@this == null || Convert.IsDBNull(@this))
            {
                return true;
            }

            return false;
        }


        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否为 null 或者 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsDbNullOrNull(this object @this)
        {
            if (Convert.IsDBNull(@this) || @this == null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否不为 null 且不为 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotDbNullAndNull(this object @this)
        {
            if (@this != null && Convert.IsDBNull(@this) == false)
            {
                return true;
            }

            return false;
        }


        #endregion

        #region IsNullOrDBNullOrEmpty

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否为 null 或者空字符串 或者 DBNull 
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsDbNullOrNullOrEmpty(this object @this)
        {
            if (Convert.IsDBNull(@this) || @this == null)
            {
                return true;
            }

            if (@this.ToString() == "")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否不是 null 且不是空字符串 且不是 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotDbNullAndNullAndEmpty(this object @this)
        {
            return @this.IsDbNullOrNullOrEmpty() == false;
        }


        #endregion

        #region IsNullOrDBNullOrWhitespace

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否为 null 或者空白字符串  或者 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsDbNullOrNullOrWhitespace(this object @this)
        {
            if (Convert.IsDBNull(@this) || @this == null)
            {
                return true;
            }

            if (@this.ToString().Trim() == "")//去除所有空格之后 等于 ""
            {
                return true;
            }

            return false;
        }

        /// <summary>
        ///  自定义扩展方法：判断指定的对象(.Net中基本数据类型对象)的值是否不是 null  且不是空白字符串 且不是 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotDbNullAndNullAndWhitespace(this object @this)
        {
            return @this.IsDbNullOrNullOrWhitespace() == false;
        }


        #endregion
    }
}