using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж���չ�����ֵ�Ƿ���ָ��ֵ�ı���(@this % factor == 0)
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="factor">ָ��ֵ</param>
        /// <returns></returns>
        public static bool IsMultipleOf(this Int64 @this,Int64 factor)
        {
            return @this % factor == 0;
        }
    }
}