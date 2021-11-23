using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToStringExtend

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为其等效的字符串表示形式。
        ///  如果 value 为 null 或者 DBNull，则此方法返回空字符串
        /// </summary>
        /// <param name="this"></param>
        /// <returns>等效的字符串</returns>
        public static string ToString2(this object @this)
        {
            if (@this.IsDBNullOrNull())
                return string.Empty;

            return @this.ToString();
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为其等效的字符串表示形式
        ///  如果 value 为 null 或者 DBNull，则此方法返回指定的默认值
        /// </summary>
        /// <param name="this"></param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>等效的字符串</returns>
        public static string ToString2(this object @this, string defaultValue)
        {
            if (@this.IsDBNullOrNull())
                return defaultValue;

            return @this.ToString();
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为其等效的字符串表示形式
        ///  如果 value 为 null 或者 DBNull，则此方法返回指定的默认值
        /// </summary>
        /// <param name="this"></param>
        /// <param name="defaultValueFactory">默认值(产生默认值的方法)</param>
        /// <returns>等效的字符串</returns>
        public static string ToString2(this object @this, Func<string> defaultValueFactory)
        {
            if (@this.IsDBNullOrNull())
                return defaultValueFactory();

            return @this.ToString();
        }

        #endregion
    }
}