namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������㡣
        ///  ��һ�� System.decimal ֵ�м�ȥָ������һ���������͵�ֵ
        /// </summary>
        /// <param name="d1">��չ���󡣱�����</param>
        /// <param name="d2">����</param>
        /// <returns>d1 �� d2 ���õ� System.decimal ���</returns>
        public static decimal Subtract(this decimal d1, decimal d2)
        {
            return decimal.Subtract(d1, d2);
        }
    }
}