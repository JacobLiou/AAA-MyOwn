using System.IO;

using ZCN.NET.CommonX.Utils;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 将<see cref="StreamReader"/>中的字符序列化为输出上的字节，然后刷新输出。
        /// </summary>
        /// <param name="inputReader"><see cref="StreamReader"/>输入</param>
        /// <param name="output"><see cref="Stream"/>输出</param>
        /// <exception cref="IOException">an I/O problem occurs</exception>
        public static void Copy(this StreamReader inputReader, Stream output)
        {
            StreamUtils.Copy(inputReader, output);
        }

        /// <summary>将字符从<see cref="StreamReader"/>复制到<see cref="StreamWriter"/></summary>
        /// <param name="inputStreamReader"><see cref="StreamReader"/>输入</param>
        /// <param name="outputStreamWriter"><see cref="StreamWriter"/>输出/// </param>
        /// <returns>复制的字符数</returns>        
        /// <exception cref="IOException">if an I/O problem occurs</exception>
        public static int Copy(this StreamReader inputStreamReader, StreamWriter outputStreamWriter)
        {
            return StreamUtils.Copy(inputStreamReader, outputStreamWriter);
        }

        /// <summary>
        /// 将给定数量的字符跳过到给定的流中。
        /// </summary>
        /// <param name="stream">完成跳过操作的流</param>
        /// <param name="number">要跳过的字符数</param>
        /// <returns>跳过的字符数</returns>
        public static long Skip(StreamReader stream, long number)
        {
            return StreamUtils.Skip(stream, number);
        }

        /// <summary>
        ///  将给定数量的字符跳过到给定的StringReader中
        /// </summary>
        /// <param name="strReader">跳过的 StringReader 对象</param>
        /// <param name="number">要跳过的字符数</param>
        /// <returns>跳过的字符数。</returns>
        public static long Skip(StringReader strReader, long number)
        {
            return StreamUtils.Skip(strReader, number);
        }
    }
}