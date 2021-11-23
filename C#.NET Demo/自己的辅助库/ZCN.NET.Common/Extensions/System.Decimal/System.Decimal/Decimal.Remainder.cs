namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ȡģ(����)���㡣
        ///  ����ָ���� System.decimal ֵ����������������������Ϊ0�򷵻�0
        /// </summary>
        /// <param name="d1">��չ���󡣱�����</param>
        /// <param name="d2">����</param>
        /// <returns>d1 ���� d2 ������</returns>
        public static decimal Remainder(this decimal d1, decimal d2)
        {
            if(d2 == 0)
                return 0;

            return decimal.Remainder(d1, d2);
        }

        /// <summary>
        ///  �Զ�����չ����������ָ���� System.decimal ֵ����������������������Ϊ0�򷵻�0
        /// </summary>
        /// <param name="d1">��չ���󡣱�����</param>
        /// <param name="d2">����</param>
        /// <returns>d1 ���� d2 ������</returns>
        public static decimal Mode(this decimal d1,decimal d2)
        {
            if(d2 == 0)
                return 0;

            return d1 % d2;
        }
    }
}