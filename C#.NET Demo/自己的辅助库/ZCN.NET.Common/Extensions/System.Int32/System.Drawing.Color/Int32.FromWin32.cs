using System;
using System.Drawing;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �� Windows ��ɫֵ����� GDI+ System.Drawing.Color �ṹ
        /// </summary>
        /// <param name="win32Color">��չ����Ҫ����� Windows ��ɫ</param>
        /// <returns></returns>
        public static Color FromWin32(this Int32 win32Color)
        {
            return ColorTranslator.FromWin32(win32Color);
        }
    }
}