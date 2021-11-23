﻿using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Web;

#if NETSTANDARD

using Microsoft.AspNetCore.Http;

#endif

namespace ZCN.NET.Common.Http
{
    /// <summary>
    ///   网络操作工具类
    /// </summary>
    public static class NetworkUtils
    {
        [DllImport("wininet")]
        private extern static bool InternetGetConnectedState(out int connectionDescription, int reservedValue);

        /// <summary> 
        ///   检测本机是否联网 
        /// </summary> 
        /// <returns></returns> 
        public static bool IsLocalConnectedInternet()
        {
            int i;
            return InternetGetConnectedState(out i, 0);
        }

#if NETFRAMEWORK

        /// <summary>
        ///  提取开启代理/cdn服务后的客户端真实IP
        /// </summary>
        /// <returns></returns>
        public static string GetRealIp()
        {
            string ip;
            string xForwardedFor = HttpContext.Current.Request.Headers["X-Forwarded-For"];
            if (!string.IsNullOrWhiteSpace(xForwardedFor))
            {
                ip = xForwardedFor;
            }
            else
            {
                string cfConnectingIp = HttpContext.Current.Request.Headers["CF-Connecting-IP"];
                ip = !string.IsNullOrWhiteSpace(cfConnectingIp) ? cfConnectingIp : HttpContext.Current.Request.UserHostAddress;
            }
            return ip;
        }

#endif

        /// <summary>
        ///  检测本地网络是否能正常访问到远程主机或者服务器。访问正常时返回true，否则返回false
        /// </summary>
        /// <param name="ip">远程主机的名称</param>
        /// <param name="port">远程主机的端口号</param>
        /// <returns></returns>
        public static bool CheckConnect(string ip, int port)
        {
            bool flag;

            try
            {
                TcpClient client = new TcpClient();
                var connect = client.BeginConnect(ip, port, null, null);
                flag = connect.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1)); //TimeSpan.FromSeconds(1) 表示测试连接1秒，即超时时间
                client.Close();
            }
            catch
            {
                flag = false;
            }


            return flag;
        }
    }
}