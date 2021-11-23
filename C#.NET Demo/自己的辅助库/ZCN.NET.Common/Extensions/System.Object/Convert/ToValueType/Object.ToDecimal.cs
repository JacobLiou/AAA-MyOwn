using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToDecimal

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 decimal 类型的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>与 value 等效的十进制数，如果 value 为 null，则为 0（零）</returns>
        public static decimal ToDecimal(this object value)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToDecimal(value);
            }
            catch
            {
                return default(decimal);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>与 value 等效的十进制数，如果 value 为 null，则为 0（零）</returns>
        public static decimal ToDecimal(this object value, decimal defaultValue)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToDecimal(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>与 value 等效的十进制数，如果 value 为 null，则为 0（零）</returns>
        public static decimal ToDecimal(this object value, Func<decimal> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return 0;

            try
            {
                return Convert.ToDecimal(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToDecimalNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <returns>与 value 等效的十进制数 或 null</returns>
        public static decimal? ToDecimalNullable(this object value)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToDecimal(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param> 
        /// <returns>与 value 等效的十进制数 或 null</returns>
        public static decimal? ToDecimalNullable(this object value, IFormatProvider provider)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToDecimal(value, provider);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>与 value 等效的十进制数 或 null</returns>
        public static decimal? ToDecimalNullable(this object value, decimal? defaultValue)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToDecimal(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的十进制数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>与 value 等效的十进制数 或 null</returns>
        public static decimal? ToDecimalNullable(this object value, Func<decimal?> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToDecimal(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}