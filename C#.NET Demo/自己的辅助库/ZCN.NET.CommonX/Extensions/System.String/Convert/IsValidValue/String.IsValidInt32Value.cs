namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��32λ�з��ŵ�����ֵ��
        ///  �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidInt32Value(this string @this)
        {
            return int.TryParse(@this, out int result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��32λ�з��ŵ�����ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidInt32NullableValue(this string @this)
        {
            if (@this.IsNull())
                return true;

            return int.TryParse(@this, out int result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��32λ�޷��ŵ�����ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidUInt32Value(this string @this)
        {
            return uint.TryParse(@this, out uint result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��32λ�޷��ŵ�����ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidUInt32NullableValue(this string @this)
        {
            if (@this.IsNull())
                return true;

            return uint.TryParse(@this, out uint result);
        }
    }
}