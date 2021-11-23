namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������׶ε��ַ���ʹ�����������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="maxLength">������ʾ����󳤶�</param>
        /// <returns>A string.</returns>
        public static string Truncate(this string @this, int maxLength)
        {
            const string suffix = "...";

            if (@this == null || @this.Length <= maxLength)
            {
                return @this;
            }

            int strLength = maxLength - suffix.Length;
            return @this.Substring(0, strLength) + suffix;
        }

        /// <summary>
        ///  �Զ�����չ���������ضϵ��ַ���ʹ�ú�׺����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="maxLength">������ʾ����󳤶�</param>
        /// <param name="suffix">��׺���滻�ַ���</param>
        /// <returns>A string.</returns>
        public static string Truncate(this string @this, int maxLength, string suffix)
        {
            if (@this == null || @this.Length <= maxLength)
            {
                return @this;
            }

            int strLength = maxLength - suffix.Length;
            return @this.Substring(0, strLength) + suffix;
        }
    }
}