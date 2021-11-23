using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法： 获取 IDataRecord 中的列的名称集合
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static List<string> GetColumnNames(this IDataRecord @this)
        {
            return Enumerable.Range(0, @this.FieldCount)
                             .Select(@this.GetName)
                             .ToList();
        }
    }
}