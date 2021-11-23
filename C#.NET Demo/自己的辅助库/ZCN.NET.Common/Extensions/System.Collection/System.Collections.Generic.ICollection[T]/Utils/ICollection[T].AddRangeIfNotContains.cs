using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж���������в����������е�Ԫ����Ԫ�ؼ��뼯����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="values">��������</param>
        public static void AddRangeIfNotContains<T>(this ICollection<T> @this,params T[] values)
        {
            foreach(T value in values)
            {
                if(!@this.Contains(value))
                {
                    @this.Add(value);
                }
            }
        }
    }
}