namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��64λ�з��ŵ�����ֵ��
        /// ������� Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidLongValue(this string @this)
        {
            return long.TryParse(@this, out long result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��64λ�з��ŵ�����ֵ��
        /// ������� Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidLongValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return long.TryParse(@this, out long result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��64λ�޷��ŵ�����ֵ��
        /// ������� Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidULongValue(this string @this)
        {
            return ulong.TryParse(@this, out ulong result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��64λ�޷��ŵ�����ֵ��
        /// ������� Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidULongValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return ulong.TryParse(@this, out ulong result);
        }
    }
}