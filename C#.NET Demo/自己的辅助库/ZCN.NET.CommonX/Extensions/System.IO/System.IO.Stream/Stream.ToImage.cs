using System.Drawing;
using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///     自定义扩展方法：将流转换为 Image 对象
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Image ToImage(this Stream stream)
        {
            return Image.FromStream(stream);
        }
    }
}