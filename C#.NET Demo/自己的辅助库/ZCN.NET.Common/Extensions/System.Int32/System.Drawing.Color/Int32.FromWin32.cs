using System;
using System.Drawing;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 将 Windows 颜色值翻译成 GDI+ System.Drawing.Color 结构
        /// </summary>
        /// <param name="win32Color">扩展对象。要翻译的 Windows 颜色</param>
        /// <returns></returns>
        public static Color FromWin32(this Int32 win32Color)
        {
            return ColorTranslator.FromWin32(win32Color);
        }
    }
}