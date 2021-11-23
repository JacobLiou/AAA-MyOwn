using System;
using System.Net;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将短值由网络字节顺序转换为主机字节顺序
        /// </summary>
        /// <param name="network">扩展对象。以网络字节顺序表示的要转换的数字</param>
        /// <returns>以主机字节顺序表示的长值</returns>
        public static Int64 NetworkToHostOrder(this Int64 network)
        {
            return IPAddress.NetworkToHostOrder(network);
        }
    }
}