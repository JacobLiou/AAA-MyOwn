using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �ж�ָ���ַ�����λ��ָ��λ�ô����ַ��Ƿ����ڿ����ַ����
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ�����λ�� index �����ַ��ǿ����ַ�����Ϊ true������Ϊ false</returns>
        public static bool IsControl(this string @this, int index)
        {
            return Char.IsControl(@this, index);
        }
    }
}