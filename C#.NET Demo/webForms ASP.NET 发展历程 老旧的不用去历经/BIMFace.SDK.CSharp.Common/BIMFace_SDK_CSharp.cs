namespace BIMFace.SDK.CSharp.Common
{
    public class BIMFace_SDK_CSharp
    {
        /// <summary>
        /// 目标框架
        /// </summary>
#if Net20
    public const string RTFX = "NET20";
#elif Net35
    public const string RTFX = "NET35";
#elif Net40
    public const string RTFX = "NET40";
#elif Net45
    public const string RTFX = "NET45";
#elif Net46
    public const string RTFX = "NET46";
#elif Net47
    public const string RTFX = "NET47";
#elif Net48
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
        public const string ALIAS = "SparkCN_NET_SDK";

        /// <summary>
        /// SDK 版本号
        /// </summary>
        public const string VERSION = "1.0.0.0";
    }
}