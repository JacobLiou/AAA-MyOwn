using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������������ʮ�������нϴ��һ��
        /// </summary>
        /// <param name="value1">��չ����Ҫ�Ƚϵ����� System.Decimal �����еĵ�һ��</param>
        /// <param name="value2">Ҫ�Ƚϵ����� System.Decimal �����еĵڶ���</param>
        /// <returns></returns>
        public static decimal Max(this decimal value1, decimal value2)
        {
            return Math.Max(value1,value2);
        }
    }
}