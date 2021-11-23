using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ֵ�ת��Ϊ NameValueCollection ���϶���
        /// </summary>
        /// <param name="dict">��չ����</param>
        /// <returns></returns>
        public static NameValueCollection ToNameValueCollection<TKey, TValue>(this IDictionary<TKey, TValue> dict)
        {
            if (dict == null)
                return null;

            var nameValueCollection = new NameValueCollection();

            foreach (var item in dict)
            {
                string value = null;
                if (item.Value != null)
                {
                    value = item.Value.ToString();
                }

                nameValueCollection.Add(item.Key.ToString(), value);
            }

            return nameValueCollection;
        }
    }
}