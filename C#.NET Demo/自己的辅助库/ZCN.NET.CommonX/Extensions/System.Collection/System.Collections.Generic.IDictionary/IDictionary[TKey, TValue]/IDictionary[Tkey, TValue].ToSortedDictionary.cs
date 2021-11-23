using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ֵ�ת��Ϊ������ֶ�
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> @this)
        {
            return new SortedDictionary<TKey, TValue>(@this);
        }

        /// <summary>
        ///  �Զ�����չ���������ֵ�ת��Ϊ������ֶ�
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="comparer">�ڱȽϼ�ʱҪʹ�õ� System.Collections.Generic.IComparer`1 ʵ�֣�
        ///  ����Ϊ null����ʾΪ������ʹ��Ĭ�ϵıȽ���</param>
        /// <returns></returns>
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> @this,
            IComparer<TKey> comparer)
        {
            return new SortedDictionary<TKey, TValue>(@this, comparer);
        }
    }
}