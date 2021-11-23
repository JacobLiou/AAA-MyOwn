using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断 IDataReader 数据行中的字段列是否为 DBNull
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static bool IsDBNull(this IDataReader @this, string columnName)
        {
            return @this.IsDBNull(@this.GetOrdinal(columnName));
        }
    }
}