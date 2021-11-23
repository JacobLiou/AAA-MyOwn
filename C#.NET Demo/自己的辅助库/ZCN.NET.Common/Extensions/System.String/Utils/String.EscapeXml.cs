namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������XML�ĵ���������ַ�����ת��
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>ת�����ַ���</returns>
        public static string EscapeXml(this string @this)
        {
            return @this.Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;")
                .Replace("'", "&apos;");
        }
    }
}