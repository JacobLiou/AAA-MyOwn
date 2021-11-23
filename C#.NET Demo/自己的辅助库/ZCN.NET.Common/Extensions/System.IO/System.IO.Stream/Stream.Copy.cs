using System;
using System.IO;

using ZCN.NET.Common.Utils;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        public const int DEFAULT_BUFFER_SIZE = 1024 * 4;

        /// <summary>自定义扩展方法：将输入中的整个内容复制到输出中.</summary>
        /// <param name="input">流(输入)</param>
        /// <param name="output">流(输出)</param> 
        /// <returns>复制的字节数</returns>
        /// <exception cref="IOException">if an I/O problem occurs</exception>		
        public static int Copy(this Stream input, Stream output)
        {
            return StreamUtils.Copy(input, output, false);
        }

        /// <summary>自定义扩展方法：将输入中的内容复制到输出中</summary>
        /// <param name="input">流(输入)</param>
        /// <param name="output">流(输出)</param>
        /// <param name="copyFromBeginning">将true设置为从输入流的开头复制，例如input.position=0，否则，它将从输入流中的当前位置开始复制。 </param>
        /// <returns>复制的字节数</returns>
        /// <exception cref="IOException">if an I/O problem occurs</exception>
        public static int Copy(this Stream input, Stream output, bool copyFromBeginning)
        {
            return StreamUtils.Copy(input, output, copyFromBeginning);
        }

        /// <summary>
        ///  自定义扩展方法：使用操作系统默认的编码方式将输入中的字节复制并转换为 streamwriter上的字符
        /// </summary>
        /// <param name="inputStream">流(输入)
        /// </param>
        /// <param name="outputStreamWriter">StreamWriter 对象(输出)
        /// </param>
        /// <exception cref="IOException">if an I/O problem occurs</exception>
        public static int Copy(this Stream inputStream, StreamWriter outputStreamWriter)
        {
            return StreamUtils.Copy(inputStream, outputStreamWriter);
        }

        /// <summary>
        ///  自定义扩展方法：将指定的编码方式将输入中的字节复制并转换为 streamwriter上的字符
        /// </summary>
        /// <param name="inputStream"></param>
        /// <param name="outputWriter"></param>
        /// <param name="encoding">编码方式</param>
        /// <exception cref="IOException">an I/O problem occurs</exception>
        public static int Copy(this Stream inputStream, StreamWriter outputWriter, String encoding)
        {
            return StreamUtils.Copy(inputStream, outputWriter, encoding);
        }

        /// <summary>
        ///  自定义扩展方法：将源中的确切字节数<see cref="Stream"/>复制到目标中<see cref="Stream"/>。
        /// </summary>
        /// <param name="source">源 <see cref="Stream"/></param>
        /// <param name="target">目标 <see cref="Stream"/></param>
        /// <param name="len">要复制的字节数</param>        
        /// <exception cref="IOException">if the source stream does not have enough data.</exception>
        public static void CopyExact(this Stream source, Stream target, int len)
        {
            StreamUtils.CopyExact(source, target, len);
        }

        /// <summary>
        ///  自定义扩展方法：将源流中任何位置的指定字节数读取到特定起始索引位置的特定字节数组中。字节数组必须具有读取所需流部分所需的大小。
        /// </summary>
        /// <param name="source">要读取的源流</param>
        /// <param name="target">要写入的目标字节数组</param>
        /// <param name="targetOffset">目标中的偏移索引</param>
        /// <param name="sourceOffset">流中的偏移位置</param>
        /// <param name="bytesToRead">要在流中读取的字节数</param>
        public static void ReadExact(this Stream source, byte[] target, int sourceOffset, int targetOffset, int bytesToRead)
        {
            StreamUtils.ReadExact(source, target, sourceOffset, targetOffset, bytesToRead);
        }

        /// <summary>
        ///  自定义扩展方法：从偏移位置开始读取流的部分段。
        /// </summary>
        /// <param name="source">要读取的源流</param>
        /// <param name="sourceOffset">流中的起始偏移位置。如果要从头读取流，则设置为0</param>
        /// <param name="bytesToRead">要在流中读取的字节数</param>
        /// <returns>return partial segment as an array of bytes.</returns>
        public static byte[] ReadPartial(this Stream source, long sourceOffset, long bytesToRead)
        {
            return StreamUtils.ReadPartial(source, sourceOffset, bytesToRead);
        }

        /// <summary>
        ///  自定义扩展方法：将数据读取到一个完整的数组中。如果流首先耗尽数据，或者如果IOException自然发生，引发EndOfStreamException。
        /// </summary>
        /// <param name="stream">从中读取数据的流</param>
        /// <param name="byteArray">要读取字节的数组。数组将从流中完全填充，因此必须给出适当的大小。</param>
        public static void ReadIntoByteArray(this Stream stream, byte[] byteArray)
        {
            StreamUtils.ReadIntoByteArray(stream, byteArray);
        }

        /// <summary>
        ///  自定义扩展方法：从流的开头读取数据，直到到达结尾。数据作为字节数组返回。(这种读取流的方法效率不太高)
        /// <para>如果您事先不知道流的长度（例如网络流），只想将整批数据读取到一个缓冲区中，请使用此方法。</para>
        /// </summary>
        /// <param name="stream">从中读取数据的流</param>
        /// <exception cref="IOException">在任何基础IO调用失败时引发</exception>
        public static byte[] GetBytes(this Stream stream)
        {
            return StreamUtils.GetBytes(stream);
        }

        /// <summary>
        ///  自定义扩展方法：从流中读取数据，直到到达结尾。这个数据作为字节数组返回。
        /// <para>如果知道要开始的数据的预期长度，请使用此方法获取数据</para>
        /// </summary>
        /// <param name="stream">从中读取数据的流</param>
        /// <param name="initialLength">初始缓冲区长度。如果长度小于1，则设置为<see cref="Int16.MaxValue"/> 
        /// </param>
        /// <exception cref="IOException">如果任何基础IO调用失败，则引发异常</exception>
        public static byte[] GetBytes(this Stream stream, long initialLength)
        {
            return StreamUtils.GetBytes(stream, initialLength);
        }

        /// <summary>
        ///  自定义扩展方法：从数据流返回一个ASCII字符串
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static string GetAsciiString(this Stream stream)
        {
            return StreamUtils.GetAsciiString(stream);
        }

        /// <summary>
        ///  自定义扩展方法：从数据流返回一个utf8编码的字符串
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static string GetString(this Stream stream)
        {
            return StreamUtils.GetString(stream);
        }

        /// <summary>
        ///  自定义扩展方法：尝试跳过输入流中的字节，并返回跳过的实际字节数。
        /// </summary>
        /// <param name="stream">将用于跳过字节的输入流</param>
        /// <param name="skipBytes">要跳过的字节数</param>
        /// <returns>当前字节数</returns>
        public static int Skip(this Stream stream, int skipBytes)
        {
            return StreamUtils.Skip(stream, skipBytes);
        }
    }
}