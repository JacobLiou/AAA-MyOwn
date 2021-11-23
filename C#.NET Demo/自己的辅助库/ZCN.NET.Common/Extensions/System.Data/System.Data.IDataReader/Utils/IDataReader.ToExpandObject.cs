using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 IDataReader 对象转换为一个 ExpandoObject 对象
        /// </summary>
        /// <param name="this">扩展对象</param>
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
        ///  自定义扩展方法：将 IDataReader 对象转换为 ExpandoObject 对象集合
        /// </summary>
        /// <param name="this">扩展对象</param>
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