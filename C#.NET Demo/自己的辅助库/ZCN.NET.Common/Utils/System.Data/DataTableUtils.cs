using System.Data;
using System.Globalization;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///  DataTable 操作工具类
    /// </summary>
    public static class DataTableUtils
    {
        /// <summary>
        ///  使用指定的表名称创建一个空的 DataTable(不包含列、行信息)
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <returns></returns>
        public static DataTable CreateDataTable(string tableName)
        {
            DataTable dt = new DataTable(tableName)
            {
                Locale = CultureInfo.InvariantCulture
            };

            return dt;
        }

        /// <summary>
        ///  使用指定的表名称与区域性信息对象创建一个空的 DataTable(不包含列、行信息)
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public static DataTable CreateDataTable(string tableName, CultureInfo cultureInfo)
        {
            DataTable dt = new DataTable(tableName)
            {
                Locale = cultureInfo
            };

            return dt;
        }
    }
}