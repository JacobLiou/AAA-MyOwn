using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������������ָ���� OLE �Զ������ڵ�Ч�� System.DateTime
        /// </summary>
        /// <param name="d">��չ����˫���ȸ�����</param>
        /// <returns>��˫���ȸ�������ͬ�����ں�ʱ��</returns>
        public static DateTime FromOADate(this double d)
        {
            return DateTime.FromOADate(d);
        }
    }
}