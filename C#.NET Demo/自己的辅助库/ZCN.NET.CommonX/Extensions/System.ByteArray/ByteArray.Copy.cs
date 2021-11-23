using System.IO;

using ZCN.NET.CommonX.Utils;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   复制字节数据
        /// </summary>
        /// <param name="input">输入字节数组</param>
        /// <param name="output">输出字节数组</param>
        /// <param name="outputOffset">字节偏移位置</param>
        public static void Copy(this byte[] input, byte[] output, long outputOffset)
        {
            StreamUtils.Copy(input, output, outputOffset);
        }

        /// <summary>
        ///  向当前流中写入字节序列，并将此流中的当前位置提升写入的字节数
        /// </summary>
        /// <param name="input">字节数组(输入)</param>
        /// <param name="output">流(输出)</param>
        /// <exception cref="IOException">if an I/O problem occurs</exception>		
        public static void Copy(this byte[] input, Stream output)
        {
            StreamUtils.Copy(input, output);
        }

        /// <summary>
        ///   使用操作系统默认的编码方式将输入中的字节复制并转换为 streamwriter 上的字符
        /// </summary>
        /// <param name="input">字节数组(输入)</param>
        /// <param name="outputWriter">流(输出)</param>
        /// <exception cref="IOException">in the case of an I/O problem</exception>
        public static void Copy(this byte[] input, StreamWriter outputWriter)
        {
            StreamUtils.Copy(input, outputWriter);
        }

        /// <summary>
        ///  将指定的编码方式将输入中的字节复制并转换为 streamwriter 上的字符
        /// <see cref="StreamWriter"/>.
        /// </summary>
        /// <param name="input">字节数组(输入)</param>
        /// <param name="outputWriter">流(输出)</param>
        /// <param name="encoding">编码方式</param>
        public static void Copy(this byte[] input, StreamWriter outputWriter, string encoding)
        {
            StreamUtils.Copy(input, outputWriter, encoding);
        }
    }
}