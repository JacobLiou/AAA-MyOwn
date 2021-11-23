using System;
using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {

        /// <summary>
        ///  �Զ�����չ������ѭ�������������е�Ԫ����Ϊ�������뷺��ί���в�ִ�У����ִ�н��Ϊ true �򽫸�Ԫ�ؼ��뼯����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="predicate">����ί��</param>
        /// <param name="values">��������</param>
        /// <returns></returns>
        public static void AddRangeIf<T>(this ICollection<T> @this,Func<T,bool> predicate,params T[] values)
        {
            foreach(T value in values)
            {
                if(predicate(value))
                {
                    @this.Add(value);
                }
            }
        }
    }
}