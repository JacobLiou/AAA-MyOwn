using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж�ָ���ַ�����λ��ָ��λ�ô����ַ��Ƿ����ڿհ����
        /// </summary>
        /// <param name="this">�ַ���</param>
        /// <param name="index">Ҫ������ַ��� s �е�λ��</param>
        /// <returns>����ַ�����λ�� index �����ַ��ǿհף���Ϊ true������Ϊ false</returns>
        public static Boolean IsWhiteSpace(this string @this, int index)
        {
            return Char.IsWhiteSpace(@this, index);
        }
    }
}