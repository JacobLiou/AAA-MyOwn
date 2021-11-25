using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToInt32

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 int 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 32位有符号整数</returns>
        public static int ToInt32(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToInt32(@this);
            }
            catch (System.Exception)
            {
                return default(int);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 32位有符号整数</returns>
        public static int ToInt32(this object @this, int defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToInt32(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 32位有符号整数</returns>
        public static int ToInt32(this object @this, Func<int> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToInt32(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToToInt32Nullable

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 int 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 32位有符号整数</returns>
        public static int? ToInt32Nullable(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToInt32(@this);
            }
            catch (System.Exception)
            {
                return default(int);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 32位有符号整数</returns>
        public static int? ToInt32Nullable(this object @this, int defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToInt32(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 32位有符号整数</returns>
        public static int? ToInt32Nullable(this object @this, Func<int> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToInt32(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToUInt32

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 int 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 32位无符号整数</returns>
        public static uint ToUInt32(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToUInt32(@this);
            }
            catch (System.Exception)
            {
                return default(uint);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 32位无符号整数</returns>
        public static uint ToUInt32(this object @this, uint defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToUInt32(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 32位无符号整数</returns>
        public static uint ToUInt32(this object @this, Func<uint> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToUInt32(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToUInt32Nullable
        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 int 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 32位无符号整数</returns>
        public static uint? ToUInt32Nullable(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToUInt32(@this);
            }
            catch (System.Exception)
            {
                return default(uint);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 32位无符号整数</returns>
        public static uint? ToUInt32Nullable(this object @this, uint defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToUInt32(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为32位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 32位无符号整数</returns>
        public static uint? ToUInt32Nullable(this object @this, Func<uint> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToUInt32(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }
        #endregion
    }
}