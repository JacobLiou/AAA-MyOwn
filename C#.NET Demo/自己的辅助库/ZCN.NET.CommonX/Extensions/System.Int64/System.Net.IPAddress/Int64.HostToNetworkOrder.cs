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
        /// <returns>�������ֽ�˳���ʾ�ĳ�ֵ</returns>
        public static Int64 HostToNetworkOrder(this Int64 host)
        {
            return IPAddress.HostToNetworkOrder(host);
        }
    }
}