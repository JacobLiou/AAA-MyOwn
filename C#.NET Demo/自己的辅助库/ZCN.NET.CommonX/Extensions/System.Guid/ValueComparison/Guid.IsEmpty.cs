using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж���չ�����ֵ�Ƿ�Ϊ��(ȫ0�Ŀ�Guid)
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static bool IsEmpty(this Guid @this)
        {
            return @this == Guid.Empty;
        }
    }
}