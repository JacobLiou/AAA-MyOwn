using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������� 32 λ�з����������̣���ͨ�������������������
        ///  �����������0���򷵻ؽ��0������ҲΪ0
        /// </summary>
        /// <param name="a">��չ���󡣱�����</param>
        /// <param name="b">����</param>
        /// <param name="result">����</param>
        /// <returns>����ֵ</returns>
        public static int DivRem(this Int32 a, Int32 b, out Int32 result)
        {
            if (b == 0)
            {
                result = 0;
                return 0;
            }

            return Math.DivRem(a, b, out result);
        }
    }
}