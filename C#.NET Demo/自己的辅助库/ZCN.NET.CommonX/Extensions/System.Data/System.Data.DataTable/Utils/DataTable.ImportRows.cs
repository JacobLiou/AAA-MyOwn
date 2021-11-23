using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 DataRow 数据行数组对象复制到 DataTable 中，保留任何属性设置以及初始值和当前值
        /// </summary>
        /// <param name="dt">扩展对象</param>
        /// <param name="rows">需要导入的数据行数组</param>
        /// <returns></returns>
        public static DataTable ImportRows(this DataTable dt,DataRow [] rows)
        {
            foreach(DataRow row in rows)
            {
                dt.ImportRow(row);
            }

            return dt;
        }
    }
}