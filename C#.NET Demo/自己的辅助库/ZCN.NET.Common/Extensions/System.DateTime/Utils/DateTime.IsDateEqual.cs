using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�2�������Ƿ����
        /// </summary>
        /// <param name="date">��չ��������ʱ��</param>
        /// <param name="dateToCompare">Ŀ������ʱ��</param>
        /// <returns></returns>
        public static bool IsDateEqual(this DateTime date, DateTime dateToCompare)
        {
            return (date.Date == dateToCompare.Date);
        }
    }
}