namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的64位有符号的整数值。
        /// 如果参数 为 null，则此方法返回 false
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidLongValue(this object value)
        {
            return long.TryParse(value?.ToString(), out long result);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的64位有符号的整数值。
        /// 如果参数 为 null，则此方法返回 true
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidLongValueNullable(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return long.TryParse(value.ToString(),out long result);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的64位无符号的整数值。
        /// 如果参数 为 null，则此方法返回 false
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidULongValue(this object value)
        {
            return ulong.TryParse(value?.ToString(),out ulong result);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的64位无符号的整数值。
        /// 如果参数 为 null，则此方法返回 true
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidULongValueNullable(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return ulong.TryParse(value.ToString(),out ulong result);
        }
    }
}