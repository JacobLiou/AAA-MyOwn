using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �ж�ָ���� Unicode �ַ��Ƿ�������ĸ
        /// </summary>
        /// <param name="this">��չ�����ַ���</param>
        /// <param name="index">Ҫ������ַ����ַ����е�λ��</param>
        /// <returns>����ַ����� index λ�ô����ַ�����ĸ����Ϊ true������Ϊ false</returns>
        public static bool IsLetter(this string @this, int index)
        {
            return Char.IsLetter(@this, index);
        }
    }
}