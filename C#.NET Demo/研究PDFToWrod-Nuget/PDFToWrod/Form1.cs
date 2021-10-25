using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Pdf;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PDFToWrod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate(@"E:\文档\软件文档\agilent-86100a_manual.pdf");

            //var pfile = new Aspose.Pdf.Document(@"E:\文档\软件文档\agilent-86100a_manual.pdf");
            ////pfile.Save("output.docx", Aspose.Pdf.SaveFormat.DocX);
            //pfile.Save("output.html", Aspose.Pdf.SaveFormat.Html);
        }

        /// <summary>
        /// Aspose 一个商业库
        /// 
        /// Itextsharp开源库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var text = PDFToText(@"E:\文档\软件文档\agilent-86100a_manual.pdf");
            File.WriteAllText("samplePdf.txt", text);


            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            f.OpenPdf(@"E:\文档\软件文档\agilent-86100a_manual.pdf");

            if (f.PageCount > 0)
            {
                int result = f.ToWord(@"E:\文档\软件文档\agilent-86100a_manual.docx");

                // Open Word document
                if (result == 0)
                {
                    System.Diagnostics.Process.Start(@"E:\文档\软件文档\agilent-86100a_manual.docx");
                }
            }
        }

        public string PDFToText(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            return text;
        }



        ///接到这个任务
        ///思考这个任务：首先 这是一种文档格式转换到另外一种文档格式，将数据加载到内存，采用存储格式协议读取数据，得到模型，然后根据另外
        ///的格式协议，进行转换， IO读取 CPU计算 输出到IO
        ///如果要你造轮子 那么就要了解PDF存储协议，解析协议，DOCX存储协议 
        ///
        /// 
        /// 资源 信息搜索 思路
        /// 
        ///



    }
}
