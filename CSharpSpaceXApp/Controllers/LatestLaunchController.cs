using CSharpSpaceXApp.Exceptions;
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Takes information from the SpaceX API about latest launch and provides it to the view
/// </summary>

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
            try
            {
                Launch latestLaunch = gitHubService.GetLatestLaunch(Constants.Constants.LATEST_LAUNCHES);

                return View(latestLaunch);
            }
            catch (APIConnectionException e)
            {
                ViewBag.Message = e.Message;
                return Redirect("APIError");

            }
        }
    }
}
