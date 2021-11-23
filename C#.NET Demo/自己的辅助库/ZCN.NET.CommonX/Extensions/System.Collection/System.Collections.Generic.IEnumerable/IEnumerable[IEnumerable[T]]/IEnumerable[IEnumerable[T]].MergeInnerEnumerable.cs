using System.Collections.Generic;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�����������ϵļ��Ϻ�ת��Ϊһ������
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static IEnumerable<T> MergeInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            var list = new List<T>();
            List<IEnumerable<T>> listItem = @this.ToList();

            foreach(var item in listItem)
            {
                list.AddRange(item);
            }

            return list;
        }
    }
}