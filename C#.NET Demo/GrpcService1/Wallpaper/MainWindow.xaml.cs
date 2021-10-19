using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wallpaper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openFileDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true)
            {
                ImagePath.Text = openFileDlg.FileName;
                ImageContent.Source = new BitmapImage(new Uri(ImagePath.Text));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NativeWallpaperMethod.Set(ImagePath.Text);
        }
    }

    public static class NativeWallpaperMethod
    {
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public enum Style : int
        {
            Tiled,
            Centered,
            Stretched
        }

        public static void Set(string imagePath, Style style = Style.Stretched)
        {
            //System.IO.Stream s = new System.Net.WebClient().OpenRead(uri.ToString());

            //System.Drawing.Image img = System.Drawing.Image.FromStream(File.OpenRead(uri));
            //string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
            //img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            if (style == Style.Stretched)
            {
                key.SetValue(@"WallpaperStyle", 2.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == Style.Centered)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == Style.Tiled)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 1.ToString());
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER,
                0,
                imagePath,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
    }

    //public class WallpaperHelper
    //{
    //    #region fields

    //    IntPtr _currentHandler;
    //    IntPtr? _parentHandler;
    //    Rectangle _targetBounds;

    //    #region static

    //    //Dictionary<screenName,helper>
    //    static readonly Dictionary<string, WallpaperHelper> _cacheInstances = new Dictionary<string, WallpaperHelper>();
    //    static IDesktopWallpaper _desktopWallpaperAPI;
    //    static uint _slideshowTick;
    //    static IntPtr _progman;
    //    static IntPtr _workerw;
    //    static IntPtr _desktopWorkerw;

    //    #endregion

    //    #endregion

    //    #region construct

    //    //禁止外部程序集直接构造
    //    private WallpaperHelper(Rectangle bounds)
    //    {
    //        _targetBounds = bounds;
    //    }

    //    #endregion

    //    #region  public methods        

    //    public static void RestoreDefaultWallpaper()
    //    {
    //        SetDesktopWallpaper(GetDesktopWallpaper());
    //    }

    //    static string GetDesktopWallpaper()
    //    {
    //        int MAX_PATH = 260;
    //        string wallpaper = new string('\0', MAX_PATH);
    //        _ = User32Wrapper.SystemParametersInfo(User32Wrapper.SPI_GETDESKWALLPAPER, (uint)wallpaper.Length, wallpaper, 0);
    //        return wallpaper.Substring(0, wallpaper.IndexOf('\0'));
    //    }

    //    static void SetDesktopWallpaper(string filename)
    //    {
    //        _ = User32Wrapper.SystemParametersInfo(User32Wrapper.SPI_SETDESKWALLPAPER, 0, filename,
    //            User32Wrapper.SPIF_UPDATEINIFILE | User32Wrapper.SPIF_SENDWININICHANGE);
    //    }
    //    //private static string GetActiveWindowTitle()
    //    //{
    //    //    const int nChars = 256;
    //    //    StringBuilder Buff = new StringBuilder(nChars);
    //    //    IntPtr handle = User32Wrapper.GetForegroundWindow();

    //    //    if (User32Wrapper.GetWindowText(handle, Buff, nChars) > 0)
    //    //    {
    //    //        return $"handle:{handle} buff:{Buff}";
    //    //    }
    //    //    return $"handle:{handle}";
    //    //}

    //    internal static bool IsDesktop()
    //    {
    //        IntPtr hWnd = User32Wrapper.GetForegroundWindow();
    //        if (hWnd == _desktopWorkerw)
    //        {
    //            return true;
    //        }
    //        else if (hWnd == _progman)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }

    //    public void RestoreParent()
    //    {
    //        if (_parentHandler != null)
    //            User32Wrapper.SetParent(_currentHandler, _parentHandler.Value);

    //        _parentHandler = null;
    //    }

    //    public bool SendToBackground(IntPtr handler)
    //    {
    //        //处理alt+tab可以看见本程序
    //        //https://stackoverflow.com/questions/357076/best-way-to-hide-a-window-from-the-alt-tab-program-switcher
    //        int exStyle = User32Wrapper.GetWindowLong(handler, WindowLongFlags.GWL_EXSTYLE);
    //        exStyle |= (int)WindowStyles.WS_EX_TOOLWINDOW;
    //        _ = User32Wrapper.SetWindowLong(handler, WindowLongFlags.GWL_EXSTYLE, exStyle);

    //        if (handler != _currentHandler)
    //            //已经换了窗口，恢复上一个窗口
    //            RestoreParent();

    //        if (handler == IntPtr.Zero)
    //            return false;

    //        _ = User32Wrapper.GetWindowRect(handler, out _);

    //        _currentHandler = handler;

    //        _workerw = GetWorkerW();
    //        if (_workerw == IntPtr.Zero)
    //        {
    //            //有时候突然又不行了，在来一次
    //            User32Wrapper.SystemParametersInfo(User32Wrapper.SPI_SETCLIENTAREAANIMATION, 0, true, User32Wrapper.SPIF_UPDATEINIFILE | User32Wrapper.SPIF_SENDWININICHANGE);
    //            _workerw = GetWorkerW();
    //        }

    //        if (_workerw == IntPtr.Zero)
    //            return false;

    //        _parentHandler = User32Wrapper.GetParent(_currentHandler);

    //        User32Wrapper.SetParent(_currentHandler, _workerw);
    //        FullScreen(_currentHandler, new RECT(_targetBounds), _workerw);
    //        return true;
    //    }

    //    /// <summary>
    //    /// 恢复WorkerW中的所有句柄到桌面
    //    /// </summary>
    //    public static void RestoreAllHandles()
    //    {
    //        var desktop = User32Wrapper.GetDesktopWindow();
    //        var workw = GetWorkerW();
    //        var enumWindowResult = User32Wrapper.EnumChildWindows(workw, new EnumWindowsProc((tophandle, topparamhandle) =>
    //        {
    //            var txt = User32WrapperEx.GetWindowTextEx(tophandle);
    //            if (!string.IsNullOrEmpty(txt))
    //            {
    //                User32Wrapper.SetParent(tophandle, desktop);
    //            }

    //            return true;
    //        }), IntPtr.Zero);

    //        var desktopWallpaperAPI = GetDesktopWallpaperAPI();
    //        RefreshWallpaper(desktopWallpaperAPI);
    //    }

    //    /// <summary>
    //    /// 获取指定屏幕的实例
    //    /// </summary>
    //    /// <param name="screen"></param>
    //    /// <returns></returns>
    //    public static WallpaperHelper GetInstance(string screen)
    //    {
    //        if (!_cacheInstances.ContainsKey(screen))
    //        {
    //            var bounds = Screen.AllScreens.ToList().First(m => m.DeviceName == screen).Bounds;
    //            _cacheInstances.Add(screen, new WallpaperHelper(bounds));
    //        }
    //        return _cacheInstances[screen];
    //    }

    //    public static IDesktopWallpaper GetDesktopWallpaperAPI()
    //    {
    //        try
    //        {
    //            var result = DesktopWallpaperFactory.Create();
    //            return result;
    //        }
    //        catch (Exception ex)
    //        {
    //            System.Diagnostics.Debug.WriteLine(ex);
    //            return null;
    //        }
    //    }

    //    public static void DoSomeMagic()
    //    {
    //        _ = User32Wrapper.SystemParametersInfo(User32Wrapper.SPI_SETCLIENTAREAANIMATION, 0, true, User32Wrapper.SPIF_UPDATEINIFILE | User32Wrapper.SPIF_SENDWININICHANGE);
    //        _desktopWallpaperAPI = GetDesktopWallpaperAPI();
    //        _desktopWallpaperAPI?.GetSlideshowOptions(out _, out _slideshowTick);
    //        if (_slideshowTick < 86400000)
    //            _desktopWallpaperAPI?.SetSlideshowOptions(DesktopSlideshowOptions.DSO_SHUFFLEIMAGES, 1000 * 60 * 60 * 24);
    //    }

    //    public static void RestoreMagic()
    //    {
    //        _desktopWallpaperAPI?.SetSlideshowOptions(DesktopSlideshowOptions.DSO_SHUFFLEIMAGES, _slideshowTick);
    //    }

    //    #endregion

    //    #region private
    //    internal static IntPtr GetWorkerW()
    //    {
    //        _progman = User32Wrapper.FindWindow("Progman", null);
    //        User32Wrapper.SendMessageTimeout(_progman,
    //                               0x052C,
    //                               new IntPtr(0),
    //                               IntPtr.Zero,
    //                               SendMessageTimeoutFlags.SMTO_NORMAL,
    //                               1000,
    //                               out IntPtr unusefulResult);
    //        var enumWindowResult = User32Wrapper.EnumWindows(new EnumWindowsProc((tophandle, topparamhandle) =>
    //        {
    //            IntPtr shelldll_defview = User32Wrapper.FindWindowEx(tophandle,
    //                                        IntPtr.Zero,
    //                                        "SHELLDLL_DefView",
    //                                        IntPtr.Zero);
    //            if (shelldll_defview != IntPtr.Zero)
    //            {
    //                _workerw = User32Wrapper.FindWindowEx(IntPtr.Zero,
    //                                         tophandle,
    //                                         "WorkerW",
    //                                         IntPtr.Zero);

    //                _desktopWorkerw = tophandle;
    //                return false;
    //            }

    //            return true;
    //        }), IntPtr.Zero);
    //        return _workerw;
    //    }

    //    internal static void FullScreen(IntPtr mainWindowHandle, IntPtr containerHandle)
    //    {
    //        User32Wrapper.GetWindowRect(containerHandle, out RECT rect);
    //        FullScreen(mainWindowHandle, rect, containerHandle);
    //    }

    //    public static void FullScreen(IntPtr targeHandler, RECT rect, IntPtr parent)
    //    {
    //        _ = User32Wrapper.MapWindowPoints(IntPtr.Zero, parent, ref rect, 2);
    //        _ = User32WrapperEx.SetWindowPosEx(targeHandler, rect);

    //        var style = User32Wrapper.GetWindowLong(targeHandler, WindowLongFlags.GWL_STYLE);

    //        //https://stackoverflow.com/questions/2398746/removing-window-border
    //        //消除游戏边框
    //        style &= ~(int)(WindowStyles.WS_EX_TOOLWINDOW | WindowStyles.WS_CAPTION | WindowStyles.WS_THICKFRAME | WindowStyles.WS_MINIMIZEBOX | WindowStyles.WS_MAXIMIZEBOX | WindowStyles.WS_SYSMENU);
    //        _ = User32Wrapper.SetWindowLong(targeHandler, WindowLongFlags.GWL_STYLE, style);
    //    }

    //    //刷新壁纸
    //    public static IDesktopWallpaper RefreshWallpaper(IDesktopWallpaper desktopWallpaperAPI = null)
    //    {
    //        var explorer = ExplorerMonitor.ExploreProcess;
    //        if (explorer == null)
    //            return null;

    //        if (desktopWallpaperAPI == null)
    //            desktopWallpaperAPI = GetDesktopWallpaperAPI();

    //        try
    //        {
    //            desktopWallpaperAPI.Enable(false);
    //            desktopWallpaperAPI.Enable(true);
    //        }
    //        catch (Exception ex)
    //        {
    //            System.Diagnostics.Debug.WriteLine(ex);
    //        }
    //        return desktopWallpaperAPI;
    //    }

    //    #endregion
    //}
}
