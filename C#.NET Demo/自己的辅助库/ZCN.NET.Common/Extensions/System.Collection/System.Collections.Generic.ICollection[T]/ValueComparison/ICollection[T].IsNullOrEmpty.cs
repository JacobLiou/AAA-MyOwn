using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������жϼ����Ƿ�Ϊ null ����Ԫ�صĸ�������0 
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> @this)
        {
            return @this == null || @this.Count == 0;
        }

        /// <summary>
        ///  �Զ�����չ�������жϼ����Ƿ�Ϊ null ��Ԫ�صĸ�������0��
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static bool IsNotNullAndEmpty<T>(this ICollection<T> @this)
        {
            return @this != null && @this.Count > 0;
        }
    }
}