using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：创建一个新文件，在其中写入指定的字节数组，然后关闭该文件。如果目标文件已存在，则覆盖该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="bytes">要写入文件的字节</param>
        public static void WriteAllBytes(this FileInfo @this, byte[] bytes)
        {
            File.WriteAllBytes(@this.FullName, bytes);
        }
    }
}