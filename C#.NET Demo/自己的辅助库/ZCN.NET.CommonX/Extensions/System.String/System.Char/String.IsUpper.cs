using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���ַ�����λ��ָ��λ�ô����ַ��Ƿ����ڴ�д��ĸ���
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ�����λ�� index �����ַ��Ǵ�д��ĸ����Ϊ true������Ϊ false</returns>
        public static bool IsUpper(this string @this, int index)
        {
            return Char.IsUpper(@this, index);
        }
    }
}