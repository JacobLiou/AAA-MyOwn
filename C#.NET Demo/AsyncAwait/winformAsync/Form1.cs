using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace winformAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Trace.Write(Thread.CurrentThread.ManagedThreadId);

            //this.button1.Click += this.button2_Click;
            this.button1.Click += this.button1_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trace.Write(Thread.CurrentThread.ManagedThreadId);

            // This line will yield control to the UI while CalculateDamageDone()
            // performs its work. The UI thread is free to perform other work.           
            button1.Text = CalculateDamageDone();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Trace.Write(Thread.CurrentThread.ManagedThreadId);
            // This line will yield control to the UI while CalculateDamageDone()
            // performs its work. The UI thread is free to perform other work.
            var damageResult = await Task.Run(() => CalculateDamageDone());
            button1.Text = damageResult;
        }

        private string CalculateDamageDone()
        {
            Trace.Write(Thread.CurrentThread.ManagedThreadId);
            // Code omitted:
            //
            // Does an expensive calculation and returns
            // the result of that calculation.

            Task.Delay(6000).Wait();
            return "Done";
        }
    }
}
