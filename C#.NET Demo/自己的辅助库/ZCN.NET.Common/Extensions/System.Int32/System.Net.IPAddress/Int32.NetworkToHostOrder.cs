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
        /// <returns>�������ֽ�˳���ʾ������ֵ</returns>
        public static int NetworkToHostOrder(this Int32 network)
        {
            return IPAddress.NetworkToHostOrder(network);
        }
    }
}