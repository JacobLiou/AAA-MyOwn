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
using System.Windows.Shapes;

namespace 做控件_WPF_Winform_前端绘制本质_WEB框架和组件
{
    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();


            AddRadarMiddle();

        }

        private void AddRadarMiddle()
        {
            Polygon polygon = new Polygon();
            polygon.Fill = Brushes.Blue;
            polygon.Points.Add(GetPosition(Button1));
            polygon.Points.Add(GetPosition(Button2));
            polygon.Points.Add(GetPosition(Button3));
            polygon.Points.Add(GetPosition(Button4));
            MyCanvas.Children.Add(polygon);
        }

        private Point GetPosition(Visual visual)
        {
            Point point = new Point();
            point.Y = (double)visual.GetValue(Canvas.TopProperty);
            point.X = (double)visual.GetValue(Canvas.LeftProperty);
            return point;
        }

        /// <summary>
        /// 鼠标拖拽移动这个点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button1_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Button1_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
