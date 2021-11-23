using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ �� TimeSpan ת��Ϊ�����ʱ�����������磺2��9Сʱ22����17��56����
        /// </summary>
        /// <param name="timeSpan">��չ����</param>
        /// <returns></returns>
        public static string ToFullString(this TimeSpan timeSpan)
        {
            string result = "";
            if (timeSpan.Days > 0)
            {
                result = timeSpan.Days + "��";
            }
            if (timeSpan.Hours > 0)
            {
                result += timeSpan.Hours + "Сʱ";
            }
            if (timeSpan.Minutes > 0)
            {
                result += timeSpan.Hours + "����";
            }
            if (timeSpan.Seconds > 0)
            {
                result += timeSpan.Seconds + "��";
            }
            if (timeSpan.Milliseconds > 0)
            {
                result += timeSpan.Milliseconds + "����";
            }

            return result;
        }
    }
}