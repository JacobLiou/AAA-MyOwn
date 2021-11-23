using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToChar

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 char 类型的默认值。
        ///  如果转换失败则返回 char 类型的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static char ToChar(this object value)
        {
            if (value.IsDBNullOrNull())
                return default(char);

            try
            {
                return Convert.ToChar(value);
            }
            catch
            {
                return default(char);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 char 类型的默认值。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>true 或 false</returns>
        public static char ToChar(this object value, char defaultValue)
        {
            if (value.IsDBNullOrNull())
                return defaultValue;

            try
            {
                return Convert.ToChar(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 char 类型的默认值。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>true 或 false</returns>
        public static char ToChar(this object value, Func<char> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return defaultValueFactory();

            try
            {
                return Convert.ToChar(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 char 类型的默认值。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns></returns>
        public static char ToChar(this object value, IFormatProvider provider)
        {
            try
            {
                return Convert.ToChar(value, provider);
            }
            catch
            {
                return default(char);
            }
        }

        #endregion

        #region ToCharNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false 或null</returns>
        public static char? ToCharNullable(this object value)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToChar(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>true 或 false 或null</returns>
        public static char? ToCharNullable(this object value, char? defaultValue)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToChar(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>true 或 false 或null</returns>
        public static char? ToCharNullable(this object value, Func<char?> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToChar(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的 Unicode 字符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 char 类型的默认值。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns></returns>
        public static char? ToCharNullable(this object value, IFormatProvider provider)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToChar(value, provider);
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}