using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：根据数组中提供的列，从源数据行中映射到新数据行
        /// </summary>
        /// <param name="sourceRow">扩展对象。源数据行</param>
        /// <param name="newRow">扩展对象。目标数据行</param>
        /// <param name="fieldNames">要映射到新数据行中的列的名称(列名称如果不存在于源数据行的列中则被忽略)</param>
        /// <returns></returns>
        private static DataRow ToNewDataRow(this DataRow sourceRow, DataRow newRow, string[] fieldNames)
        {
            foreach (string fieldName in fieldNames)
            {
                if (sourceRow.Table.Columns.Contains(fieldName))
                {
                    newRow[fieldName] = sourceRow[fieldName];
                }
            }

            return newRow;
        }
    }
}