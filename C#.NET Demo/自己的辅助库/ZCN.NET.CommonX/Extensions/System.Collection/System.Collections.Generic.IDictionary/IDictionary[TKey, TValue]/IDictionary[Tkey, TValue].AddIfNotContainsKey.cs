using System;
using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж�����ֵ��в�����ָ���ļ����򽫼���ֵ�����ֵ��в����� true �����򷵻� false
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="key">ָ���ķ������ͼ�</param>
        /// <param name="value">ָ���ķ�������ֵ</param>
        /// <returns></returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            TValue value)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(key,value);
                return true;
            }

            return false;
        }

        /// <summary>
        ///  �Զ�����չ�������ж�����ֵ��в�����ָ���ļ����򽫼���ֵ�����ֵ��в����� true �����򷵻� false
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="key">ָ���ķ������ͼ�</param>
        /// <param name="valueFactory">ָ���ķ�������ֵ(����ֵ��ί�з���)</param>
        /// <returns></returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            Func<TValue> valueFactory)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(key,valueFactory());
                return true;
            }

            return false;
        }

        /// <summary>
        ///  �Զ�����չ�������ж�����ֵ��в�����ָ���ļ����򽫼���ֵ�����ֵ��в����� true �����򷵻� false
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="key">ָ���ķ������ͼ�</param>
        /// <param name="valueFactory">ָ���ķ�������ֵ(����ֵ��ί�з���)</param>
        /// <returns></returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            Func<TKey,TValue> valueFactory)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(key,valueFactory(key));
                return true;
            }

            return false;
        }
    }
}