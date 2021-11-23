using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的字符串。
        /// 返回true
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidStringValue(this object value)
        {
            return true;
        }

        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的大文本类型的字符串。
        /// 返回true
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidStringClob(this string value)
        {
            if (value.IsNullOrDBNull())
                return false;

            if (value.Equals("string", StringComparison.OrdinalIgnoreCase))
                return true;

            return Type.GetType(value) == typeof(string);
        }
    }
}