namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�����������չ������ڿ��ַ����򷵻�null�����򷵻ر���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static string NullIfEmpty(this string @this)
        {
            return @this == "" ? null : @this;
        }

        /// <summary>
        ///  �Զ�����չ�����������չ������ڿհ��ַ����򷵻�null�����򷵻ر���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static string NullIfWhiteSpace(this string @this)
        {
            return @this.TrimAll() == "" ? null : @this;
        }
    }
}