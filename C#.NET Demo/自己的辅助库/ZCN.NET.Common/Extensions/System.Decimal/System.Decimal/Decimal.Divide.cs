
namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������㡣
        ///  ����ָ���� System.Decimal ֵ������������Ϊ0�򷵻�0
        /// </summary>
        /// <param name="d1">��չ���󡣱�����</param>
        /// <param name="d2">����</param>
        /// <returns>d1 ���� d2 �Ľ��</returns>
        public static decimal Divide(this decimal d1, decimal d2)
        {
            if (d2 == 0)
                return 0;

            return decimal.Divide(d1, d2);
        }
    }
}