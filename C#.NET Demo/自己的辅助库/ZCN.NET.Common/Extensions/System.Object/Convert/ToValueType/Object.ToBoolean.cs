using System;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToBoolean

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的布尔值。
        ///  如果参数为 null 或者 DBNull，则此方法返回 false。
        ///  如果转换失败则返回 bool 类型的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool ToBoolean(this object value)
        {
            bool.TryParse(value?.ToString(), out bool result);
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将一个值转换为bool类型。
        ///  <para>以下特殊内容(不区分大小写)均可以正常转换："是", "否", "YES", "NO", "Y", "N", "ON", "OFF", "1", "0" </para>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ToBooleanExtend(this object value)
        {
            bool result = false;

            if (value.IsNotDBNullAndNull())
            {
                bool.TryParse(value.ToString2(), out result);

                if (result == false)
                {
                    string temp = value.ToString().ToUpper();
                    string[] arrBool = { "是", "否", "YES", "NO", "Y", "N", "ON", "OFF", "1", "0" };

                    if (arrBool.Contains(temp))
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的布尔值。
        ///  如果参数为 null 或者 DBNull，则此方法返回 false。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>true 或 false</returns>
        public static bool ToBoolean(this object value, bool defaultValue)
        {
            if (value.IsDBNullOrNull())
                return false;

            try
            {
                return Convert.ToBoolean(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的布尔值。
        ///  如果参数为 null 或者 DBNull，则此方法返回 false。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>true 或 false</returns>
        public static bool ToBoolean(this object value, Func<bool> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return false;

            try
            {
                return Convert.ToBoolean(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的布尔值。
        ///  如果参数为 null 或者 DBNull，则此方法返回 false。
        ///  如果转换失败则返回 bool 类型的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns>true 或 false</returns>
        public static bool ToBoolean(this object value, IFormatProvider provider)
        {
            try
            {
                return Convert.ToBoolean(value, provider); 
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region ToBooleanNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的布尔值。
        ///  如果参数为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false 或 null</returns>
        public static bool? ToBooleanNullable(this object value)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToBoolean(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的布尔值。
        ///  如果参数为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>true 或 false 或 null</returns>
        public static bool? ToBooleanNullable(this object value, bool? defaultValue)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToBoolean(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的布尔值。
        ///  如果参数为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>true 或 false 或 null</returns>
        public static bool? ToBooleanNullable(this object value, Func<bool?> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToBoolean(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的布尔值。
        ///  如果参数为 null 或者 DBNull，则此方法返回 false。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns>true 或 false</returns>
        public static bool? ToBooleanNullable(this object value, IFormatProvider provider)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToBoolean(value, provider);
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}