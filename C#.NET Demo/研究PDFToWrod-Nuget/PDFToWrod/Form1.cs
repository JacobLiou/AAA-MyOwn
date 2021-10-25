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

    }
}
