using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ ��ָ���ַ�����λ��ָ��λ�õ����� Unicode �ַ�ת��Ϊ˫���ȸ�����
        /// </summary>
        /// <param name="this">��չ�����ַ���</param>
        /// <param name="index">Ҫ������ַ����ַ����е�λ��</param>
        /// <returns>����ַ�����λ�� index �����ַ���ʾ���֣���Ϊ���ַ�����ֵ������Ϊ -1 </returns>
        public static double GetNumericValue(this string @this, int index)
        {
            return Char.GetNumericValue(@this, index);
        }
    }
}