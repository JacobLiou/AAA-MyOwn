using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������жϸ�ֵ�Ƿ���ż��
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static bool IsEven(this Int16 @this)
        {
            return @this % 2 == 0;
        }
    }
}