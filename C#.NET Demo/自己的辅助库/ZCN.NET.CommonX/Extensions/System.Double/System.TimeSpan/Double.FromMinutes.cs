using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ر�ʾָ���������� System.TimeSpan�����жԷ�������ָ����ȷ����ӽ��ĺ���
        /// </summary>
        /// <param name="value">��չ���󡣷�����</param>
        /// <returns></returns>
        public static TimeSpan FromMinutes(this double value)
        {
            return TimeSpan.FromMinutes(value);
        }
    }
}