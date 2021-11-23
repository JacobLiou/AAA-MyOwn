using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断 IDataReader 数据行中是否包含指定列的索引
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="columnIndex">指定列的索引</param>
        /// <returns></returns>
        public static bool ContainsColumn(this IDataReader @this, int columnIndex)
        {
            try
            {
                return @this.FieldCount > columnIndex;
            }
            catch
            {
                try
                {
                    return @this[columnIndex] != null;
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        ///  自定义扩展方法：判断 IDataReader 数据行中是否包含指定列
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static bool ContainsColumn(this IDataReader @this, string columnName)
        {
            try
            {
                return @this.GetOrdinal(columnName) != -1;
            }
            catch
            {
                try
                {
                    return @this[columnName] != null;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}