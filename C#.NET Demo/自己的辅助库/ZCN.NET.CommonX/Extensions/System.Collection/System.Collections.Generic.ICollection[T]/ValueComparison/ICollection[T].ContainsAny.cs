using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������жϼ������Ƿ���������е�����һ��Ԫ�ء�
        ///  ��������һ��ʱ���� true�����򷵻�false
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ���󡣷��ͼ���</param>
        /// <param name="values">��������</param>
        /// <returns></returns>
        public static bool ContainsAny<T>(this ICollection<T> @this, params T[] values)
        {
            foreach(T value in values)
            {
                if(@this.Contains(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}