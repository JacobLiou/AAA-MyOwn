//#if NETFRAMEWORK

//using System;

//namespace ZCN.NET.CommonX.Extensions
//{
//    public static partial class CommonExtensions
//    {
//        /// <summary>
//        ///  自定义扩展方法：为指定类型和 URL 所指示的已知对象创建一个代理
//        /// </summary>
//        /// <param name="type">扩展对象。希望连接到的已知对象的类型</param>
//        /// <param name="url">已知对象的 URL</param>
//        /// <returns>一个代理，它指向由所请求的已知对象服务的终结点</returns>
//        public static object GetObject(this Type type,string url)
//        {
//            return Activator.GetObject(type, url);
//        }

//        /// <summary>
//        ///  自定义扩展方法：为指定类型、URL 和通道数据所指示的已知对象创建一个代理
//        /// </summary>
//        /// <param name="type">扩展对象。希望连接到的已知对象的类型</param>
//        /// <param name="url">已知对象的 URL</param>
//        /// <param name="state">通道特定的数据或 null</param>
//        /// <returns>一个代理，它指向由所请求的已知对象服务的终结点</returns>
//        public static object GetObject(this Type type, string url,object state)
//        {
//            return Activator.GetObject(type, url, state);
//        }
//    }
//}

//#endif