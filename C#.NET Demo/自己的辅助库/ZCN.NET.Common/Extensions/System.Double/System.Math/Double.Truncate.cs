using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ��˫���ȸ���������������
        /// </summary>
        /// <param name="d">��չ����Ҫ�ضϵ�����</param>
        /// <returns></returns>
        public static double Truncate(this double d)
        {
            return Math.Truncate(d);
        }
    }
}