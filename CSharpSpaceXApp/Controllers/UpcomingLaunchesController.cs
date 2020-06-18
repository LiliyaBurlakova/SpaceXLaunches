using System.Collections.Generic;
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using CSharpSpaceXApp.Exceptions;


/// <summary>
/// Takes information from the SpaceX API about upcoming launches and provides it to the view.
/// </summary>
namespace CSharpSpaceXApp.Controllers
{
    public class UpcomingLaunchesController : Controller
    {
        IGitHubService gitHubService;
        private List<Launch> upcomingLaunches;


        public UpcomingLaunchesController(IGitHubService gitHubService)
        {
            this.gitHubService = gitHubService;
        }


        public IActionResult Upcoming(int? currPage)
        {
            var currentPage = currPage ?? 1;
           try
           {
               upcomingLaunches = gitHubService.GetUpcomingFlights(Constants.Constants.UPCOMING_LAUNCHES);
           } catch (APIConnectionException e)
           {
                ViewBag.Message = e.Message;
                return Redirect("APIError");

            }
           var totalPages = this.upcomingLaunches.Count - 1;

           var model = new SheduedFlight
           {
               shefuedLaunch = upcomingLaunches[currentPage],
               CurrPage = currentPage,
               TotalPages = totalPages,
           };


           if (totalPages > currentPage)
           {
               model.NextPage = currentPage + 1;
           }

           if (currentPage > 1)
           {
               model.PrevPage = currentPage - 1;
           }

           model.shefuedLaunch = GetRockets(currentPage).First();

           return View(model);
            

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private IEnumerable<Launch> GetRockets(int currentPage)
        {
            IEnumerable<Launch> currentData;

            if (currentPage == 1)
            {
                currentData = this.upcomingLaunches.Take(1);
            }
            else
            {
                currentData = upcomingLaunches
                        .Skip(currentPage - 1)
                         .Take(1);
            }
            
            return currentData;
        }

    }
}
