using System;
using System.Drawing;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������� OLE ��ɫֵ����� GDI+ System.Drawing.Color �ṹ
        /// </summary>
        /// <param name="oleColor">��չ����Ҫ����� OLE ��ɫ</param>
        /// <returns></returns>
        public static Color FromOle(this Int32 oleColor)
        {
            return ColorTranslator.FromOle(oleColor);
        }
    }
}