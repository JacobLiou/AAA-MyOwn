using System.Collections.Generic;
using System.Dynamic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将字典转换为 ExpandoObject 对象
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static ExpandoObject ToExpandObject(this IDictionary<string,object> @this)
        {
            var expandoObject = new ExpandoObject();
            var expandoDict = (IDictionary<string,object>)expandoObject;

            foreach(var item in @this)
            {
                if(item.Value is IDictionary<string,object>)
                {
                    var d = (IDictionary<string,object>)item.Value;
                    expandoDict.Add(item.Key,d.ToExpandObject());
                }
                else
                {
                    expandoDict.Add(item);
                }
            }

            return expandoObject;
        }
    }
}