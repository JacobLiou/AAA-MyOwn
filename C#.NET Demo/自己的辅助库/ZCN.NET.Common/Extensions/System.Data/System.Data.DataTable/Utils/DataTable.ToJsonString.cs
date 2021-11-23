using System;
using System.Data;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        ///// <summary>
        ///// 自定义扩展方法：将 ToTable 转换为 Json 格式字符串
        ///// </summary>
        ///// <param name="dt">扩展对象</param>
        ///// <param name="dtName">表的名称,用于表示Json的名称</param>
        ///// <returns></returns>
        //[Obsolete("请使用 Object.SerializeToJson 方法")]
        //public static string ToJsonString(this DataTable dt,string dtName = "")
        //{
        //    if(dtName.IsNullOrWhiteSpace())
        //    {
        //        dtName = dt.TableName;
        //    }
        //    if(dtName.IsNullOrWhiteSpace())
        //    {
        //        dtName = DateTime.Now.ToString("yyyyMMddHHmmss");
        //    }

        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("{\"");
        //    sb.Append(dtName);
        //    sb.Append("\":[");
        //    if(dt.IsNotNullAndEmpty())
        //    {
        //        foreach(DataRow dataRow in dt.Rows)
        //        {
        //            sb.Append("{");
        //            foreach(DataColumn dataColumn in dataRow.Table.Columns)
        //            {
        //                sb.Append("\"");
        //                sb.Append(dataColumn.ColumnName);
        //                sb.Append("\":\"");
        //                if(dataRow[dataColumn].IsNotDBNullAndNullAndEmpty())
        //                {
        //                    sb.Append(dataRow[dataColumn]).Replace("\\","/");
        //                }
        //                else
        //                {
        //                    sb.Append("&nbsp;");
        //                }
        //                sb.Append("\",");
        //            }
        //            sb = sb.Remove(sb.Length - 1,1);
        //            sb.Append("},");
        //        }
        //        sb = sb.Remove(sb.Length - 1,1);
        //    }
        //    sb.Append("]}");

        //    return sb.ToString();
        //}
    }
}