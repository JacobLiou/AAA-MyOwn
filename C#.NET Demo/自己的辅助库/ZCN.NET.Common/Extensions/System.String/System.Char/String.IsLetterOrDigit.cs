using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������жϽ�ָ���ַ�����ָ��λ�ô����ַ�����Ϊ��ĸ����ʮ��������
        /// </summary>
        /// <param name="this">��չ�����ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ����� index λ�ô����ַ�����ĸ��ʮ�������֣���Ϊ true������Ϊ false</returns>
        public static bool IsLetterOrDigit(this string @this, int index)
        {
            return Char.IsLetterOrDigit(@this, index);
        }
    }
}