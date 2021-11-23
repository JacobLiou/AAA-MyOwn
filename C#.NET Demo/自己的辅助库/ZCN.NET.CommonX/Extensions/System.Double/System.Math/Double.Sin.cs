using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ���Ƕȵ�����ֵ��
        /// ��� �Ƕ� ���� System.Double.NaN��System.Double.NegativeInfinity �� 
        /// System.Double.PositiveInfinity���˷��������� System.Double.NaN
        /// </summary>
        /// <param name="a">��չ�����Ի���Ϊ��λ�Ľ�</param>
        /// <returns></returns>
        public static double Sin(this double a)
        {
            return Math.Sin(a);
        }
    }
}