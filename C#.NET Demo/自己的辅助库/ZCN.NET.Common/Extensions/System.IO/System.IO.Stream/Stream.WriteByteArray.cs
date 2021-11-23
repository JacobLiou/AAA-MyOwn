using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将字节序列全部写入当前流中
        /// </summary>
        /// <param name="stream">扩展对象。流对象</param>
        /// <param name="bytes">待写入的字节数组</param>
        /// <returns></returns>
        public static void WriteByteArray(this Stream stream, byte[] bytes)
        {
            stream.Write(bytes, 0, bytes.Length);
        }
    }
}