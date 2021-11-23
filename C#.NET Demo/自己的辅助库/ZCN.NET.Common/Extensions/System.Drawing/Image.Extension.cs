using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：裁剪图片
        /// </summary>
        /// <param name="this"></param>
        /// <param name="width">需要裁剪的宽度</param>
        /// <param name="height">需要裁剪的高度</param>
        /// <param name="x">从源原始图片的横坐标x位置开始裁剪</param>
        /// <param name="y">从源原始图片的纵坐标y位置开始裁剪</param>
        /// <returns></returns>
        public static Image Cut(this Image @this, int width, int height, int x, int y)
        {
            var r = new Bitmap(width, height);
            var destinationRectangle = new Rectangle(0, 0, width, height);
            var sourceRectangle = new Rectangle(x, y, width, height);

            using (Graphics g = Graphics.FromImage(r))
            {
                g.DrawImage(@this, destinationRectangle, sourceRectangle, GraphicsUnit.Pixel);
            }
            
            return r;
        }

        /// <summary>
        ///  自定义扩展方法：按比例缩放图片
        /// </summary>
        /// <param name="this"></param>
        /// <param name="ratio">缩放比例</param>
        /// <returns></returns>
        public static Image Scale(this Image @this, double ratio)
        {
            int width = Convert.ToInt32(@this.Width * ratio);
            int height = Convert.ToInt32(@this.Height * ratio);

            var image = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(image))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(@this, 0, 0, width, height);
            }

            return image;
        }

        /// <summary>
        ///    自定义扩展方法：按指定的宽高缩放图片
        /// </summary>
        /// <param name="this"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Image Scale(this Image @this, int width, int height)
        {
            var image = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(image))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(@this, 0, 0, width, height);
            }

            return image;
        }
    }
}