using CSharpSpaceXApp.Models;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpaceXApp.Services.Contracts
{
    public interface ISpaceXApiService
    {
        Document CreatePDF(MemoryStream stream, string title);

        void AddLaunchesToPdf(Document pdfDoc, List<Launch> upcomingLaunches);

    }
}
