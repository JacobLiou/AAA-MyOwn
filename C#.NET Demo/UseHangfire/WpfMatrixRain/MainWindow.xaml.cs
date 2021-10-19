using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Threading;

namespace WpfMatrixRain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer;

        WriteableBitmap writeableBitmap;

        /// <summary>
        /// As described by MSDN, DrawingVisual is a lightweight drawing class that is used to render shapes, 
        /// images, or text. This class is considered lightweight because it does not provide layout, input, focus, 
        /// or event handling, which improves its performance.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Start();
        }

        const int minJpnCharCode = 0x4e00;
        const int maxJpnCharCode = 0x4f80;

        private static string GenerateRamdomChar()
        {
            var random = new Random();
            return ((char)random.Next(minJpnCharCode, maxJpnCharCode)).ToString();

        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            //FormattedText ft = new FormattedText("ss",
            //new CultureInfo("en-us"),
            //  FlowDirection.LeftToRight,
            // new Typeface(new FontFamily("Arial"), FontStyles.Normal,
            //  FontWeights.Normal, new FontStretch()),
            //  16D,
            //  Brushes.LimeGreen);

            //DrawingVisual dv = new DrawingVisual();
            //DrawingContext dc = dv.RenderOpen();
            //dc.DrawText(ft, new Point(x, y));
            canvas.Dispatcher.BeginInvoke(() => {
                canvas.Children.Clear();

                TextBlock textBlock = new TextBlock();
                textBlock.Text = GenerateRamdomChar();
                textBlock.Foreground = new SolidColorBrush(Colors.LimeGreen);
                Canvas.SetLeft(textBlock, 10);
                Canvas.SetTop(textBlock, 10);
                canvas.Children.Add(textBlock);
            });

            image.Dispatcher.BeginInvoke(() =>
            {
                writeableBitmap = new WriteableBitmap((int)100, (int)100, 96, 96, PixelFormats.Bgr32,
                null);          

                image.Source = writeableBitmap;
            });
        }

        
    }
}
