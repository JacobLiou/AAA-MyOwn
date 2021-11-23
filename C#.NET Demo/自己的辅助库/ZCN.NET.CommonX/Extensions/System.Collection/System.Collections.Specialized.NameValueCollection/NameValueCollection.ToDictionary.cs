using System.Collections.Generic;
using System.Collections.Specialized;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� NameValueCollection ����ת��Ϊ�ֵ� 
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static IDictionary<string, object> ToDictionary(this NameValueCollection @this)
        {
            var dict = new Dictionary<string, object>();

            if(@this != null)
            {
                foreach(string key in @this.AllKeys)
                {
                    dict.Add(key, @this[key]);
                }
            }

            return dict;
        }
    }
}