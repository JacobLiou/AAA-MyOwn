using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������������ָ��ν�ʶ��������ƥ�������Ԫ�ء�
        /// ����ҵ�һ����������Ԫ�ؾ���ָ��ν�ʶ��������ƥ��� System.Array����Ϊ�����飻����Ϊһ���� System.Array
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="array">��չ���󡣴��㿪ʼ��һά����</param>
        /// <param name="match">����Ҫ������Ԫ�ص�����</param>
        /// <returns></returns>
        public static T[] FindAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindAll(array, match);
        }
    }
}