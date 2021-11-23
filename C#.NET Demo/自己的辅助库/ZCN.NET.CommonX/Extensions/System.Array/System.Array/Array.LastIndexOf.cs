using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ ����ָ���Ķ��󣬲���������һά System.Array ���������һ��ƥ���������
        /// </summary>
        /// <param name="array">Ҫ������һά System.Array ����</param>
        /// <param name="value">Ҫ�� array �����в��ҵĶ���</param>
        /// <returns></returns>
        public static int LastIndexOf(this Array array,object value)
        {
            return Array.LastIndexOf(array,value);
        }

        /// <summary>
        /// �Զ�����չ����������ָ���Ķ��󣬲�����һά System.Array �����дӵ�һ��Ԫ�ص�ָ�������ⲿ��Ԫ�������һ��ƥ��������� 
        /// </summary>
        /// <param name="array">Ҫ������һά System.Array ����</param>
        /// <param name="value">Ҫ�� array �����в��ҵĶ���</param>
        /// <param name="startIndex">��������ʼ�������������� 0���㣩Ϊ��Чֵ</param>
        /// <returns></returns>
        public static int LastIndexOf(this Array array,object value,int startIndex)
        {
            return Array.LastIndexOf(array,value,startIndex);
        }

        /// <summary>
        /// �Զ�����չ������ ����ָ���Ķ��󣬲�����һά System.Array �����е�ָ������Ϊֹ����ָ����Ԫ�ص��ⲿ��Ԫ�������һ��ƥ���������
        /// </summary>
        /// <param name="array">Ҫ������һά System.Array ����</param>
        /// <param name="value">Ҫ�� array �����в��ҵĶ���</param>
        /// <param name="startIndex">��������ʼ�������������� 0���㣩Ϊ��Чֵ</param>
        /// <param name="count">Ҫ�����Ĳ����е�Ԫ����</param>
        /// <returns></returns>
        public static int LastIndexOf(this Array array,object value,int startIndex,int count)
        {
            return Array.LastIndexOf(array,value,startIndex,count);
        }
    }
}