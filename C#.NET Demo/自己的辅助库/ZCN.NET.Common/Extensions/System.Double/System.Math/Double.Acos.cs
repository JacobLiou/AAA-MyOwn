using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������������ֵΪָ�����ֵĽǶȡ�
        /// ���ؽǶ� �ȣ��Ի���Ϊ��λ������ �� (����0����֮��)��
        /// �������ֵ����1����С��-1�򷵻� System.Double.NaN
        /// </summary>
        /// <param name="d">��չ���󡣱�ʾ����ֵ������(����-1��1֮��)</param>
        /// <returns></returns>
        public static double Acos(this double d)
        {
            return Math.Acos(d);
        }
    }
}