using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������������
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns></returns>
        public static int Age(this DateTime @this)
        {
            if (DateTime.Today.Month < @this.Month ||
               DateTime.Today.Month == @this.Month &&
               DateTime.Today.Day < @this.Day)
            {
                return DateTime.Today.Year - @this.Year - 1;
            }

            return DateTime.Today.Year - @this.Year;
        }
    }
}