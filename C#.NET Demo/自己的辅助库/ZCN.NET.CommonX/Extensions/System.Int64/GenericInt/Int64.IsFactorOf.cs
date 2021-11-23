using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж���չ�����ֵ�Ƿ���ָ����������(factorNumber % @this == 0)
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="factorNumber">ָ����</param>
        /// <returns></returns>
        public static bool IsFactorOf(this Int64 @this,Int64 factorNumber)
        {
            return factorNumber % @this == 0;
        }
    }
}