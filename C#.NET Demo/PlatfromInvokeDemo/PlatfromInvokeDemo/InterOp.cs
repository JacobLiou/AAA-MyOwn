using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PlatfromInvokeDemo
{
    class InterOp
    {
        [DllImport("user32.dll", PreserveSig = true, CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, string text, string caption, uint tupe);
        

    }
}
