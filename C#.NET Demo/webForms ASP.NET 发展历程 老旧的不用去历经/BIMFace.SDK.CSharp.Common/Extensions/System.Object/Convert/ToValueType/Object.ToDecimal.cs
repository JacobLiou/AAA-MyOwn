using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToDecimal

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 decimal 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>与 value 等效的十进制数，如果 value 为 null，则为 0（零）</returns>
        public static decimal ToDecimal(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (System.Exception)
            {
                return default(decimal);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>与 value 等效的十进制数，如果 value 为 null，则为 0（零）</returns>
        public static decimal ToDecimal(this object @this, decimal defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>与 value 等效的十进制数，如果 value 为 null，则为 0（零）</returns>
        public static decimal ToDecimal(this object @this, Func<decimal> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToDecimalNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 decimal 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>与 value 等效的十进制数 或 null</returns>
        public static decimal? ToDecimalNullable(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (System.Exception)
            {
                return default(decimal);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>与 value 等效的十进制数 或 null</returns>
        public static decimal? ToDecimalNullable(this object @this, decimal? defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>与 value 等效的十进制数 或 null</returns>
        public static decimal? ToDecimalNullable(this object @this, Func<decimal?> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}