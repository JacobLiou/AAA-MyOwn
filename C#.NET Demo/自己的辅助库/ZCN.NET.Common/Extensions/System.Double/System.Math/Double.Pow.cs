using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ�����ֵ�ָ�����ݡ�
        /// ���� ���� x �� y ����
        /// </summary>
        /// <param name="x">��չ����Ҫ���ݵ�˫���ȸ�����</param>
        /// <param name="y">ָ���ݵ�˫���ȸ�����</param>
        /// <returns></returns>
        public static double Pow(this double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}