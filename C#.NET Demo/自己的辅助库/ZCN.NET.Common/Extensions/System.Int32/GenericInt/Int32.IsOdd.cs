using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������жϸ�ֵ�Ƿ�������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static bool IsOdd(this Int32 @this)
        {
            return @this % 2 != 0;
        }
    }
}