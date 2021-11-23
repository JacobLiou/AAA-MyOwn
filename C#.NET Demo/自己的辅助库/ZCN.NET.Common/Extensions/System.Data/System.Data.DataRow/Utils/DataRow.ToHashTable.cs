using System.Collections;
using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 DataRow 数据行对象转换为 Hashtable 对象(列名作为键，列值作为值)
        /// </summary>
        /// <param name="dr">扩展对象。DataRow 数据行对象</param>
        /// <returns></returns>
        public static Hashtable ToHashTable(this DataRow dr)
        {
            Hashtable ht = Hashtable.Synchronized(new Hashtable(dr.ItemArray.Length));
            foreach(DataColumn column in dr.Table.Columns)
            {
                ht.Add(column.ColumnName,dr[column.ColumnName]);
            }

            return ht;
        }
    }
}