using CSharpSpaceXApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpSpaceXApp.Services.Contracts
{
    public interface IGitHubService
    {
        List<Launch> getUpcomingFlights(string url);
        Launch getLatestLaunch(string url);
        Launch getNextLaunch(string url);
    }
}
