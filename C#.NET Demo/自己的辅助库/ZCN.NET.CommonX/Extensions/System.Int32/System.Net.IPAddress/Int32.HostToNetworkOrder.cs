using System;
using System.Net;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ֵ�������ֽ�˳��ת��Ϊ�����ֽ�˳��
        /// </summary>
        /// <param name="host">��չ�����������ֽ�˳���ʾ��Ҫת��������</param>
        /// <returns>�������ֽ�˳���ʾ������ֵ</returns>
        public static int HostToNetworkOrder(this Int32 host)
        {
            return IPAddress.HostToNetworkOrder(host);
        }
    }
}