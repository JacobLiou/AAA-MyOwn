using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断 DataRow 数据行中的所有列的数据值是否都是空值或者 DBNull
        /// </summary>
        /// <param name="dr">扩展对象。DataRow 数据行对象</param>
        /// <returns></returns>
        public static bool IsEmpty(this DataRow dr)
        {
            DataTable dt = dr.Table;
            foreach(DataColumn column in dt.Columns)
            {
                if(dr[column.ColumnName].IsDBNullOrNullOrEmpty())
                {
                    return false;
                }
            }
            
            return true;
        }

        /// <summary>
        /// 自定义扩展方法：判断 DataRow 数据行中是否一部分列中有数值，不是所有列的数据值都是空值或者 DBNull
        /// </summary>
        /// <param name="dr">扩展对象。DataRow 数据行对象</param>
        /// <returns></returns>
        public static bool IsNotEmpty(this DataRow dr)
        {
            DataTable dt = dr.Table;
            foreach(DataColumn column in dt.Columns)
            {
                if(dr[column.ColumnName].IsNotDBNullAndNullAndEmpty())
                {
                    return true;
                }
            }

            return false;
        }
    }
}