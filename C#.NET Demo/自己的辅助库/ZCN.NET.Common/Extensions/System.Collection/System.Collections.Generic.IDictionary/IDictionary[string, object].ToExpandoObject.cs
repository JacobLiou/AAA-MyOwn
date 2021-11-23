using System.Collections.Generic;
using System.Dynamic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ֵ�ת��Ϊ ExpandoObject ����
        /// </summary>
        /// <param name="this">��չ����</param>
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