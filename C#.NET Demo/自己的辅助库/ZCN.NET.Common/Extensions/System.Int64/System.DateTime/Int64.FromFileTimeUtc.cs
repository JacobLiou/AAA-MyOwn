using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ�� Windows �ļ�ʱ��ת��Ϊ��Ч�� UTC ʱ��
        /// </summary>
        /// <param name="fileTime">��չ�����Լ�ʱ���ڱ�ʾ�� Windows �ļ�ʱ��</param>
        /// <returns></returns>
        public static DateTime FromFileTimeUtc(this Int64 fileTime)
        {
            return DateTime.FromFileTimeUtc(fileTime);
        }
    }
}