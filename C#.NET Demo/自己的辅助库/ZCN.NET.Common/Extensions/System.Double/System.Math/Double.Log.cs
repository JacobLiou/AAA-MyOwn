using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ�����ֵ���Ȼ��������Ϊ e����
        /// </summary>
        /// <param name="d">��չ����Ҫ���������������</param>
        /// <returns></returns>
        public static double Log(this double d)
        {
            return Math.Log(d);
        }

        /// <summary>
        /// �Զ�����չ����������ָ��������ʹ��ָ����ʱ�Ķ���
        /// </summary>
        /// <param name="d">��չ����Ҫ���������������</param>
        /// <param name="newBase">�����ĵ�</param>
        /// <returns></returns>
        public static double Log(this double d, double newBase)
        {
            return Math.Log(d, newBase);
        }
    }
}