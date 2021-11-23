using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж��ֵ����Ƿ���������е�����Ԫ�ء�
        ///  ȫ������ʱ���� true�����򷵻�false
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="keys">������������</param>
        /// <returns></returns>
        public static bool ContainsAllKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,params TKey[] keys)
        {
            foreach(TKey value in keys)
            {
                if(!@this.ContainsKey(value))
                {
                    return false;
                }
            }

            return true;
        }
    }
}