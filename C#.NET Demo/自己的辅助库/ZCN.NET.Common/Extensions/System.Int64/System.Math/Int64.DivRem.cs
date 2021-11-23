using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������� 64 λ�з����������̣���ͨ�������������������
        ///  �����������0���򷵻ؽ��0������ҲΪ0
        /// </summary>
        /// <param name="a">��չ���󡣱�����</param>
        /// <param name="b">����</param>
        /// <param name="result">����</param>
        /// <returns>����ֵ</returns>
        public static Int64 DivRem(this Int64 a, Int64 b, out Int64 result)
        {
            if(b == 0)
            {
                result = 0;
                return 0;
            }

            return Math.DivRem(a, b, out result);
        }
    }
}