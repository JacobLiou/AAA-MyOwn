using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж��ֵ����Ƿ���������е�����һ��Ԫ�ء�
        ///  ��������һ��ʱ���� true�����򷵻�false
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="keys">ָ���ķ������ͼ�</param>
        /// <returns></returns>
        public static bool ContainsAnyKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,params TKey[] keys)
        {
            foreach(TKey value in keys)
            {
                if(@this.ContainsKey(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}