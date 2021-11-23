using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������������ָ��ν�ʶ��������ƥ���Ԫ�أ�Ȼ�󷵻����� System.Array �����һ��ƥ����Ĵ��㿪ʼ��������
        /// ����ҵ��� match �����������ƥ������һ��Ԫ�أ���Ϊ��Ԫ�صĴ��㿪ʼ������������Ϊ -1
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="array">��չ���󡣴��㿪ʼ��һά����</param>
        /// <param name="match">����Ҫ������Ԫ�ص�����</param>
        /// <returns></returns>
        public static int FindLastIndex<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindLastIndex(array, match);
        }

        /// <summary>
        /// �Զ�����չ������������ָ��ν�ʶ��������ƥ���Ԫ�أ�Ȼ�󷵻� System.Array �д�ָ�����������һ��Ԫ�ص�Ԫ�ط�Χ��
        /// ���һ��ƥ����Ĵ��㿪ʼ��������
        /// ����ҵ��� match �����������ƥ������һ��Ԫ�أ���Ϊ��Ԫ�صĴ��㿪ʼ������������Ϊ -1
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="array">��չ���󡣴��㿪ʼ��һά����</param>
        /// <param name="startIndex">���㿪ʼ����������ʼ����</param>
        /// <param name="match">����Ҫ������Ԫ�ص�����</param>
        /// <returns></returns>
        public static int FindLastIndex<T>(this T[] array, int startIndex, Predicate<T> match)
        {
            return Array.FindLastIndex(array, startIndex, match);
        }

        /// <summary>
        /// �Զ�����չ������������ָ��ν�ʶ��������ƥ���Ԫ�أ�Ȼ�󷵻� System.Array �д�ָ��������ʼ������ָ��Ԫ�ظ�����Ԫ�ط�Χ��
        /// ���һ��ƥ����Ĵ��㿪ʼ��������
        /// ����ҵ��� match �����������ƥ������һ��Ԫ�أ���Ϊ��Ԫ�صĴ��㿪ʼ������������Ϊ -1
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="array">��չ���󡣴��㿪ʼ��һά����</param>
        /// <param name="startIndex">���㿪ʼ����������ʼ����</param>
        /// <param name="count">Ҫ�����Ĳ����е�Ԫ����</param>
        /// <param name="match">����Ҫ������Ԫ�ص�����</param>
        /// <returns></returns>
        public static int FindLastIndex<T>(this T[] array, int startIndex, int count, Predicate<T> match)
        {
            return Array.FindLastIndex(array, startIndex, count, match);
        }
    }
}