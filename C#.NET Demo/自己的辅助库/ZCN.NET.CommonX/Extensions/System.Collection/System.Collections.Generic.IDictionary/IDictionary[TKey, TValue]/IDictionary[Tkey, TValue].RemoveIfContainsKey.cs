using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ֵ��а���ָ���ļ�����ֵ����Ƴ��ü�ֵ��
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="key">ָ���ķ������ͼ�</param>
        public static void RemoveIfContainsKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,TKey key)
        {
            if(@this.ContainsKey(key))
            {
                @this.Remove(key);
            }
        }
    }
}