using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �ж�ָ���ַ�����λ��ָ��λ�õ��ַ��Ƿ������������
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ�����λ�� index ���ַ������֣���Ϊ true������Ϊ false</returns>
        public static bool IsNumber(this string @this, int index)
        {
            return Char.IsNumber(@this, index);
        }
    }
}