using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч�� DateTimeOffset ����ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidDateTimeOffSetValue(this string @this)
        {
            return DateTimeOffset.TryParse(@this, out DateTimeOffset result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч�� DateTimeOffset ����ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidDateTimeOffSetValueNullable(this string @this)
        {
            if(@this.IsNull()) 
                return true;

            return DateTimeOffset.TryParse(@this, out DateTimeOffset result);
        }
    }
}