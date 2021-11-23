using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 DataTable 分页
        /// </summary>
        /// <param name="dt">扩展对象。DataTable 数据表对象</param>
        /// <param name="pageIndex">当前页索引</param>
        /// <param name="pageSize">当前页的记录数</param>
        /// <returns></returns>
        public static DataTable Paged(this DataTable dt, int pageIndex, int pageSize)
        {
            DataTable result;
            if (pageIndex <= 0)
            {
                result = dt;
            }
            else
            {
                DataTable newTable = dt.Clone();//复制源 DataTable 的结构到新的 DataTable 中，不包含数据行

                int rowBegin = (pageIndex - 1) * pageSize;
                int rowEnd = pageIndex * pageSize;
                if (rowBegin >= dt.Rows.Count)
                {
                    result = newTable;
                }
                else
                {
                    if (rowEnd > dt.Rows.Count)
                    {
                        rowEnd = dt.Rows.Count;
                    }
                    for (int i = rowBegin; i <= rowEnd - 1; i++)
                    {
                        DataRow newRow = newTable.NewRow();
                        DataRow dr = dt.Rows[i];
                        foreach (DataColumn column in dt.Columns)
                        {
                            newRow[column.ColumnName] = dr[column.ColumnName];
                        }
                        newTable.Rows.Add(newRow);
                    }
                    result = newTable;
                }
            }

            return result;
        }
    }
}