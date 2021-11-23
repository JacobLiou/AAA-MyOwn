using System;
using System.Collections.Generic;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������ϵ�ͬʱ��ִ��ָ���ķ���
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="action">Ҫִ�еķ���</param>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            T[] array = @this.ToArray();
            foreach(T t in array)
            {
                action(t);
            }

            return array;
        }

        /// <summary>
        ///  �Զ�����չ�������������ϵ�ͬʱ��ִ��ָ���ķ���
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="action">Ҫִ�еķ���</param>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
        {
            T[] array = @this.ToArray();

            for(int i = 0; i < array.Length; i++)
            {
                action(array[i], i);
            }

            return array;
        }
    }
}