using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������� DataTable ������ת��Ϊ ExpandoObject ���󼯺�
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static IEnumerable<dynamic> ToExpandObjectList(this DataTable @this)
        {
            var list = new List<dynamic>();

            foreach(DataRow dr in @this.Rows)
            {
                dynamic entity = new ExpandoObject();
                var expandoDict = (IDictionary<string,object>)entity;

                foreach(DataColumn column in @this.Columns)
                {
                    expandoDict.Add(column.ColumnName,dr[column]);
                }

                list.Add(entity);
            }

            return list;
        }
    }
}