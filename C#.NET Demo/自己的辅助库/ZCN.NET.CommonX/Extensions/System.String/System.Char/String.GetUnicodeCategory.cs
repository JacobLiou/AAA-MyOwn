using System;
using System.Globalization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ���ַ�����λ��ָ��λ�õ��ַ����ൽ��һ�� System.Globalization.UnicodeCategory ֵ��ʶ������
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>һ�� System.Globalization.UnicodeCategory ö�ٳ�������ʶ�����ַ�����λ�� index �����ַ�����</returns>
        public static UnicodeCategory GetUnicodeCategory(this string @this, int index)
        {
            return Char.GetUnicodeCategory(@this, index);
        }
    }
}