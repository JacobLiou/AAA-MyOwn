using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�����������������е�Ԫ�ؼ��뼯����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="values">��������</param>
        public static void AddRange<T>(this ICollection<T> @this, params T[] values)
        {
            foreach(T value in values)
            {
                @this.Add(value);
            }
        }
    }
}