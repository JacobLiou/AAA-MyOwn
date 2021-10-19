using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Collections.Generic;
namespace MatirxRain
{
    public partial class Form1 : Form
    {

        //ConcurrentBag<string> list = new ConcurrentBag<string>();

        List<string> list = new List<string>();

        Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(list.Count >= pictureBox1.Height / 20)
            {
                list.RemoveAt(0);
            }

            list.Add(GenerateRamdomChar());

            pictureBox1.Invalidate();
        }

        const int minJpnCharCode = 0x4e00;
        const int maxJpnCharCode = 0x4f80;

        private static string GenerateRamdomChar()
        {
            var random = new Random();
            return ((char)random.Next(minJpnCharCode, maxJpnCharCode)).ToString();
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            for (int i = 0; i < list.Count; i++)
            {
                graphics.DrawString(list[list.Count - i - 1], new Font("宋体", 12), Brushes.LimeGreen, 10, i *20 + 10);
            }
            
        }
    }
}
