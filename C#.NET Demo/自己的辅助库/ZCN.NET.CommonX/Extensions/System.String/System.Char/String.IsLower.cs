using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �ж�ָ���ַ�����λ��ָ��λ�ô����ַ��Ƿ�����Сд��ĸ���
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ�����λ�� index �����ַ���Сд��ĸ����Ϊ true������Ϊ false</returns>
        public static bool IsLower(this string @this, int index)
        {
            return Char.IsLower(@this, index);
        }
    }
}