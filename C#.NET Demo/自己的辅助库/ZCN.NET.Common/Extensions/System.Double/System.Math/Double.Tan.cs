using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ���Ƕȵ�����ֵ��
        /// ��� �Ƕ� ���� System.Double.NaN��System.Double.NegativeInfinity �� System.Double.PositiveInfinity��
        /// �˷���������System.Double.NaN
        /// </summary>
        /// <param name="a">��չ�����Ի���Ϊ��λ�Ľ�</param>
        /// <returns></returns>
        public static double Tan(this double a)
        {
            return Math.Tan(a);
        }
    }
}