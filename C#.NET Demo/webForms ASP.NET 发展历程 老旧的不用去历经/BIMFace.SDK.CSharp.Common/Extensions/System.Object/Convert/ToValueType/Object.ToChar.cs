using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToChar

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 char 类型的默认值。
        ///  如果转换失败则返回 char 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static char ToChar(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return default(char);
            }

            try
            {
                return Convert.ToChar(@this);
            }
            catch (System.Exception)
            {
                return default(char);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 char 类型的默认值。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>true 或 false</returns>
        public static char ToChar(this object @this,char defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return defaultValue;
            }

            try
            {
                return Convert.ToChar(@this);
            }
           catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 char 类型的默认值。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>true 或 false</returns>
        public static char ToChar(this object @this,Func<char> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return defaultValueFactory();
            }

            try
            {
                return Convert.ToChar(@this);
            }
           catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToCharNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 char 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false 或null</returns>
        public static char? ToCharNullable(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToChar(@this);
            }
           catch (System.Exception)
            {
                return default(char);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>true 或 false 或null</returns>
        public static char? ToCharNullable(this object @this,char? defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToChar(@this);
            }
           catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>true 或 false 或null</returns>
        public static char? ToCharNullable(this object @this,Func<char?> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToChar(@this);
            }
           catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}