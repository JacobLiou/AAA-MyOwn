namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///  RSA 密钥格式
    /// </summary>
    public enum RSAKeyType
    {
        /// <summary>
        ///  xml 格式(DotNet支持的格式)
        /// </summary>
        XML,

        /// <summary>
        ///  PME 格式(Java或其他编程语言支持的格式)
        /// </summary>
        PEM
    }
}