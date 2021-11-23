namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��64λ�з��ŵ�����ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidInt64Value(this string @this)
        {
            return @this.IsValidLongValue();
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��64λ�з��ŵ�����ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidInt64ValueNullable(this string @this)
        {
            return @this.IsValidLongValueNullable();
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��64λ�޷��ŵ�����ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidUInt64Value(this string @this)
        {
            return @this.IsValidULongValue();
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��64λ�޷��ŵ�����ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidUInt64ValueNullable(this string @this)
        {
            return @this.IsValidULongValueNullable();
        }
    }
}