using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���ַ�����λ��ָ��λ�õ��ַ��Ƿ���д�������λ
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ�����λ��λ�� index ���ַ�Ϊ�ߴ������ʹ������Ϊ true������Ϊ false</returns>
        public static bool IsSurrogate(this string @this, int index)
        {
            return Char.IsSurrogate(@this, index);
        }

        /// <summary>
        ///  �Զ�����չ�������ж��ַ�����ָ��λ�ô��� System.Char �����Ƿ�Ϊ�ߴ�����
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns> ��� s ������ָ���ַ�����ֵ��Χ�� U+D800 �� U+DBFF����Ϊ true������Ϊ false</returns>
        public static bool IsHighSurrogate(this string @this, int index)
        {
            return Char.IsHighSurrogate(@this, index);
        }

        /// <summary>
        ///  �Զ�����չ�������ж��ַ�����ָ��λ�ô��� System.Char �����Ƿ�Ϊ�ʹ�����
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns> ��� s ������ָ���ַ�����ֵ��Χ�� U+DC00 �� U+DFFF����Ϊ true������Ϊ false
        /// </returns>
        public static bool IsLowSurrogate(this string @this, int index)
        {
            return Char.IsLowSurrogate(@this, index);
        }
    }
}