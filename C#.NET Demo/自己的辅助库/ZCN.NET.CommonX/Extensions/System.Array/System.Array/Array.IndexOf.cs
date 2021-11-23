using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ ����ָ���Ķ��󣬲���������һά System.Array �е�һ��ƥ���������
        /// </summary>
        /// <param name="array">Ҫ������һά System.Array ����</param>
        /// <param name="value">Ҫ�� array �����в��ҵĶ���</param>
        /// <returns></returns>
        public static int IndexOf(this Array array,object value)
        {
            return Array.IndexOf(array,value);
        }

        /// <summary>
        /// �Զ�����չ������ ����ָ���Ķ��󣬲�����һά System.Array �д�ָ�����������һ��Ԫ���ⲿ��Ԫ���е�һ��ƥ���������
        /// </summary>
        /// <param name="array">Ҫ������һά System.Array ����</param>
        /// <param name="value">Ҫ�� array �����в��ҵĶ���</param>
        /// <param name="startIndex">��������ʼ�������������� 0���㣩Ϊ��Чֵ</param>
        /// <returns></returns>
        public static int IndexOf(this Array array,object value,int startIndex)
        {
            return Array.IndexOf(array,value,startIndex);
        }

        /// <summary>
        /// �Զ�����չ������ ����ָ���Ķ��󣬲�����һά System.Array �д�ָ��������ʼ����ָ����Ԫ�ص��ⲿ��Ԫ���е�һ��ƥ���������
        /// </summary>
        /// <param name="array">Ҫ������һά System.Array ����</param>
        /// <param name="value">Ҫ�� array �����в��ҵĶ���</param>
        /// <param name="startIndex">��������ʼ�������������� 0���㣩Ϊ��Чֵ</param>
        /// <param name="count">Ҫ�����Ĳ����е�Ԫ����</param>
        /// <returns></returns>
        public static int IndexOf(this Array array,object value,int startIndex,int count)
        {
            return Array.IndexOf(array,value,startIndex,count);
        }
    }
}