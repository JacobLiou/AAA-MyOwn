using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж���չ�����ֵ�Ƿ������������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="values">Ŀ������</param>
        /// <returns>����������������Ϊtrue������Ϊfalse</returns>
        public static bool In(this char @this, params char[] values)
        {
            return Array.IndexOf(values, @this) != -1;
        }

        /// <summary>
        /// �Զ�����չ�������ж���չ�����ֵ�Ƿ񲻴�����������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="values">Ŀ������</param>
        /// <returns>����������������Ϊfalse������Ϊtrue</returns>
        public static bool NotIn(this char @this,params char[] values)
        {
            return Array.IndexOf(values,@this) == -1;
        }
    }
}