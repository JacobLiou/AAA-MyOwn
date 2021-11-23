using System.Collections.Generic;
using System.Linq;

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
        public static bool ContainsAny<T>(this IEnumerable<T> @this, params T[] values)
        {
            T[] list = @this.ToArray();
            foreach(T value in values)
            {
                if(list.Contains(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}