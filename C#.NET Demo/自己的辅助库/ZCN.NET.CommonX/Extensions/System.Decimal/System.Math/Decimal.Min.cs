using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������������ʮ�������н�С��һ��
        /// </summary>
        /// <param name="value1">��չ����Ҫ�Ƚϵ����� System.Decimal �����еĵ�һ��</param>
        /// <param name="value2">Ҫ�Ƚϵ����� System.Decimal �����еĵڶ���</param>
        /// <returns>val1 �� val2 �����н�С��һ��</returns>
        public static decimal Min(this decimal value1, decimal value2)
        {
            return Math.Min(value1,value2);
        }
    }
}