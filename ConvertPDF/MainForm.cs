using System;
using System.IO;
using System.Windows.Forms;

using TulparUI.Controls;

namespace ConvertPDF
{
    public partial class MainForm : TulparForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnConvertPngtoPdf_Click(object sender, System.EventArgs e)
        {
            openFile.Filter = "PNG Dosyası (*.png)|*.png";
            openFile.FileName = "";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Title = "PNG dosyasını seçiniz!";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string inputFile = openFile.FileName;

                string outputFile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileNameWithoutExtension(inputFile)) + ".pdf";
                PNGtoPDF.ConvertPngToPdf(inputFile, outputFile);
                MessageBox.Show(" Kaydedildi.");
            }
        }

        private void BtnJpegToPdf_Click(object sender, EventArgs e)
        {
            openFile.Filter = "JPEG Dosyası (*.jpg; *.jpeg; *.jpe; *.jfif)|*.jpg; *.jpeg; *.jpe; *.jfif";
            openFile.FileName = "";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Title = "JPEG dosyasını seçiniz!";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string inputFile = openFile.FileName;

                string outputFile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileNameWithoutExtension(inputFile)) + ".pdf";
                JPEGtoPDF.ConvertJpegToPdf(inputFile, outputFile);
                MessageBox.Show(" Kaydedildi.");
            }
        }

        private void BtnTiftoPdf_Click(object sender, EventArgs e)
        {
            openFile.Filter = "TIFF Dosyası (*.tif; *.tiff)|*.tif; *.tiff";
            openFile.FileName = "";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Title = "TIFF dosyasını seçiniz!";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string inputFile = openFile.FileName;

                string outputFile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileNameWithoutExtension(inputFile)) + ".pdf";
                TIFtoPDF.ConvertTifToPdf(inputFile, outputFile);
                MessageBox.Show(" Kaydedildi.");
            }
        }
    }
}
