using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DynamicWallpaper
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

        /// <summary>
        /// 显示视频
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = "video"; // Default file name
            dialog.DefaultExt = ".mp4"; // Default file extension
            dialog.Filter = "Video Files (.mp4)|*.mp4"; // Filter files by extension
            if (dialog.ShowDialog() == true)
            {
                Media.Source = new Uri(dialog.FileName);
            }
        }

        //动态壁纸  首先将视频分解 然后采用定时器不断的去设置静态背景 达到动态效果 ？？？
        //这个我是不是已经历练过了？


        /// <summary>
        /// 设置动态壁纸
        /// 这里采用Win32 API进行操作 也有注册表方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetBackgroundBtn_Click(object sender, RoutedEventArgs e)
        {

            //WallpaperInterOp.SetWallPaperFromImage(@"E:\Files\图片区\18747362.jpg", WallpaperInterOp.Style.Stretched);
        }
    }
}
