using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using ZCN.NET.Common.Win32;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///   图片操作工具类
    /// </summary>
	public static class ImageUtility
    {
        /// <summary>
        ///   截取操作系统的桌面并保存为图片
        /// </summary>
        /// <returns></returns>
		public static Image CaptureDesktop()
        {
            return CaptureWindow(NativeMethods.GetDesktopWindow());
        }

        /// <summary>
        ///   截取当前前台窗体句柄并保存为图片
        /// </summary>
        /// <returns></returns>
        public static Image CaptureForegroundWindow()
        {
            return CaptureWindow(NativeMethods.GetForegroundWindow());
        }

        /// <summary>
        ///  截取屏幕并保存为图片
        /// </summary>
        /// <param name="handle">句柄对象</param>
        /// <returns></returns>
		public static Image CaptureWindow(IntPtr handle)
        {
            IntPtr windowDc = NativeMethods.GetWindowDC(handle);
            IntPtr intPtr = NativeMethods.CreateCompatibleDC(windowDc);
            NativeMethods.RECT rECT = default(NativeMethods.RECT);
            NativeMethods.GetWindowRect(handle, ref rECT);
            int nWidth = rECT.Right - rECT.Left;
            int nHeight = rECT.Bottom - rECT.Top;
            IntPtr intPtr2 = NativeMethods.CreateCompatibleBitmap(windowDc, nWidth, nHeight);
            IntPtr hObject = NativeMethods.SelectObject(intPtr, intPtr2);
            NativeMethods.BitBlt(intPtr, 0, 0, nWidth, nHeight, windowDc, 0, 0, 13369376);
            NativeMethods.SelectObject(intPtr, hObject);
            NativeMethods.DeleteDC(intPtr);
            NativeMethods.ReleaseDC(handle, windowDc);
            Image result = Image.FromHbitmap(intPtr2);
            NativeMethods.DeleteObject(intPtr2);
            return result;
        }

        /// <summary>
        ///   将Image对象写入文件中
        /// </summary>
        /// <param name="image"></param>
        /// <param name="quality"></param>
        /// <param name="format"></param>
        /// <param name="fileName"></param>
        public static void ToFile(Image image, long quality, ImageFormat format, string fileName)
        {
            using (Stream stream = ToStream(image, quality, format))
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    stream.Position = 0L;
                    byte[] buffer = new byte[stream.Length];
                    int count = stream.Read(buffer, 0, (int)stream.Length);
                    fileStream.Write(buffer, 0, count);
                    fileStream.Flush();
                }
            }
        }

        /// <summary>
        ///   将图像对象转换为流
        /// </summary>
        /// <param name="image"></param>
        /// <param name="quality"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static Stream ToStream(Image image, long quality, ImageFormat format)
        {
            MemoryStream memoryStream = new MemoryStream();
            ImageCodecInfo encoder = null;
            ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
            ImageCodecInfo[] array = imageEncoders;
            for (int i = 0; i < array.Length; i++)
            {
                ImageCodecInfo imageCodecInfo = array[i];
                if (imageCodecInfo.MimeType == "image/jpeg")
                {
                    encoder = imageCodecInfo;
                }
            }
            EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, quality);
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = encoderParameter;
            image.Save(memoryStream, encoder, encoderParameters);
            return memoryStream;
        }

        /// <summary>
        ///  将Image对象转换为二进制数组
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] GetBytes(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }
    }
}
