using System;
using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ֵ��в�����ָ���ļ��򽫼�ֵ���뼯���У����ؼ���Ӧ��ֵ
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="key">ָ���ķ������ͼ�</param>
        /// <param name="value">ָ���ķ�������ֵ</param>
        /// <returns></returns>
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey,TValue> @this,TKey key,TValue value)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey,TValue>(key,value));
            }

            return @this[key];
        }

        /// <summary>
        /// �Զ�����չ����������ֵ��в�����ָ���ļ��򽫼�ֵ���뼯���У����ؼ���Ӧ��ֵ
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="key">ָ���ķ������ͼ�</param>
        /// <param name="valueFactory">ָ���ķ�������ֵ(����ֵ�ķ��ͷ���)</param>
        /// <returns></returns>
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            Func<TKey,TValue> valueFactory)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey,TValue>(key,valueFactory(key)));
            }

            return @this[key];
        }
    }
}