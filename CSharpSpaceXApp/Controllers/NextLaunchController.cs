using CSharpSpaceXApp.Exceptions;
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Takes information from the SpaceX API about next launch and provides it to the view
/// </summary>
namespace CSharpSpaceXApp.Controllers
{
    public class NextLaunchController : Controller
    {
        IGitHubService gitHubService;

        public NextLaunchController(IGitHubService gitHubService)
        {
            this.gitHubService = gitHubService;
        }
        public IActionResult Next()
        {
            try
            {
                Launch nextLaunch = gitHubService.GetNextLaunch(Constants.Constants.NEXT_LAUNCHES);
                return View(nextLaunch);
            }
            catch (APIConnectionException e)
            {
                ViewBag.Message = e.Message;
                return Redirect("APIError");

            }
        }
    
    }
}
