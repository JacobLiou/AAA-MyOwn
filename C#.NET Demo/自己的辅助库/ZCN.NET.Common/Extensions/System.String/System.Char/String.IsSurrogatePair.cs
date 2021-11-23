using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ָ��λ�ô����������� System.Char �����Ƿ��γɴ������
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ����������� index �� index + 1 λ�ô��������ַ������� index λ�ô��ַ�����ֵ�� U+D800 �� U+DBFF ��Χ�ڣ�
        ///          index +1 λ�ô��ַ�����ֵ�� U+DC00 �� U+DFFF ��Χ�ڣ���Ϊ true������Ϊ false
        /// </returns>
        public static bool IsSurrogatePair(this string @this, int index)
        {
            return Char.IsSurrogatePair(@this, index);
        }
    }
}