using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToByte

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 byte 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte ToByte(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToByte(@this);
            }
            catch (System.Exception)
            {
                return default(byte);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte ToByte(this object @this, byte defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToByte(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte ToByte(this object @this, Func<byte> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToByte(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToByteNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 byte 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte? ToByteNullable(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToByte(@this);
            }
            catch (System.Exception)
            {
                return default(byte);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte? ToByteNullable(this object @this, byte defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToByte(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte? ToByteNullable(this object @this, Func<byte> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToByte(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToSByte

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 byte 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte ToSByte(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToSByte(@this);
            }
            catch (System.Exception)
            {
                return default(sbyte);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte ToSByte(this object @this, sbyte defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToSByte(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte ToSByte(this object @this, Func<sbyte> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToSByte(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToSByteNullable
        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 byte 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte? ToSByteNullable(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToSByte(@this);
            }
            catch (System.Exception)
            {
                return default(sbyte);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte? ToSByteNullable(this object @this, sbyte defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToSByte(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte? ToSByteNullable(this object @this, Func<sbyte> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToSByte(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }
        #endregion
    }
}