using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ȷ�������е�ÿ��Ԫ���Ƿ���ָ��ν�ʶ��������ƥ�䡣
        /// 
        /// ��� array �е�ÿ��Ԫ�ض���ָ��ν�ʶ��������ƥ�䣬��Ϊ true������Ϊ false��
        /// ���������û��Ԫ�أ��򷵻�ֵΪ true
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="array">��չ���󡣴��㿪ʼ��һά����</param>
        /// <param name="match">������Ԫ��ʱҪ���յ�����</param>
        /// <returns></returns>
        public static bool TrueForAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.TrueForAll(array, match);
        }
    }
}