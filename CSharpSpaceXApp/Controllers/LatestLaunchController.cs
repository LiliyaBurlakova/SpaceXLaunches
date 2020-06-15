using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using Microsoft.AspNetCore.Mvc;


namespace CSharpSpaceXApp.Controllers
{
    public class LatestLaunchController : Controller
        
    {
        IGitHubService gitHubService;

        public LatestLaunchController(IGitHubService gitHubService)
        {
            this.gitHubService = gitHubService;
        }
        public IActionResult Latest()
        {
            Launch latestFlight = gitHubService.getLatestLaunch(Constants.Constants.LATEST_LAUNCHES);

            return View(latestFlight);
        }
    }
}
