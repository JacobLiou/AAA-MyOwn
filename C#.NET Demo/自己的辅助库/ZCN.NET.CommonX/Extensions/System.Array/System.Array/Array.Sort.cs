using System;
using System.Collections;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������������һά System.Array �����е�Ԫ�ؽ�������
        /// </summary>
        /// <param name="array">Ҫ�����һά System.Array ����</param>
        public static void Sort(this Array array)
        {
            Array.Sort(array);
        }

        /// <summary>
        /// �Զ�����չ���������ڵ�һ�� System.Array �еĹؼ��֣�ʹ��ÿ���ؼ��ֵ� System.IComparable ʵ�֣�
        /// ������һά System.Array ����һ�������ؼ��֣���һ��������Ӧ�����������
        /// </summary>
        /// <param name="array">һά System.Array��������Ҫ����Ĺؼ���</param>
        /// <param name="items"> һά System.Array���������� keysSystem.Array �е�ÿһ���ؼ��ֶ�Ӧ���
        ///  ���Ϊ null����ֻ�� keysSystem.Array��������
        /// </param>
        public static void Sort(this Array array,Array items)
        {
            Array.Sort(array,items);
        }

        /// <summary>
        /// �Զ�����չ��������һά System.Array ������ĳ����Ԫ�ؽ�������
        /// </summary>
        /// <param name="array">Ҫ�����һά System.Array ����</param>
        /// <param name="index">����Χ����ʼ����</param>
        /// <param name="length">����Χ�ڵ�Ԫ����</param>
        public static void Sort(this Array array,Int32 index,Int32 length)
        {
            Array.Sort(array,index,length);
        }

        /// <summary>
        /// �Զ�����չ���������ڵ�һ�� System.Array �еĹؼ��֣�ʹ��ÿ���ؼ��ֵ� System.IComparable ʵ�֣�
        /// ������һά System.Array ����һ�������ؼ��֣���һ��������Ӧ����Ĳ���Ԫ�ؽ�������
        /// </summary>
        /// <param name="array">һά System.Array��������Ҫ����Ĺؼ���</param>
        /// <param name="items"> һά System.Array���������� keysSystem.Array �е�ÿһ���ؼ��ֶ�Ӧ���
        ///  ���Ϊ null����ֻ�� keysSystem.Array��������
        /// </param>
        /// <param name="index">����Χ����ʼ����</param>
        /// <param name="length">����Χ�ڵ�Ԫ����</param>
        public static void Sort(this Array array,Array items,Int32 index,Int32 length)
        {
            Array.Sort(array,items,index,length);
        }

        /// <summary>
        /// �Զ�����չ��������ָ�� System.Collections.IComparer����һά System.Array �����е�Ԫ�ؽ�������
        /// </summary>
        /// <param name="array">Ҫ�����һά System.Array ����</param>
        /// <param name="comparer">�Ƚ�Ԫ��ʱҪʹ�õ� System.Collections.IComparer ʵ�֡�
        /// ���Ϊ null����ʹ��ÿ��Ԫ�ص� System.IComparable ʵ��</param>
        public static void Sort(this Array array,IComparer comparer)
        {
            Array.Sort(array,comparer);
        }

        /// <summary>
        /// �Զ�����չ���������ڵ�һ�� System.Array �еĹؼ��֣���ָ�� System.Collections.IComparer��
        /// ������һά System.Array����һ�������ؼ��֣���һ��������Ӧ�����������
        /// </summary>
        /// <param name="array">Ҫ�����һά System.Array ����</param>
        /// <param name="items"> һά System.Array���������� keysSystem.Array �е�ÿһ���ؼ��ֶ�Ӧ���
        ///  ���Ϊ null����ֻ�� keysSystem.Array��������
        /// </param>
        /// <param name="comparer">�Ƚ�Ԫ��ʱҪʹ�õ� System.Collections.IComparer ʵ�֡�
        /// ���Ϊ null����ʹ��ÿ��Ԫ�ص� System.IComparable ʵ��</param>
        public static void Sort(this Array array,Array items,IComparer comparer)
        {
            Array.Sort(array,items,comparer);
        }

        /// <summary>
        /// �Զ�����չ��������һά System.Array �Ĳ���Ԫ�ؽ�������
        /// </summary>
        /// <param name="array">Ҫ�����һά System.Array ����</param>
        /// <param name="index">����Χ����ʼ����</param>
        /// <param name="length">����Χ�ڵ�Ԫ����</param>
        /// <param name="comparer">�Ƚ�Ԫ��ʱҪʹ�õ� System.Collections.IComparer ʵ�֡�
        /// ���Ϊ null����ʹ��ÿ��Ԫ�ص� System.IComparable ʵ��</param>
        public static void Sort(this Array array,Int32 index,Int32 length,IComparer comparer)
        {
            Array.Sort(array,index,length,comparer);
        }

        /// <summary>
        /// �Զ�����չ������ ���ڵ�һ�� System.Array �еĹؼ��֣���ָ�� System.Collections.IComparer��
        /// ������һά System.Array ����һ�������ؼ��֣���һ��������Ӧ����Ĳ���Ԫ�ؽ�������
        /// </summary>
        /// <param name="array">Ҫ�����һά System.Array ����</param>
        /// <param name="items"> һά System.Array���������� keysSystem.Array �е�ÿһ���ؼ��ֶ�Ӧ���
        ///  ���Ϊ null����ֻ�� keysSystem.Array��������
        /// </param>
        /// <param name="index">����Χ����ʼ����</param>
        /// <param name="length">����Χ�ڵ�Ԫ����</param>
        /// <param name="comparer">�Ƚ�Ԫ��ʱҪʹ�õ� System.Collections.IComparer ʵ�֡�
        /// ���Ϊ null����ʹ��ÿ��Ԫ�ص� System.IComparable ʵ��</param>
        public static void Sort(this Array array,Array items,Int32 index,Int32 length,IComparer comparer)
        {
            Array.Sort(array,items,index,length,comparer);
        }
    }
}