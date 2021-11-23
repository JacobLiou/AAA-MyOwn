using System.Drawing;
using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /* 目前.Net Core上没有 System.Drawing 这个类库。
         * 可以使用 System.Drawing.Common 、ImageProcessor、CoreCompat 等代替
         */

        /// <summary>
        /// 自定义扩展方法：将 8 位无符号整数的数组转换为图像
        /// </summary>
        /// <param name="this">扩展对象。8 位无符号整数的数组</param>
        /// <returns></returns>
        public static Image ToImage(this byte[] @this)
        {
            using (var ms = new MemoryStream(@this))
            {
                return Image.FromStream(ms);
            }
        }
    }
}