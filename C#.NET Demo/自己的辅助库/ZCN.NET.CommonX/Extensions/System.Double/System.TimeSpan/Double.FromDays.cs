using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ر�ʾָ�������� System.TimeSpan�����ж�������ָ����ȷ����ӽ��ĺ���
        /// </summary>
        /// <param name="value">��չ��������</param>
        /// <returns></returns>
        public static TimeSpan FromDays(this double value)
        {
            return TimeSpan.FromDays(value);
        }
    }
}