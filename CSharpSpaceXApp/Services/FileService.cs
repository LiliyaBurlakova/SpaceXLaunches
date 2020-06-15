using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace CSharpSpaceXApp.Services
{
    public class FileService : IFileService
    {

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

        public string GetStringOfObject(Launch flight)
        {
            StringBuilder stringToPrint = new StringBuilder();

            foreach (PropertyInfo propertyInfo in flight.GetType().GetProperties())
            {
                if (CheckIfNullOrEmpty(propertyInfo, stringToPrint))
                {
                    AddInfoInPDF(flight, stringToPrint, propertyInfo);
                }

            }
            return stringToPrint.ToString();
        }

        public void AddInfoInPDF(Launch flight, StringBuilder stringToPrint, PropertyInfo propertyInfo)
        {
            string propertyName = propertyInfo.Name;
            stringToPrint.Append(propertyName);
            stringToPrint.Append(": ");
            stringToPrint.Append(propertyInfo.GetValue(flight));
            stringToPrint.Append("\n");
        }

        public bool CheckIfNullOrEmpty<T>(T element, StringBuilder stringBuilder)
        {
            if (element != null && !element.Equals(""))
            {
                return true;
            }
            return false;
        }

    }
}
