using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ�����ֵļ������Ƿ�Ϊ�������� (System.Single.NaN) ��ֵ
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns>������Ϊ System.Single.NaN����Ϊ true������Ϊ false</returns>
        public static bool IsNaN(this float d)
        {
            return Single.IsNaN(d);
        }
    }
}