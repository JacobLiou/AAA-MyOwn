using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �ж�ָ���ַ�����λ��ָ��λ�ô����ַ��Ƿ����ڱ��������
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns> ����ַ�����λ�� index �����ַ��Ǳ����ţ���Ϊ true������Ϊ false</returns>
        public static bool IsPunctuation(this string @this, int index)
        {
            return Char.IsPunctuation(@this, index);
        }
    }
}