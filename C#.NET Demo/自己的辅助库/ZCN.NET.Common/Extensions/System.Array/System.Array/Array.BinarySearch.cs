using System;
using System.Collections;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ ��Array�����������ض�Ԫ�ء�
        /// ����ҵ� value����Ϊָ�� array �е�ָ�� value ��������
        /// ����Ҳ��� value �� value С�� array �е�һ������Ԫ�أ���Ϊһ���������ø����Ǵ���value �ĵ�һ��Ԫ�ص������İ�λ�󲹡�
        /// ����Ҳ��� value �� value ���� array �е��κ�Ԫ�أ���Ϊһ���������ø����ǣ����һ��Ԫ�ص�������1���İ�λ��
        /// </summary>
        /// <param name="array">Ҫ������������һά System.Array</param>
        /// <param name="value">Ҫ�����Ķ���</param>
        /// <returns></returns>
        public static int BinarySearch(this Array array,object value)
        {
            return Array.BinarySearch(array,value);
        }

        /// <summary>
        /// �Զ�����չ������ ��Array�����������ض�Ԫ�ء�
        /// ����ҵ� value����Ϊָ�� array �е�ָ�� value ��������
        /// ����Ҳ��� value �� value С�� array �е�һ������Ԫ�أ���Ϊһ���������ø����Ǵ���value �ĵ�һ��Ԫ�ص������İ�λ�󲹡�
        /// ����Ҳ��� value �� value ���� array �е��κ�Ԫ�أ���Ϊһ���������ø����ǣ����һ��Ԫ�ص�������1���İ�λ��
        /// </summary>
        /// <param name="array">Ҫ������������һά����</param>
        /// <param name="index">Ҫ�����ķ�Χ����ʼ����</param>
        /// <param name="length">Ҫ�����ķ�Χ�ĳ���</param>
        /// <param name="value">Ҫ�����Ķ���</param>
        /// <returns></returns>
        public static int BinarySearch(this Array array,int index,int length,object value)
        {
            return Array.BinarySearch(array,index,length,value);
        }

        /// <summary>
        /// �Զ�����չ������ ��Array�����������ض�Ԫ�ء�
        /// ����ҵ� value����Ϊָ�� array �е�ָ�� value ��������
        /// ����Ҳ��� value �� value С�� array �е�һ������Ԫ�أ���Ϊһ���������ø����Ǵ���value �ĵ�һ��Ԫ�ص������İ�λ�󲹡�
        /// ����Ҳ��� value �� value ���� array �е��κ�Ԫ�أ���Ϊһ���������ø����ǣ����һ��Ԫ�ص�������1���İ�λ��
        /// </summary>
        /// <param name="array">Ҫ������������һά����</param>
        /// <param name="value">Ҫ�����Ķ���</param>
        /// <param name="comparer">�Ƚ�Ԫ��ʱҪʹ�õ� System.Collections.IComparer ʵ�֡�
        ///                        ���Ϊ null����ʹ��ÿ��Ԫ�ص� System.IComparableʵ��
        /// </param>
        /// <returns></returns>
        public static int BinarySearch(this Array array,object value,IComparer comparer)
        {
            return Array.BinarySearch(array,value,comparer);
        }

        /// <summary>
        /// �Զ�����չ������ ��Array�����������ض�Ԫ�ء�
        /// ����ҵ� value����Ϊָ�� array �е�ָ�� value ��������
        /// ����Ҳ��� value �� value С�� array �е�һ������Ԫ�أ���Ϊһ���������ø����Ǵ���value �ĵ�һ��Ԫ�ص������İ�λ�󲹡�
        /// ����Ҳ��� value �� value ���� array �е��κ�Ԫ�أ���Ϊһ���������ø����ǣ����һ��Ԫ�ص�������1���İ�λ��
        /// </summary>
        /// <param name="array">Ҫ������������һά����</param>
        /// <param name="index">Ҫ�����ķ�Χ����ʼ����</param>
        /// <param name="length">Ҫ�����ķ�Χ�ĳ���</param>
        /// <param name="value">Ҫ�����Ķ���</param>
        /// <param name="comparer">�Ƚ�Ԫ��ʱҪʹ�õ� System.Collections.IComparer ʵ�֡�
        ///                        ���Ϊ null����ʹ��ÿ��Ԫ�ص� System.IComparableʵ��
        /// </param>
        /// <returns></returns>
        public static int BinarySearch(this Array array,int index,int length,object value,IComparer comparer)
        {
            return Array.BinarySearch(array,index,length,value,comparer);
        }
    }
}