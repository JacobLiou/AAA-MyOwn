using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �ж�ָ���ַ�����λ��ָ��λ�ô����ַ��Ƿ�����ʮ�����������
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ�����λ�� index �����ַ���ʮ�������֣���Ϊ true������Ϊ false</returns>
        public static bool IsDigit(this string @this, int index)
        {
            return Char.IsDigit(@this, index);
        }
    }
}