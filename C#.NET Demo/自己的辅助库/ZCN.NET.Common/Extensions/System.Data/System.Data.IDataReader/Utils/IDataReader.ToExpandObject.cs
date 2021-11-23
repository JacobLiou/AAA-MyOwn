using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� IDataReader ����ת��Ϊһ�� ExpandoObject ����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static dynamic ToExpandObject(this IDataReader @this)
        {
            Dictionary<int, KeyValuePair<int, string>> columnNames = 
                Enumerable.Range(0, @this.FieldCount)
                          .Select(x => new KeyValuePair<int, string>(x, @this.GetName(x)))
                          .ToDictionary(pair => pair.Key);

            dynamic entity = new ExpandoObject();
            var expandoDict = (IDictionary<string, object>) entity;

            Enumerable.Range(0, @this.FieldCount)
                      .ToList()
                      .ForEach(x => expandoDict.Add(columnNames[x].Value, @this[x]));

            return entity;
        }

        /// <summary>
        ///  �Զ�����չ�������� IDataReader ����ת��Ϊ ExpandoObject ���󼯺�
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static IEnumerable<dynamic> ToExpandObjectList(this IDataReader @this)
        {
            Dictionary<int, KeyValuePair<int, string>> columnNames =
                Enumerable.Range(0, @this.FieldCount)
                          .Select(x => new KeyValuePair<int, string>(x, @this.GetName(x)))
                          .ToDictionary(pair => pair.Key);

            var list = new List<dynamic>();

            while (@this.Read())
            {
                dynamic entity = new ExpandoObject();
                var expandoDict = (IDictionary<string, object>)entity;

                Enumerable.Range(0, @this.FieldCount)
                          .ToList()
                          .ForEach(x => expandoDict.Add(columnNames[x].Value, @this[x]));

                list.Add(entity);
            }

            return list;
        }
    }
}