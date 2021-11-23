using System;
using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：根据筛选条件，过滤掉部分数据，返回剩下数据
        /// </summary>
        /// <param name="dt">扩展对象。DataTable 实例</param>
        /// <param name="filterExpression">要用来筛选行的条件</param>
        /// <returns></returns>
        public static DataTable Select(this DataTable dt, string filterExpression)
        {
            DataTable result;
            if (dt.IsNotNullAndEmpty())
            {
                if (string.IsNullOrWhiteSpace(filterExpression))
                {
                    result = dt;
                }
                else
                {
                    DataTable newTable = dt.Clone();//复制源 DataTable 的结构到新的 DataTable 中，不包含数据行
                    DataRow[] rows = dt.Select(filterExpression);
                    foreach (DataRow row in rows)
                    {
                        newTable.ImportRow(row);
                    }
                    result = newTable;
                }
            }
            else
            {
                result = dt;
            }

            return result;
        }


        /// <summary>
        /// 自定义扩展方法：根据提供的字段名称，去除重复信息并返回新的DataTable
        /// </summary>
        /// <param name="sourceTable">DataTable实例对象</param>
        /// <param name="fieldNames">自定义字段数组，用于存储目标字段</param>
        /// <returns></returns>
        public static DataTable SelectDistinct(this DataTable sourceTable, string[] fieldNames)
        {
            if (fieldNames == null || fieldNames.Length == 0)
            {
                throw new ArgumentNullException("fieldNames");
            }

            object[] lastValues = new object[fieldNames.Length];
            DataTable newTable = sourceTable.Clone();//创建一个空的 DataTable

            //获取按照指定的排序顺序且与筛选条件相匹配的所有 System.Data.DataRow 对象的数组
            DataRow[] orderedRows = sourceTable.Select("", string.Join(",", fieldNames));
            foreach (DataRow row in orderedRows)
            {
                if (FieldValuesAreEqual(lastValues, row, fieldNames) == false)
                {
                    newTable.Rows.Add(CreateRowClone(row, newTable.NewRow(), fieldNames));
                    SetLastValues(lastValues, row, fieldNames);
                }
            }

            return newTable;
        }

        #region 辅助方法
        private static DataRow CreateRowClone(DataRow sourceRow, DataRow newRow, string[] fieldNames)
        {
            foreach (string field in fieldNames)
            {
                newRow[field] = sourceRow[field];
            }
            return newRow;
        }

        private static void SetLastValues(object[] lastValsues, DataRow sourceRow, string[] fieldNames)
        {
            for (int i = 0; i < fieldNames.Length; i++)
            {
                lastValsues[i] = sourceRow[fieldNames[i]];
            }
        }

        private static bool FieldValuesAreEqual(object[] lastValues, DataRow currentRow, string[] fieldNames)
        {
            bool areEqual = true;
            for (int i = 0; i < fieldNames.Length; i++)
            {
                if (lastValues[i] == null || !lastValues[i].Equals(currentRow[fieldNames[i]]))
                {
                    areEqual = false;
                    break;
                }
            }
            return areEqual;
        }

        #endregion
    }
}