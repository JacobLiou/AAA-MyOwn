using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж���չ�����ֵ�Ƿ���ָ��ֵ�ı���(@this % factor == 0)
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="factor">ָ��ֵ</param>
        /// <returns></returns>
        public static bool IsMultipleOf(this Int32 @this,Int32 factor)
        {
            return @this % factor == 0;
        }
    }
}