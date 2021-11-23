using System.IO;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///      自定义扩展方法：将内存流从开始到末位写入字符串并返回
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string ToString2(this Stream @this)
        {
            using(var sr = new StreamReader(@this, Encoding.Default))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        ///     自定义扩展方法：将指定编码格式将内存流从开始到末位写入字符串并返回
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoding">指定的编码格式</param>
        /// <returns></returns>
        public static string ToString2(this Stream @this, Encoding encoding)
        {
            using(var sr = new StreamReader(@this, encoding))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        ///     自定义扩展方法：将内存流从指定的位置到末位写入字符串并返回
        /// </summary>
        /// <param name="this"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static string ToString2(this Stream @this, long position)
        {
            @this.Position = position;
            
            using (var sr = new StreamReader(@this, Encoding.Default))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        ///     自定义扩展方法：将指定编码格式将内存流从指定的位置到末位写入字符串并返回
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoding"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static string ToString2(this Stream @this, Encoding encoding, long position)
        {
            @this.Position = position;

            using(var sr = new StreamReader(@this, encoding))
            {
                return sr.ReadToEnd();
            }
        }
    }
}