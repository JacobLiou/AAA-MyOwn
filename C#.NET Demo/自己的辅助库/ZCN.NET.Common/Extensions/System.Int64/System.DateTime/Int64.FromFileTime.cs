using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ�� Windows �ļ�ʱ��ת��Ϊ��Ч�ı���ʱ��
        /// </summary>
        /// <param name="fileTime">��չ�����Լ�ʱ���ڱ�ʾ�� Windows �ļ�ʱ��</param>
        /// <returns></returns>
        public static DateTime FromFileTime(this Int64 fileTime)
        {
            return DateTime.FromFileTime(fileTime);
        }
    }
}