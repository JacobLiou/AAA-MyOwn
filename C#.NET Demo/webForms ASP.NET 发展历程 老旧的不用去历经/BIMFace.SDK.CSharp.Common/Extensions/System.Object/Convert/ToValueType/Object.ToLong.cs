using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToLong

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 long 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 64位有符号整数</returns>
        public static long ToLong(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToInt64(@this);
            }
            catch (System.Exception)
            {
                return default(long);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 64位有符号整数</returns>
        public static long ToLong(this object @this, long defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToInt64(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 64位有符号整数</returns>
        public static long ToLong(this object @this, Func<long> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToInt64(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToLongNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 long 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 64位有符号整数</returns>
        public static long? ToLongNullable(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToInt64(@this);
            }
            catch (System.Exception)
            {
                return default(long);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 64位有符号整数</returns>
        public static long? ToLongNullable(this object @this, long defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToInt64(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 64位有符号整数</returns>
        public static long? ToLongNullable(this object @this, Func<long> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToInt64(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToULong

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 long 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 64位无符号整数</returns>
        public static ulong ToULong(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToUInt64(@this);
            }
            catch (System.Exception)
            {
                return default(ulong);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 64位无符号整数</returns>
        public static ulong ToULong(this object @this, ulong defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToUInt64(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 64位无符号整数</returns>
        public static ulong ToULong(this object @this, Func<ulong> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToUInt64(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToULongNullable
        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 long 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 64位无符号整数</returns>
        public static ulong? ToULongNullable(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToUInt64(@this);
            }
            catch (System.Exception)
            {
                return default(ulong);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 64位无符号整数</returns>
        public static ulong? ToULongNullable(this object @this, ulong defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToUInt64(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为64位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 64位无符号整数</returns>
        public static ulong? ToULongNullable(this object @this, Func<ulong> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToUInt64(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }
        #endregion
    }
}