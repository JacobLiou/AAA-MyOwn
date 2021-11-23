namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������html��ǩbr �滻Ϊ2�����з���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static string BrToNewLine(this string @this)
        {
            return @this.Replace("<br />", "\r\n").Replace("<br>", "\r\n");
        }

        /// <summary>
        ///  �Զ�����չ��������2�����з����滻Ϊhtml��ǩbr
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static string NewLineToBr(this string @this)
        {
            return @this.Replace("\r\n","<br />").Replace("\n","<br />");
        }
    }
}