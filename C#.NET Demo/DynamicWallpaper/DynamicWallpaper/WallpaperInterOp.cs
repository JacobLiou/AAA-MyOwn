using Microsoft.Win32;
using System;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace DynamicWallpaper
{
    internal sealed class WallpaperInterOp
    {
        private WallpaperInterOp() { }

        private const int SPI_SETDESKWALLPAPER = 20;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public enum Style : int
        {
            Tiled,
            Centered,
            Stretched
        }

        /// <summary>
        /// 从网络下载 然后设置为背景壁纸
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="style"></param>
        public static void SetWallPaperFromUri(Uri uri, Style style)
        {
            Stream stream = new HttpClient().GetStreamAsync(uri.ToString()).Result;

            System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
            string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
            img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

            SetWallPaper(style, tempPath);
        }

        /// <summary>
        /// 
        /// 正常想法是：win32API支持设置图片 我将它扩展 支持视频 对于注册表的污染非常大
        /// 
        /// 
        /// 这里有图层的概念   
        /// 
        /// 动态桌面软件原理
        //如果能把一个窗口放在桌面背景桌面图标之间，然后在自己的这个窗口播放视频或者动画，桌面就有动态效果了。
        //    作者 Gerald Degeneve 的一篇博客 Draw Behind Desktop Icons in Windows 8+ 详细描写了在桌面图标下面绘制一个窗口的方法。
        //    我是参考了这个博客实现的这个功能。
        ///// </summary>
        /// <param name="fullFileName"></param>
        /// <param name="style"></param>
        public static void SetWallPaperFromVideo(string fullFileName, Style style)
        {
            //分解Video 开启不断循环播放图片
            SetWallPaper(style, fullFileName);
        }

        public static void SetWallPaperFromImage(string fullFileName, Style style)
        {
            SetWallPaper(style, fullFileName);
        }

        private static void SetWallPaper(Style style, string tempPath)
        {
            var key = Registry.CurrentUser?.OpenSubKey(@"Control Panel\Desktop", true);
            if (style == Style.Stretched)
            {
                key?.SetValue(@"WallpaperStyle", 2.ToString());
                key?.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == Style.Centered)
            {
                key?.SetValue(@"WallpaperStyle", 1.ToString());
                key?.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == Style.Tiled)
            {
                key?.SetValue(@"WallpaperStyle", 1.ToString());
                key?.SetValue(@"TileWallpaper", 1.ToString());
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER,
                0,
                tempPath,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
    }
}
