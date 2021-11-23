using System;
using System.Drawing;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 OLE 颜色值翻译成 GDI+ System.Drawing.Color 结构
        /// </summary>
        /// <param name="oleColor">扩展对象。要翻译的 OLE 颜色</param>
        /// <returns></returns>
        public static Color FromOle(this Int32 oleColor)
        {
            return ColorTranslator.FromOle(oleColor);
        }
    }
}