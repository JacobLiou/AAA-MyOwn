namespace ZCN.NET.Common
{
    /// <summary>
    ///  ZCN.NET 程序集版本号
    /// </summary>
    public class ZCN_NET_SDK
    {
        /// <summary>
        /// 目标框架
        /// </summary>
#if NET20
    public const string RTFX = "NET20";
#elif NET35
    public const string RTFX = "NET35";
#elif NET40
    public const string RTFX = "NET40";
#elif NET45
    public const string RTFX = "NET45";
#elif NET46
    public const string RTFX = "NET46";
#elif NET47
    public const string RTFX = "NET47";
#elif NET48
    public const string RTFX = "NET48";
#elif NetCore
    public const string RTFX = "NETCore";
#elif WINDOWS_UWP
    public const string RTFX = "UWP";
#else
        public const string RTFX = "UNKNOWN";
#endif

        /// <summary>
        /// SDK名称
        /// </summary>
        public const string ALIAS = "ZCN.NET.CommonX";

        /// <summary>
        /// SDK 版本号
        /// </summary>
        public const string VERSION = "1.0.0.0";
    }
}