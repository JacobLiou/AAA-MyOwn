using System;
using System.Net;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ֵ�������ֽ�˳��ת��Ϊ�����ֽ�˳��
        /// </summary>
        /// <param name="host">��չ�����������ֽ�˳���ʾ��Ҫת��������</param>
        /// <returns>�������ֽ�˳���ʾ�Ķ�ֵ</returns>
        public static Int16 HostToNetworkOrder(this Int16 host)
        {
            return IPAddress.HostToNetworkOrder(host);
        }
    }
}