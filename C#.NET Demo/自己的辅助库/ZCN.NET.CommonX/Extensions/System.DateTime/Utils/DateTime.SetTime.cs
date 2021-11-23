using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ��������ʱ������ָ����Сʱ
        /// </summary>
        /// <param name="current">��չ��������ʱ��</param>
        /// <param name="hour">Сʱ��</param>
        /// <returns></returns>
        public static DateTime SetTime(this DateTime current, int hour)
        {
            return SetTime(current, hour, 0, 0, 0);
        }

        /// <summary>
        /// �Զ�����չ��������ָ��������ʱ������ָ����Сʱ����
        /// </summary>
        /// <param name="current">��չ��������ʱ��</param>
        /// <param name="hour">Сʱ��</param>
        /// <param name="minute">������</param>
        /// <returns></returns>
        public static DateTime SetTime(this DateTime current, int hour, int minute)
        {
            return SetTime(current, hour, minute, 0, 0);
        }

        /// <summary>
        /// �Զ�����չ��������ָ��������ʱ������ָ����Сʱ������
        /// </summary>
        /// <param name="current">��չ��������ʱ��</param>
        /// <param name="hour">Сʱ��</param>
        /// <param name="minute">������</param>
        /// <param name="second">��</param>
        /// <returns></returns>
        public static DateTime SetTime(this DateTime current, int hour, int minute, int second)
        {
            return SetTime(current, hour, minute, second, 0);
        }

        /// <summary>
        /// �Զ�����չ��������ָ��������ʱ������ָ����Сʱ���������
        /// </summary>
        /// <param name="current">��չ��������ʱ��</param>
        /// <param name="hour">Сʱ��</param>
        /// <param name="minute">������</param>
        /// <param name="second">��</param>
        /// <param name="millisecond">����</param>
        /// <returns></returns>
        public static DateTime SetTime(this DateTime current, int hour, int minute, int second, int millisecond)
        {
            return new DateTime(current.Year, current.Month, current.Day, hour, minute, second, millisecond);
        }
    }
}