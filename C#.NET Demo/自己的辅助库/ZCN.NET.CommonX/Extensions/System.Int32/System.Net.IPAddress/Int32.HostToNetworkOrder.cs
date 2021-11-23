using System;
using System.Net;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将短值由主机字节顺序转换为网络字节顺序
        /// </summary>
        /// <param name="host">扩展对象。以主机字节顺序表示的要转换的数字</param>
        /// <returns>以网络字节顺序表示的整数值</returns>
        public static int HostToNetworkOrder(this Int32 host)
        {
            return IPAddress.HostToNetworkOrder(host);
        }
    }
}