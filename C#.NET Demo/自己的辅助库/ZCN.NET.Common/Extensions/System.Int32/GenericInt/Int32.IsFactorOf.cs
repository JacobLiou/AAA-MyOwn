using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж���չ�����ֵ�Ƿ���ָ����������(factorNumber % @this == 0)
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="factorNumber">ָ����</param>
        /// <returns></returns>
        public static bool IsFactorOf(this Int32 @this,Int32 factorNumber)
        {
            return factorNumber % @this == 0;
        }
    }
}