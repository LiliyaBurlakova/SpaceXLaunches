
using CSharpSpaceXApp.Exceptions;
using CSharpSpaceXApp.Models;
using CSharpSpaceXApp.Services.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace CSharpSpaceXApp.Services

{
    /// <summary>
    /// Takes information from the ApaceX Api and deserialize the Json to object - Launch / List of Launches
    /// </summary>
    public class SpaceXApiService : IGitHubService
    {


        public List<Launch> GetUpcomingFlights(string url)
        {

            try
            {
                var json = new WebClient().DownloadString(url);
                List<Launch> upcomingLaunches = JsonConvert.DeserializeObject<List<Launch>>(json);
                return upcomingLaunches;
            }
            catch (Exception ex) when (ex is IOException || ex is JsonException)
            {
                throw new APIConnectionException(Constants.Constants.API_EXCEPTION);
            }

        }

        public Launch GetLatestLaunch(string url)
        {
            try
            {
                var json = new WebClient().DownloadString(url);
                Launch latestLaunch = JsonConvert.DeserializeObject<Launch>(json); ;
                return latestLaunch;
            }
            catch (Exception ex) when (ex is IOException || ex is JsonException)
            {
                throw new APIConnectionException(Constants.Constants.API_EXCEPTION);
            }
        }


        public Launch GetNextLaunch(string url)
        {
            try
            {
                var json = new WebClient().DownloadString(url);
                Launch nextLaunch = JsonConvert.DeserializeObject<Launch>(json); ;
                return nextLaunch;
            }
            catch (Exception ex) when (ex is IOException || ex is JsonException)
            {
                throw new APIConnectionException(Constants.Constants.API_EXCEPTION);
            }
        }

    }
}