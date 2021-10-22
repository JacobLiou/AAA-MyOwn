using CefSharp;
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

namespace CefSharpDemo
{
	 /// <cefSharp:ChromiumWebBrowser Grid.Row="1"
     /// Address="{Binding BrowserAddress, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}"
     /// Title="{Binding BrowserTitle, Mode=OneWay, UpdateSourceTrigger=PropertyChanged}"
     /// Name="browser" />
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Cef.Initialize(new Settings { LogSeverity = LogSeverity.Disable, PackLoadingDisabled = true });

            InitializeComponent();

            //browser.Address = "http://bing.com";

            browser.Address = @"E:\文档\软件文档\agilent-86100a_manual.pdf";


            ///浏览器的通知事件
            browser.StatusMessage += BrowserStatusMessage;
            browser.NavStateChanged += BrowserNavStateChanged;

        }


        // https://www.codeproject.com/Articles/887148/Display-HTML-in-WPF-and-CefSharp-Tutorial-Part-2
    }
}
