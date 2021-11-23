using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������(ȡ��������)����һָ�����ֱ���һָ�����������������
        /// �������� x - ( y Q)������ Q �� x / y ���̵���ӽ���������� x / y �����������м䣬�򷵻�ż������
        /// ��� x - ( y Q) Ϊ�㣬���� x Ϊ��ʱ����ֵ +0������ x Ϊ��ʱ���� -0����� y ���� 0���򷵻� System.Double.NaN
        /// </summary>
        /// <param name="x">��չ���󡣱�����</param>
        /// <param name="y">����</param>
        /// <returns></returns>
        public static double IEEERemainder(this double x, double y)
        {
            if(y == 0)
                return 0;

            return Math.IEEERemainder(x, y);
        }
    }
}