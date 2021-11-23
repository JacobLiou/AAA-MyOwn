using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 IDataReader 对象转换为为 DataTable
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static DataTable ToDataTable(this IDataReader @this)
        {
            var dt = new DataTable();
            dt.Load(@this);

            return dt;
        }
    }
}