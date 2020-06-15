using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using PagedList;



namespace CSharpSpaceXApp.Controllers
{
    public class UpcomingLaunchesController : Controller
    {
        IGitHubService gitHubService;
        

        public UpcomingLaunchesController(IGitHubService gitHubService)
        {
            this.gitHubService = gitHubService;
        }


        public IActionResult Upcoming(int? page)
        {

            int pageSize = 1;
            int pageIndex = (page ?? 1);

            List<Launch> upcomingFlights = gitHubService.getUpcomingFlights(Constants.Constants.UPCOMING_LAUNCHES);

            return View(upcomingFlights.ToPagedList(pageIndex, pageSize));
        }
    }
}
