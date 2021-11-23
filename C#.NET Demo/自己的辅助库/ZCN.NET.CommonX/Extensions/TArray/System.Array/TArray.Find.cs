using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������������ָ��ν�ʶ��������ƥ���Ԫ�أ�Ȼ�󷵻����� System.Array �еĵ�һ��ƥ���
        ///  ����ҵ���ָ��ν�ʶ��������ƥ��ĵ�һ��Ԫ�أ���Ϊ��Ԫ�أ�����Ϊ���� T ��Ĭ��ֵ
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="array">��չ���󡣴��㿪ʼ��һά����</param>
        /// <param name="match">����Ҫ������Ԫ�ص�����</param>
        /// <returns></returns>
        public static T Find<T>(this T[] array, Predicate<T> match)
        {
            return Array.Find(array, match);
        }
    }
}