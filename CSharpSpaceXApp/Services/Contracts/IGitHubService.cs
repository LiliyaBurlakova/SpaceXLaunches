using CSharpSpaceXApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpSpaceXApp.Services.Contracts
{
    public interface IGitHubService
    {
        List<Launch> GetUpcomingFlights(string url);
        Launch GetLatestLaunch(string url);
        Launch GetNextLaunch(string url);
    }
}
