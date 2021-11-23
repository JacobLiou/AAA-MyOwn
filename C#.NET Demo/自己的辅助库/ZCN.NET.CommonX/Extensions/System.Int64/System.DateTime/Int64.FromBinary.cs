using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �����л�һ�� 64 λ������ֵ�������´������л��� System.DateTime ��ʼ����
        /// </summary>
        /// <param name="dateData">��չ����64 λ�з������������� 2 λ�ֶε� System.DateTime.Kind �����Լ� 
        /// 62 λ�ֶε� System.DateTime.Ticks ���Խ����˱���</param>
        /// <returns></returns>
        public static DateTime FromBinary(this Int64 dateData)
        {
            return DateTime.FromBinary(dateData);
        }
    }
}