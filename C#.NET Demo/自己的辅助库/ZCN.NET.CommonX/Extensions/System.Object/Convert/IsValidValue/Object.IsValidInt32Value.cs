namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的32位有符号的整数值。
        ///  如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidInt32Value(this object value)
        {
            return int.TryParse(value?.ToString(), out int result);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的32位有符号的整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidInt32NullableValue(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return int.TryParse(value.ToString(), out int result);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的32位无符号的整数值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidUInt32Value(this object value)
        {
            return uint.TryParse(value?.ToString(), out uint result);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的32位无符号的整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidUInt32NullableValue(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return uint.TryParse(value.ToString(), out uint result);
        }
    }
}