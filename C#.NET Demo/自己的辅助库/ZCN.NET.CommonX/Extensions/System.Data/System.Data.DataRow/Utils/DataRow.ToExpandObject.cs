using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������� DataRow ������ת��Ϊ ExpandoObject ����
        /// </summary>
        /// <param name="this">��չ����</param>
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