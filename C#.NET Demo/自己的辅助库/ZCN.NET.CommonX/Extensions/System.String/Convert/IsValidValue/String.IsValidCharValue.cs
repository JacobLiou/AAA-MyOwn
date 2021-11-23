namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч�� char ����ֵ��
        ///  �������Ϊ null����˷������� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidCharValue(this string @this)
        {
            return char.TryParse(@this, out char result);
        }

        /// <summary>
        ///  �Զ�����չ�������ж��ַ�����ֵ�Ƿ�����Ч�� char ����ֵ��
        ///  �������Ϊ null����˷������� true
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>true �� false</returns>
        public static bool IsValidCharValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return char.TryParse(@this, out char result);
        }
    }
}