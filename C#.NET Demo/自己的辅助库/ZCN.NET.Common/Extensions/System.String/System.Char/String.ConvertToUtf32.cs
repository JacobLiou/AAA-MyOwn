using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ַ�����ָ��λ�õ� UTF-16 �����ַ��������Ե�ֵת��Ϊ Unicode ��λ
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>�ַ��������Ա�ʾ�� 21 λ Unicode ��λ�����ַ������������ַ��������е�λ���� index ����ָ��</returns>
        public static int ConvertToUtf32(this string @this, int index)
        {
            return Char.ConvertToUtf32(@this, index);
        }
    }
}