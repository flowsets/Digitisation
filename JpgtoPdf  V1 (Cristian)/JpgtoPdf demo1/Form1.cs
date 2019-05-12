using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JpgtoPdf_demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void JpgtoPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "C:\\PdfGenerator";
            dlg.Filter = "JPEG files (*.jpg) |*.jpg|All files (*.*)|*.*";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Created using Pdf Sharp";

                foreach (string fileSpec in dlg.FileNames)
                {
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, fileSpec, 0, 0, (int)page.Width, (int)page.Height);
                }
                if (document.PageCount > 0) document.Save(@"C:\PdfGenerator\Transform.pdf");
            }
        }

        void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }
    }
}
