using System.Collections.Generic;
using System.IO;
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using iTextSharp.text;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// FileController takes the API information about launches and exports it to a downloadable PDF file.
/// </summary>

namespace CSharpSpaceXApp.Controllers
{
    public class FileController : Controller
    {
        private ISpaceXApiService fileService;
        private IGitHubService gitHubService;

        public FileController(ISpaceXApiService fileService, IGitHubService gitHubService)
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

                List<Launch> upcomingLaunches = gitHubService.GetUpcomingFlights(Constants.Constants.UPCOMING_LAUNCHES);

                fileService.AddLaunchesToPdf(pdfDoc, upcomingLaunches);

                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Upcoming.pdf");
            }
        }

        [HttpPost]
        
        public FileResult ExportLatestLaunch()
        {
            using (MemoryStream stream = new MemoryStream())

            {
                string title = "Latest launch SpaceX";
                Document pdfDoc = fileService.CreatePDF(stream, title);

                Launch latestLaunch = gitHubService.GetLatestLaunch(Constants.Constants.LATEST_LAUNCHES);

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

                Launch nextLaunch = gitHubService.GetLatestLaunch(Constants.Constants.NEXT_LAUNCHES);

                pdfDoc.Add(new Paragraph(nextLaunch.ToString()));
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "NextLaunch.pdf");
            }
        }
    }
}
