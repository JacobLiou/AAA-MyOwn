using System;
using System.Net;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ֵ�������ֽ�˳��ת��Ϊ�����ֽ�˳��
        /// </summary>
        /// <param name="network">��չ�����������ֽ�˳���ʾ��Ҫת��������</param>
        /// <returns>�������ֽ�˳���ʾ�ĳ�ֵ</returns>
        public static Int64 NetworkToHostOrder(this Int64 network)
        {
            return IPAddress.NetworkToHostOrder(network);
        }
    }
}