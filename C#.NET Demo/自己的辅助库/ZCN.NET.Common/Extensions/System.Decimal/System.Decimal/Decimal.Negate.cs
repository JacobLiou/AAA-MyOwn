namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ȡ�����㡣
        ///  ����ָ���� System.decimal ֵ���� -1 �Ľ��
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns>ȡ���Ľ��</returns>
        public static decimal Negate(this decimal d)
        {
            return decimal.Negate(d);
        }
    }
}