using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定 Unicode 码位转换为 UTF-16 编码字符串。
        /// 返回由一个 System.Char 对象或一个 System.Char 对象的代理项对组成的字符串，
        /// 等效于 utf32 参数所指定的码位
        /// </summary>
        /// <param name="utf32">扩展对象。21 位 Unicode 码位</param>
        /// <returns></returns>
        public static string ConvertFromUtf32(this Int32 utf32)
        {
            return Char.ConvertFromUtf32(utf32);
        }
    }
}