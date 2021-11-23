using System;
using System.Data;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 DataRow 数据行转换为 Json 格式字符串
        /// </summary>
        /// <param name="dataRow">扩展对象</param>
        /// <returns></returns>
        public static string ToJsonString(this DataRow dataRow)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            foreach(DataColumn dc in dataRow.Table.Columns)
            {
                sb.Append("\"");
                sb.Append(dc.ColumnName);
                sb.Append("\":\"");
                if(dataRow[dc] != null && dataRow[dc] != DBNull.Value && dataRow[dc].ToString() != "")
                {
                    sb.Append(dataRow[dc]);
                }
                else
                {
                    sb.Append("&nbsp;");
                }
                sb.Append("\",");
            }
            sb = sb.Remove(0,sb.Length - 1);
            sb.Append("},");
            return sb.ToString();
        }
    }
}