using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������������ֵΪָ�����ֵĽǶȡ�
        /// �Ƕ� �ȣ��Ի���Ϊ��λ������ -��/2 �ܦȡܦ�/2��
        /// ��� ����ֵ ���� System.Double.NaN����Ϊ System.Double.NaN��
        /// ��� ����ֵ ���� System.Double.NegativeInfinity����Ϊ����Ϊ˫����ֵ (-1.5707963267949) �� -��/2��
        /// ��� ����ֵ ���� System.Double.PositiveInfinity����Ϊ����Ϊ˫����ֵ (1.5707963267949) �� ��/2
        /// </summary>
        /// <param name="d">��չ���󡣱�ʾ����ֵ������</param>
        /// <returns></returns>
        public static double Atan(this double d)
        {
            return Math.Atan(d);
        }
    }
}