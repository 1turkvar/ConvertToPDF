using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ConvertPDF
{
    public class JPEGtoPDF
    {
        public static void ConvertJpegToPdf(string pngFilePath, string pdfFilePath)
        {
            using (var stream = new FileStream(pdfFilePath, FileMode.Create))
            {
                var document = new Document();
                var writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                var png = Image.GetInstance(pngFilePath);
                png.Alignment = Element.ALIGN_CENTER;
                png.ScaleToFit(document.PageSize.Width, document.PageSize.Height);

                document.Add(png);
                document.Close();
            }
        }

    }
}
