using System.IO;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        /// <summary>
        ///  自定义扩展方法：将内存流写入二进制数组并返回
        /// </summary>
        /// <param name="this">扩展对象。流对象</param>
        /// <returns></returns>
        public static byte[] ToByteArray(this Stream @this)
        {
            using(var ms = new MemoryStream())
            {
                @this.CopyTo(ms);

                return ms.ToArray();
            }
        }
    }
}