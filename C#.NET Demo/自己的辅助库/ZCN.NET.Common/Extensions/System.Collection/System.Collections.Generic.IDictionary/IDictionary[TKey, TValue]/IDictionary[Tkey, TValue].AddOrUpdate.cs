using System;
using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж�����ֵ��в�����ָ���ļ����򽫼���ֵ�����ֵ��в����ز����ط������͵�ֵ��
        ///  ���������������¼���Ӧ��ֵ�����ظ��º��ֵ
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="key">ָ���ķ������ͼ�</param>
        /// <param name="value">ָ���ķ�������ֵ</param>
        /// <returns></returns>
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey,TValue> @this,TKey key,TValue value)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey,TValue>(key,value));
            }
            else
            {
                @this[key] = value;
            }

            return @this[key];
        }

        /// <summary>
        ///  �Զ�����չ�������ж�����ֵ��в�����ָ���ļ����򽫼���ֵ�����ֵ��в����ز����ط������͵�ֵ��
        ///  ���������������¼���Ӧ��ֵ�����ظ��º��ֵ
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="key">ָ���ķ������ͼ�</param>
        /// <param name="addValue">ָ���ķ�������ֵ���������</param>
        /// <param name="updateValueFactory">ָ���ķ�������ֵ�����ڸ���</param>
        /// <returns></returns>
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            TValue addValue,
            Func<TKey,TValue,TValue> updateValueFactory)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey,TValue>(key,addValue));
            }
            else
            {
                @this[key] = updateValueFactory(key,@this[key]);
            }

            return @this[key];
        }

        /// <summary>
        ///  �Զ�����չ�������ж�����ֵ��в�����ָ���ļ����򽫼���ֵ�����ֵ��в����ز����ط������͵�ֵ��
        ///  ���������������¼���Ӧ��ֵ�����ظ��º��ֵ
        /// </summary>
        /// <typeparam name="TKey">�������ͼ�</typeparam>
        /// <typeparam name="TValue">��������ֵ</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="key">ָ���ķ������ͼ�</param>
        /// <param name="addValueFactory">ָ���ķ�������ֵ���������(����ֵ�ķ���ί��)</param>
        /// <param name="updateValueFactory">ָ���ķ�������ֵ�����ڸ���</param>
        /// <returns></returns>
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            Func<TKey,TValue> addValueFactory,
            Func<TKey,TValue,TValue> updateValueFactory)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey,TValue>(key,addValueFactory(key)));
            }
            else
            {
                @this[key] = updateValueFactory(key,@this[key]);
            }

            return @this[key];
        }
    }
}