namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��16λ�з��ŵ�����ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidShortValue(this string @this)
        {
            return short.TryParse(@this, out short result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��16λ�з��ŵ�����ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidShortValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return short.TryParse(@this, out short result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��16λ�޷��ŵ�����ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidUShortValue(this string @this)
        {
            return ushort.TryParse(@this, out ushort result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч��16λ�޷��ŵ�����ֵ��
        /// �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidUShortValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return ushort.TryParse(@this, out ushort result);
        }
    }
}