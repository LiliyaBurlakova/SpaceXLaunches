using System.Collections.Generic;
using System.IO;
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using iTextSharp.tool.xml;

namespace CSharpSpaceXApp.Services
{
    /// <summary>
    /// Creates a pdf file and writes information in the file
    /// </summary>
    public class FileService : ISpaceXApiService
    {
        public FileService()
        {
        }

        /// <summary>
        /// Creates PDF file
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="title">Title of the file</param>
        /// <returns>A new pdf document</returns>
        public Document CreatePDF(MemoryStream stream, string title)
        {
            StringReader sr = new StringReader("");
            Document pdfDoc = new Document(PageSize.A4, 30f, 30f, 30f, 30f);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
            pdfDoc.Open();
            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);


            pdfDoc.Add(new Paragraph(title));
            pdfDoc.Add(new Paragraph("\n"));
            return pdfDoc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdfDoc">The created pdf</param>
        /// <param name="upcomingLaunches">List with the launches, that have to be added in the pdf</param>
        public void AddLaunchesToPdf(Document pdfDoc, List<Launch> upcomingLaunches)
        {
            foreach (Launch launch in upcomingLaunches)
            {
                pdfDoc.Add(new Paragraph(launch.ToString()));
                pdfDoc.Add(new Paragraph("\n"));
                DottedLineSeparator dottedline = new DottedLineSeparator();
                pdfDoc.Add(dottedline);
            }
        }

    }
}
