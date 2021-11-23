using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToDateTime

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的日期时间。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 1900-01-01:00:00:00。
        ///  如果转换失败则返回 1900-01-01:00:00:00
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>等效的日期时间</returns>
        public static DateTime ToDateTime(this object value)
        {
            if (value.IsDBNullOrNull())
                return GetDefaultDatetime();

            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return GetDefaultDatetime();
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的日期时间。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 1900-01-01:00:00:00。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>等效的日期时间</returns>
        public static DateTime ToDateTime(this object value, DateTime defaultValue)
        {
            if (value.IsDBNullOrNull())
                return GetDefaultDatetime();

            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的日期时间。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 1900-01-01:00:00:00。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>等效的日期时间</returns>
        public static DateTime ToDateTime(this object value, Func<DateTime> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return GetDefaultDatetime();

            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToDateTimeNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的日期时间。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>等效的日期时间 或 null</returns>
        public static DateTime? ToDateTimeNullable(this object value)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的日期时间。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>等效的日期时间 或 null</returns>
        public static DateTime? ToDateTimeNullable(this object value, DateTime? defaultValue)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的日期时间。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>等效的日期时间 或 null</returns>
        public static DateTime? ToDateTimeNullable(this object value, Func<DateTime?> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region 辅助方法

        /// <summary>
        /// 返回默认的日期时间 1900-01-01 00:00:00
        /// </summary>
        /// <returns>日期时间 1900-01-01 00:00:00</returns>
        private static DateTime GetDefaultDatetime()
        {
            return new DateTime(1900, 1, 1, 0, 0, 0);
        }

        #endregion
    }
}