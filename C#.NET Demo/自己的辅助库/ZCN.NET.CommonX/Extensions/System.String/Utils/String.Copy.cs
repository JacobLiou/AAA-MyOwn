using System;
using System.IO;

using ZCN.NET.CommonX.Utils;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  将字符串中的字符序列化为输出上的字节，然后刷新输出。
        /// </summary>
        /// <param name="input">字符串输入</param>
        /// <param name="output"><see cref="Stream"/>输出</param>  
        /// <exception cref="IOException">an I/O problem occurs</exception>
        public static void Copy(this String input, Stream output)
        {
            StreamUtils.Copy(input, output);
        }

        /// <summary>
        ///  将字符从a<see cref="String"/>复制到a<see cref="StreamWriter"/>
        /// </summary>
        /// <param name="input">字符串输入</param>
        /// <param name="output"><see cref="StreamWriter"/>输出</param>  
        /// <exception cref="IOException">an I/O problem occurs</exception>      
        public static void Copy(String input, StreamWriter output)
        {
            StreamUtils.Copy(input, output);
        }
    }
}