namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的 decimal 类型值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidDecimalValue(this object value)
        {
            return decimal.TryParse(value?.ToString(), out decimal result);
        }

        /// <summary>
        /// 自定义扩展方法：判断指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值是否是有效的 decimal 类型值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidDecimalValueNullable(this object value)
        {
            if (value.IsNullOrDBNull())
                return true;

            return decimal.TryParse(value.ToString(), out decimal result);
        }
    }
}