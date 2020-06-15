using System.Collections.Generic;
using System.IO;
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using iTextSharp.text;
using iTextSharp.text.pdf.draw;
using Microsoft.AspNetCore.Mvc;


namespace CSharpSpaceXApp.Controllers
{
    public class FileController : Controller
    {
        private IFileService fileService;
        private IGitHubService gitHubService;

        public FileController(IFileService fileService, IGitHubService gitHubService)
        {
            this.fileService = fileService;
            this.gitHubService = gitHubService;
        }

        [HttpPost]
        
        public FileResult ExportUpcoming()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                string title = "Upcoming launches SpaceX";
                Document pdfDoc = fileService.CreatePDF(stream, title);

                List<Launch> upcomingFlights = gitHubService.getUpcomingFlights(Constants.Constants.UPCOMING_LAUNCHES);

                foreach (Launch flight in upcomingFlights)
                {
                    string textToAdd = fileService.GetStringOfObject(flight);
                    pdfDoc.Add(new Paragraph(textToAdd));
                    pdfDoc.Add(new Paragraph("\n"));
                    DottedLineSeparator dottedline = new DottedLineSeparator();
                    pdfDoc.Add(dottedline);
                }

                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Upcoming.pdf");
            }
        }

        [HttpPost]
        
        public FileResult ExportLatestLaunch()
        {
            using (MemoryStream stream = new System.IO.MemoryStream())

            {
                string title = "Latest launch SpaceX";
                Document pdfDoc = fileService.CreatePDF(stream, title);

                Launch latestLaunch = gitHubService.getLatestLaunch(Constants.Constants.LATEST_LAUNCHES);

                string textToAdd = fileService.GetStringOfObject(latestLaunch);
                pdfDoc.Add(new Paragraph(latestLaunch.ToString()));
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "LatestLaunch.pdf");
            }
        }

        [HttpPost]
        
        public FileResult ExportNextLaunch()
        {
            using (MemoryStream stream = new MemoryStream())

            {
                string title = "Next launch SpaceX";
                Document pdfDoc = fileService.CreatePDF(stream, title);

                Launch nextLaunch = gitHubService.getLatestLaunch(Constants.Constants.NEXT_LAUNCHES);


                string textToAdd = fileService.GetStringOfObject(nextLaunch);
                pdfDoc.Add(new Paragraph(textToAdd));
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "NextLaunch.pdf");
            }
        }
    }
}
