namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ�� System.Decimal ��ֵת��Ϊ��Ч��˫���ȸ�����
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns> ��Ч��decimalֵ��˫���ȸ�����</returns>
        public static double ToDouble(this decimal value)
        {
            return (double)value;
        }
    }
}