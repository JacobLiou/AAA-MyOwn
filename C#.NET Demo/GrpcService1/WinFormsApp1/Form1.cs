using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            webView1.LoadUrl("htttp://bing.com");
            webView1.NewWindow += WebView1_NewWindow;
            //this.Controls.Add(webView1);
        }

        private void WebView1_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
