using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���ַ�����λ��ָ��λ�ô����ַ��Ƿ����ڷ����ַ����
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ�����λ�� index �����ַ��Ƿ����ַ�����Ϊ true������Ϊ false</returns>
        public static bool IsSymbol(this string @this, int index)
        {
            return Char.IsSymbol(@this, index);
        }
    }
}