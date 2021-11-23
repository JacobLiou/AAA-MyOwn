using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 DataRow 数据行转换为 ExpandoObject 对象
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static dynamic ToExpandObject(this DataRow @this)
        {
            dynamic entity = new ExpandoObject();
            var expandoObjectDic = (IDictionary<string,object>)entity;

            foreach(DataColumn column in @this.Table.Columns)
            {
                expandoObjectDic.Add(column.ColumnName,@this[column]);
            }

            return expandoObjectDic;
        }
    }
}