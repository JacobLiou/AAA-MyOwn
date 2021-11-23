using System;
using System.IO;
using System.Text;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///  Stream 流操作辅助类
    /// </summary>
    public static class StreamUtils
    {
        /// <summary>默认缓存大小</summary>
        private const int DEFAULT_BUFFER_SIZE = 1024 * 4;

        #region 复制字节数据

        /// <summary>
        ///   复制字节数据
        /// </summary>
        /// <param name="input">输入字节数组</param>
        /// <param name="output">输出字节数组</param>
        /// <param name="outputOffset">字节偏移位置</param>
        public static void Copy(byte[] input, byte[] output, long outputOffset)
        {
            if (input.Length == 0) return;

            for (int i = 0; i < input.Length; i++)
            {
                output[outputOffset + i] = input[i];
            }
        }

        /// <summary>
        ///  向当前流中写入字节序列，并将此流中的当前位置提升写入的字节数
        /// </summary>
        /// <param name="input">字节数组(输入)</param>
        /// <param name="output">流(输出)</param>
        /// <exception cref="IOException">if an I/O problem occurs</exception>		
        public static void Copy(byte[] input, Stream output)
        {
            if (input.Length == 0) return;

            output.Write(input, 0, input.Length);
        }

        /// <summary>
        ///   使用操作系统默认的编码方式将输入中的字节复制并转换为 streamwriter 上的字符
        /// </summary>
        /// <param name="input">字节数组(输入)</param>
        /// <param name="outputWriter">流(输出)</param>
        /// <exception cref="IOException">in the case of an I/O problem</exception>
        public static void Copy(byte[] input, StreamWriter outputWriter)
        {
            MemoryStream inputStream = new MemoryStream(input);
            Copy(inputStream, outputWriter);
        }

        /// <summary>
        ///  使用指定的的编码方式将输入中的字节复制并转换为 streamwriter 上的字符
        /// <see cref="StreamWriter"/>.
        /// </summary>
        /// <param name="input">字节数组(输入)</param>
        /// <param name="outputWriter">流(输出)</param>
        /// <param name="encoding">编码方式</param>
        public static void Copy(byte[] input, StreamWriter outputWriter, string encoding)
        {
            MemoryStream inputStream = new MemoryStream(input);
            Copy(inputStream, outputWriter, encoding);
        }

        /// <summary>将输入中的整个内容复制到输出中.</summary>
        /// <param name="input">流(输入)</param>
        /// <param name="output">流(输出)</param> 
        /// <returns>复制的字节数</returns>
        /// <exception cref="IOException">if an I/O problem occurs</exception>		
        public static int Copy(Stream input, Stream output)
        {
            return Copy(input, output, false);
        }

        /// <summary>将输入中的内容复制到输出中</summary>
        /// <param name="input">流(输入)</param>
        /// <param name="output">流(输出)</param>
        /// <param name="copyFromBeginning">将true设置为从输入流的开头复制，例如input.position=0，否则，它将从输入流中的当前位置开始复制。 </param>
        /// <returns>复制的字节数</returns>
        /// <exception cref="IOException">if an I/O problem occurs</exception>
        public static int Copy(Stream input, Stream output, bool copyFromBeginning)
        {
            byte[] buffer = new byte[DEFAULT_BUFFER_SIZE];
            int bytesRead = 0;
            int len = DEFAULT_BUFFER_SIZE;
            int offset = 0;

            if (copyFromBeginning)
                input.Seek(0, SeekOrigin.Begin);

            // set it to the beginning            
            while (len > 0)
            {
                len = input.Read(buffer, offset, DEFAULT_BUFFER_SIZE);
                output.Write(buffer, 0, len);
                bytesRead += len;
            }

            return bytesRead;
        }
        #endregion

        #region  Reader -> Writer

        /// <summary>将字符从<see cref="StreamReader"/>复制到<see cref="StreamWriter"/></summary>
        /// <param name="inputStreamReader"><see cref="StreamReader"/>输入</param>
        /// <param name="outputStreamWriter"><see cref="StreamWriter"/>输出/// </param>
        /// <returns>复制的字符数</returns>        
        /// <exception cref="IOException">if an I/O problem occurs</exception>
        public static int Copy(StreamReader inputStreamReader, StreamWriter outputStreamWriter)
        {
            char[] buffer = new char[DEFAULT_BUFFER_SIZE];
            int count = 0;
            int len = DEFAULT_BUFFER_SIZE;

            while (len > 0)
            {
                len = inputStreamReader.Read(buffer, 0, DEFAULT_BUFFER_SIZE);
                outputStreamWriter.Write(buffer, 0, len);
                count += len;
            }
            return count;
        }

        #endregion

        #region  InputStream -> Writer

        /// <summary>
        ///  使用操作系统默认的编码方式将输入中的字节复制并转换为 streamwriter上的字符
        /// </summary>
        /// <param name="inputStream">流(输入)
        /// </param>
        /// <param name="outputStreamWriter">StreamWriter 对象(输出)
        /// </param>
        /// <exception cref="IOException">if an I/O problem occurs</exception>
        public static int Copy(Stream inputStream, StreamWriter outputStreamWriter)
        {
            StreamReader inputStreamReader = new StreamReader(inputStream, System.Text.Encoding.Default);
            return Copy(inputStreamReader, outputStreamWriter);
        }

        /// <summary>
        ///  使用指定的的编码方式将输入中的字节复制并转换为 streamwriter上的字符
        /// </summary>
        /// <param name="inputStream"></param>
        /// <param name="outputWriter"></param>
        /// <param name="encoding">编码方式</param>
        /// <exception cref="IOException">an I/O problem occurs</exception>
        public static int Copy(Stream inputStream, StreamWriter outputWriter, String encoding)
        {
            Encoding encode = Encoding.Default;

            try
            {
                encode = Encoding.GetEncoding(encoding);
            }
            catch
            {
                encode = Encoding.Default;
            }

            StreamReader inputStreamReader = new StreamReader(inputStream, encode);
            return Copy(inputStreamReader, outputWriter);
        }

        #endregion

        #region  Reader -> OutputStream

        /// <summary>
        /// 将<see cref="StreamReader"/>中的字符序列化为输出上的字节，然后刷新输出。
        /// </summary>
        /// <param name="inputReader"><see cref="StreamReader"/>输入</param>
        /// <param name="output"><see cref="Stream"/>输出</param>
        /// <exception cref="IOException">an I/O problem occurs</exception>
        public static void Copy(StreamReader inputReader, Stream output)
        {
            StreamWriter outputWriter = new StreamWriter(output, System.Text.Encoding.Default);
            Copy(inputReader, outputWriter);

            outputWriter.Flush();
        }

        #endregion

        /// <summary>
        /// 将字符串中的字符序列化为输出上的字节，然后刷新输出。
        /// </summary>
        /// <param name="input">字符串输入</param>
        /// <param name="output"><see cref="Stream"/>输出</param>  
        /// <exception cref="IOException">an I/O problem occurs</exception>
        public static void Copy(String input, Stream output)
        {
            byte[] inputByteArray = new ASCIIEncoding().GetBytes(input);
            StreamWriter outWriter = new StreamWriter(output, System.Text.Encoding.Default);
            Copy(inputByteArray, outWriter);

            outWriter.Flush();
        }

        /// <summary>
        ///  将字符从a<see cref="String"/>复制到a<see cref="StreamWriter"/>
        /// </summary>
        /// <param name="input">字符串输入</param>
        /// <param name="output"><see cref="StreamWriter"/>输出</param>  
        /// <exception cref="IOException">an I/O problem occurs</exception>      
        public static void Copy(String input, StreamWriter output)
        {
            output.Write(input);
        }

        /// <summary>
        ///  将源中的确切字节数<see cref="Stream"/>复制到目标中<see cref="Stream"/>。
        /// </summary>
        /// <param name="source">源 <see cref="Stream"/></param>
        /// <param name="target">目标 <see cref="Stream"/></param>
        /// <param name="len">要复制的字节数</param>        
        /// <exception cref="IOException">if the source stream does not have enough data.</exception>
        public static void CopyExact(Stream source, Stream target, int len)
        {
            byte[] buffer = new byte[DEFAULT_BUFFER_SIZE];
            int bytesRead = 0;

            while (bytesRead < len)
            {
                int sizeNeeded = Math.Min(buffer.Length, len - bytesRead);
                int readSize = source.Read(buffer, 0, sizeNeeded);

                if (readSize <= 0)
                    throw new IOException(String.Format("Underlying stream does not have enough data. Read {0} bytes, but {1} needed", readSize, sizeNeeded));

                target.Write(buffer, 0, readSize);
                bytesRead += readSize;
            }
        }

        /// <summary>
        /// 将数据读取到一个完整的数组中。如果流首先耗尽数据，或者如果IOException自然发生，引发EndOfStreamException。
        /// </summary>
        /// <param name="stream">从中读取数据的流</param>
        /// <param name="byteArray">要读取字节的数组。数组将从流中完全填充，因此必须给出适当的大小。</param>
        public static void ReadIntoByteArray(Stream stream, byte[] byteArray)
        {
            int offset = 0;
            int remaining = byteArray.Length;
            stream.Position = 0;
            while (remaining > 0)
            {
                int read = stream.Read(byteArray, offset, remaining);
                if (read <= 0)
                {
                    throw new EndOfStreamException(String.Format("End of stream reached with {0} bytes left to read", remaining));
                }
                remaining -= read;
                offset += read;
            }
        }

        /// <summary>
        ///  从流的开头读取数据，直到到达结尾。数据作为字节数组返回。(这种读取流的方法效率不太高)
        /// <para>如果您事先不知道流的长度（例如网络流），只想将整批数据读取到一个缓冲区中，请使用此方法。</para>
        /// </summary>
        /// <param name="stream">从中读取数据的流</param>
        /// <exception cref="IOException">在任何基础IO调用失败时引发</exception>
        public static byte[] GetBytes(Stream stream)
        {
            if (stream is MemoryStream)
            {
                return ((MemoryStream)stream).ToArray();
            }

            byte[] byteArray = new byte[DEFAULT_BUFFER_SIZE];
            using (MemoryStream ms = new MemoryStream())
            {
                stream.Position = 0;
                while (true)
                {
                    int readLen = stream.Read(byteArray, 0, byteArray.Length);
                    if (readLen <= 0)
                    {
                        return ms.ToArray();
                    }

                    ms.Write(byteArray, 0, readLen);
                }
            }
        }

        /// <summary>
        /// 从流中读取数据，直到到达结尾。这个数据作为字节数组返回。
        /// <para>如果知道要开始的数据的预期长度，请使用此方法获取数据</para>
        /// </summary>
        /// <param name="stream">从中读取数据的流</param>
        /// <param name="initialLength">初始缓冲区长度。如果长度小于1，则设置为<see cref="Int16.MaxValue"/> 
        /// </param>
        /// <exception cref="IOException">如果任何基础IO调用失败，则引发异常</exception>
        public static byte[] GetBytes(Stream stream, long initialLength)
        {
            // If we've been passed an unhelpful initial length, just
            // use 32K.
            if (initialLength < 1)
                initialLength = Int16.MaxValue;


            byte[] buffer = new byte[initialLength];
            int read = 0;

            int chunk;
            while ((chunk = stream.Read(buffer, read, buffer.Length - read)) > 0)
            {
                read += chunk;

                // If we've reached the end of our buffer, check to see if there's
                // any more information
                if (read == buffer.Length)
                {
                    int nextByte = stream.ReadByte();

                    // End of stream? If so, we're done
                    if (nextByte == -1)
                    {
                        return buffer;
                    }

                    // Nope. Resize the buffer, put in the byte we've just
                    // read, and continue
                    byte[] newBuffer = new byte[buffer.Length * 2];
                    Array.Copy(buffer, newBuffer, buffer.Length);
                    newBuffer[read] = (byte)nextByte;
                    buffer = newBuffer;
                    read++;
                }
            }
            // Buffer is now too big. Shrink it.
            byte[] ret = new byte[read];
            Array.Copy(buffer, ret, read);
            return ret;
        }

        /// <summary>
        ///  从数据流返回一个ASCII字符串
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static string GetAsciiString(Stream stream)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            return GetString(stream, encoding);
        }

        /// <summary>
        ///  从数据流返回一个utf8编码的字符串
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static string GetString(Stream stream)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            return GetString(stream, encoding);
        }

        /// <summary>
        /// 从数据流返回一个指定编码方式的字符串
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string GetString(Stream stream, Encoding encoding)
        {
            if (stream == null)
                return string.Empty;

            byte[] bytes = new byte[stream.Length];

            if (stream is MemoryStream)
                bytes = ((MemoryStream)stream).GetBuffer();
            else
                ReadIntoByteArray(stream, bytes);

            return encoding.GetString(bytes);
        }

        /// <summary>
        ///  将源流中任何位置的指定字节数读取到特定起始索引位置的特定字节数组中。字节数组必须具有读取所需流部分所需的大小。
        /// </summary>
        /// <param name="source">要读取的源流</param>
        /// <param name="target">要写入的目标字节数组</param>
        /// <param name="targetOffset">目标中的偏移索引</param>
        /// <param name="sourceOffset">流中的偏移位置</param>
        /// <param name="bytesToRead">要在流中读取的字节数</param>
        public static void ReadExact(Stream source, byte[] target, int sourceOffset, int targetOffset, int bytesToRead)
        {
            if (targetOffset + bytesToRead > target.Length)
            {
                throw new ArgumentException("target array to small");
            }

            int bytesRead = 0;
            source.Seek(sourceOffset, SeekOrigin.Begin);
            while (bytesRead < bytesToRead)
            {   // need more data  
                int sizeNeeded = Math.Min(DEFAULT_BUFFER_SIZE, bytesToRead - bytesRead);

                // read either the whole buffer length or                   
                // the remaining # of bytes: bytesToRead - sizeNeeded 
                int readSize = source.Read(target, (targetOffset + bytesRead), sizeNeeded);

                if (readSize <= 0)
                    throw new IOException(String.Format("Underlying stream does not have enough data. Read {0} bytes, but {1} needed", readSize, sizeNeeded));

                bytesRead += readSize;
            }
        }

        /// <summary>
        ///  从偏移位置开始读取流的部分段。
        /// </summary>
        /// <param name="source">要读取的源流</param>
        /// <param name="sourceOffset">流中的起始偏移位置。如果要从头读取流，则设置为0</param>
        /// <param name="bytesToRead">要在流中读取的字节数</param>
        /// <returns>return partial segment as an array of bytes.</returns>
        public static byte[] ReadPartial(Stream source, long sourceOffset, long bytesToRead)
        {
            long sizeDiff = source.Length - sourceOffset;
            if (bytesToRead > sizeDiff)
                throw new ArgumentException("Bytes required exceeds what is available in stream");

            byte[] target = new byte[bytesToRead];

            long bytesRead = 0;
            source.Seek(sourceOffset, SeekOrigin.Begin);

            while (bytesRead < bytesToRead)
            {   // need more data  
                int sizeNeeded = (int)Math.Min((long)DEFAULT_BUFFER_SIZE, bytesToRead - bytesRead);

                // read either the whole buffer length or                   
                // the remaining # of bytes: bytesToRead - sizeNeeded 

                int readSize = source.Read(target, 0, sizeNeeded);

                if (readSize <= 0)
                    throw new IOException(String.Format("Underlying stream does not have enough data. Read {0} bytes, but {1} needed", readSize, sizeNeeded));

                bytesRead += readSize;
            }
            return target;
        }


        /// <summary>
        ///  尝试跳过输入流中的字节，并返回跳过的实际字节数。
        /// </summary>
        /// <param name="stream">将用于跳过字节的输入流</param>
        /// <param name="skipBytes">要跳过的字节数</param>
        /// <returns>当前字节数</returns>
        public static int Skip(Stream stream, int skipBytes)
        {
            long oldPosition = stream.Position;
            long result = stream.Seek(skipBytes, SeekOrigin.Current) - oldPosition;
            return (int)result;
        }

        /// <summary>
        /// 将给定数量的字符跳过到给定的流中。
        /// </summary>
        /// <param name="stream">完成跳过操作的流</param>
        /// <param name="number">要跳过的字符数</param>
        /// <returns>跳过的字符数</returns>
        public static long Skip(StreamReader stream, long number)
        {
            long skippedBytes = 0;
            for (long index = 0; index < number; index++)
            {
                stream.Read();
                skippedBytes++;
            }
            return skippedBytes;
        }

        /// <summary>
        ///  将给定数量的字符跳过到给定的StringReader中
        /// </summary>
        /// <param name="strReader">跳过的 StringReader 对象</param>
        /// <param name="number">要跳过的字符数</param>
        /// <returns>跳过的字符数。</returns>
        public static long Skip(StringReader strReader, long number)
        {
            long skippedBytes = 0;
            for (long index = 0; index < number; index++)
            {
                strReader.Read();
                skippedBytes++;
            }
            return skippedBytes;
        }
    }
}