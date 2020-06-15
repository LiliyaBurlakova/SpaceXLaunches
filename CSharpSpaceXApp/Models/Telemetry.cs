using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpSpaceXApp.Models
{
    public class Telemetry
    {
        [JsonProperty("flight_club")]
        public object FlightClub { get; set; }
    }
}