using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж���������а��������е�Ԫ����Ԫ�شӼ������Ƴ�
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="values">��������</param>
        public static void RemoveRangeIfContains<T>(this ICollection<T> @this,params T[] values)
        {
            foreach(T value in values)
            {
                if(@this.Contains(value))
                {
                    @this.Remove(value);
                }
            }
        }
    }
}