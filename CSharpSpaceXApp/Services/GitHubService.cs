
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using Newtonsoft.Json;

using System.Collections.Generic;
using System.Net;

namespace CSharpSpaceXApp.Services
{
    public class GitHubService : IGitHubService
    {

        public List<Launch> getUpcomingFlights(string url)
        {

            var json = new WebClient().DownloadString(url);
            List<Launch> upcomingLaunches = JsonConvert.DeserializeObject<List<Launch>>(json);
            return upcomingLaunches;
        }

        public Launch getLatestLaunch(string url)
        {

            var json = new WebClient().DownloadString(url);
            Launch latestLaunch = JsonConvert.DeserializeObject<Launch>(json); ;
            return latestLaunch;
        }


        public Launch getNextLaunch(string url)
        {

            var json = new WebClient().DownloadString(url);
            Launch nextLaunch = JsonConvert.DeserializeObject<Launch>(json); ;
            return nextLaunch;
        }

    }
}