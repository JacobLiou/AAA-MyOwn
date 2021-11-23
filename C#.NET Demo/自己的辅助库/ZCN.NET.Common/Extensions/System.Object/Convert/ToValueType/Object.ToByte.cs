using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToByte

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 byte 类型的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte ToByte(this object value)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToByte(value);
            }
            catch
            {
                return default(byte);
            }
        }

        /// <summary>将指定区域性特定格式设置信息，将指定对象的值转换为 8 位无符号整数。</summary>
        /// <param name="value">一个实现 <see cref="T:System.IConvertible" /> 接口的对象。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。</returns>
        public static byte ToByte(object value, IFormatProvider provider)
        {
            try
            {
                return Convert.ToByte(value, provider);
            }
            catch
            {
                return (byte)0;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte ToByte(this object value, byte defaultValue)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToByte(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte ToByte(this object value, Func<byte> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToByte(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToByteNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte? ToByteNullable(this object value)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToByte(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 将指定区域性特定格式设置信息，将指定对象的值转换为 8 位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// <param name="value">一个实现 <see cref="T:System.IConvertible" /> 接口的对象。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。</returns>
        public static byte? ToByteNullable(object value, IFormatProvider provider)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToByte(value, provider);
            }
            catch
            {
                return (byte)0;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte? ToByteNullable(this object value, byte defaultValue)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToByte(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static byte? ToByteNullable(this object value, Func<byte> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToByte(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

      
        #endregion

        #region ToSByte

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 byte 类型的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte ToSByte(this object value)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToSByte(value);
            }
            catch
            {
                return default(sbyte);
            }
        }

        /// <summary>
        ///  将指定区域性特定格式设置信息，将指定对象的值转换为 8 位有符号整数。
        /// </summary>
        /// <param name="value">一个实现 <see cref="T:System.IConvertible" /> 接口的对象。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。</returns>
        public static sbyte ToSByte(object value, IFormatProvider provider)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToSByte(value, provider);
            }
            catch
            {
                return (sbyte)0;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte ToSByte(this object value, sbyte defaultValue)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToSByte(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte ToSByte(this object value, Func<sbyte> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToSByte(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToSByteNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte? ToSByteNullable(this object value)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToSByte(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 将指定区域性特定格式设置信息，将指定对象的值转换为 8 位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">一个实现 <see cref="T:System.IConvertible" /> 接口的对象。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。</returns>
        public static sbyte? ToSByteNullable(object value, IFormatProvider provider)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToSByte(value, provider);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte? ToSByteNullable(this object value, sbyte defaultValue)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToSByte(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为8位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 8 位无符号整数</returns>
        public static sbyte? ToSByteNullable(this object value, Func<sbyte> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToSByte(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}