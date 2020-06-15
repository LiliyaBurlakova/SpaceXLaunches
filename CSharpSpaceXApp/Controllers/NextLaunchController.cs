using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

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
            Launch latestFlight = gitHubService.getNextLaunch(Constants.Constants.NEXT_LAUNCHES);

            return View(latestFlight);
        }
    
    }
}
