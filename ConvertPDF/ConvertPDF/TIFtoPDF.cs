using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using System.IO;
using Image = iTextSharp.text.Image;

namespace ConvertPDF
{
    public class TIFtoPDF
    {
        public static void ConvertTifToPdf(string tifFilePath, string pdfFilePath)
        {
            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (Document doc = new Document())
                {
                    using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                    {
                        doc.Open();

                        RandomAccessFileOrArray tifFile = new RandomAccessFileOrArray(tifFilePath);

                        int pageCount = TiffImage.GetNumberOfPages(tifFile);

                        for (int i = 1; i <= pageCount; i++)
                        {
                            Image img = TiffImage.GetTiffImage(tifFile, i);
                            img.Alignment = Image.ALIGN_CENTER;
                            img.ScaleToFit(doc.PageSize.Width, doc.PageSize.Height);
                            doc.Add(img);
                        }

                        tifFile.Close();

                        doc.Close();
                    }
                }
            }
        }
    }
}
