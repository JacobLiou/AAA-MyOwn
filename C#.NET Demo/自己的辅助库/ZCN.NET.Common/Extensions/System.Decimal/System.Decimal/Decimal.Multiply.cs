namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������˷����㡣  
        ///  ����ָ���� System.Decimal ֵ���
        /// </summary>
        /// <param name="d1">������</param>
        /// <param name="d2">����</param>
        /// <returns>d1 �� d2 ��˵Ľ��</returns>
        public static decimal Multiply(this decimal d1, decimal d2)
        {
            return decimal.Multiply(d1, d2);
        }
    }
}