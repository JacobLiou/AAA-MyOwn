using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToShort

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 short 类型的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short ToShort(this object value)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToInt16(value);
            }
            catch
            {
                return default(short);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short ToShort(this object value, short defaultValue)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToInt16(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short ToShort(this object value, Func<short> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToInt16(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToToToShortNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short? ToShortNullable(this object value)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToInt16(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param> 
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short? ToShortNullable(this object value, IFormatProvider provider)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToInt16(value, provider);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short? ToShortNullable(this object value, short defaultValue)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToInt16(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short? ToShortNullable(this object value, Func<short> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToInt16(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToUShort

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 short 类型的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort ToUShort(this object value)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToUInt16(value);
            }
            catch
            {
                return default(ushort);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort ToUShort(this object value, ushort defaultValue)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToUInt16(value);
            }
            catch
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort ToUShort(this object value, Func<ushort> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToUInt16(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToUShortNullable
        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort? ToUShortNullable(this object value)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToUInt16(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param> 
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort? ToUShortNullable(this object value, IFormatProvider provider)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToUInt16(value, provider);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort? ToUShortNullable(this object value, ushort defaultValue)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToUInt16(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort? ToUShortNullable(this object value, Func<ushort> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToUInt16(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }
        #endregion
    }
}