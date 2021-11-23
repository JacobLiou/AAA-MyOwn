namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч�� Boolean ����ֵ��
        /// �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidBooleanValue(this string @this)
        {
            return bool.TryParse(@this, out bool result);
        }

        /// <summary>
        /// �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч�� Boolean ����ֵ��
        /// �������Ϊ null����˷������� true��
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidBooleanValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return bool.TryParse(@this, out bool result);
        }
    }
}