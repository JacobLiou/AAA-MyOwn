using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_graphics_gdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Win32 API 获取绘制上下文 也就是获取窗口句柄 关联的绘制Graphics 或者创建Graphics

        //wpf XAML直接绘制
        //可以在控件模板中进行组合绘制
        //可以从Control的 OnRender进行绘制获取  DrawingContext


        // 从GUI OS开始 怎么封装图形绘制和行为定义 静态和动态   {Winforms  WPF}
        // Python Turtle绘制
        // 浏览器给出的  HTML CSS JS抽象静态和动态


        //动画 Winforms里面只能利用定时器  
        //动画 WPF良好的API StoryBoard

        protected override void OnPaint(PaintEventArgs e)
        {
        // If there is an image and it has a location, 
        // paint it when the Form is repainted.
            base.OnPaint(e);
            // if(this.picture != null && this.pictureLocation != Point.Empty)
            // {
            //     e.Graphics.DrawImage(this.picture, this.pictureLocation);
            // }

            e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), new System.Drawing.Rectangle(50, 50, 100, 100));

            // Draw a string on the PictureBox.
            e.Graphics.DrawString("This is a diagonal line drawn on the control",
                 this.Font, System.Drawing.Brushes.Blue, new Point(30,30));

            
        }
    }
}
