using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������жϸ�ֵ�Ƿ���ż��
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static bool IsEven(this Int64 @this)
        {
            return @this % 2 == 0;
        }
    }
}