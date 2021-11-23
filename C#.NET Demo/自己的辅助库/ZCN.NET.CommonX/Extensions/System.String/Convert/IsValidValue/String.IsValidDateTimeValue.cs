using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч������ʱ������ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidDateTimeValue(this string @this)
        {
            return DateTime.TryParse(@this, out DateTime result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч������ʱ������ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidDateTimeValueNullable(this string @this)
        {
            if(@this.IsNullOrDBNull())
                return true;

            return DateTime.TryParse(@this, out DateTime result);
        }
    }
}