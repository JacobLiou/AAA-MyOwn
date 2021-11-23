using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ת����һά System.Array ������Ԫ�ص�˳��
        /// </summary>
        /// <param name="array">Ҫ��ת��һά System.Array ����</param>
        public static void Reverse(this Array array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// �Զ�����չ��������תһά System.Array ��ĳ����Ԫ�ص�Ԫ��˳��
        /// </summary>
        /// <param name="array">Ҫ��ת��һά System.Array ����</param>
        /// <param name="index">Ҫ��ת�Ĳ��ֵ���ʼ����</param>
        /// <param name="length">Ҫ��ת�Ĳ����е�Ԫ����</param>
        public static void Reverse(this Array array, int index, int length)
        {
            Array.Reverse(array, index, length);
        }
    }
}