using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �ж�ָ���ַ�����λ��ָ��λ�ô����ַ��Ƿ����ڷָ������
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ�����λ�� index �����ַ��Ƿָ�������Ϊ true������Ϊ false</returns>
        public static bool IsSeparator(this string @this, int index)
        {
            return Char.IsSeparator(@this, index);
        }
    }
}