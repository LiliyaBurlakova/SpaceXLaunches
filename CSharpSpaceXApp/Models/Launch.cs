using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Text;

namespace CSharpSpaceXApp.Models
{
    public class Launch
    {
        [JsonProperty("flight_number")]
        public long FlightNumber { get; set; }

        [JsonProperty("mission_name")]
        public string MissionName { get; set; }

        [JsonProperty("mission_id")]
        public string[] MissionId { get; set; }

        [JsonProperty("launch_year")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long LaunchYear { get; set; }

        [JsonProperty("launch_date_unix")]
        public long LaunchDateUnix { get; set; }

        [JsonProperty("launch_date_utc")]
        public DateTimeOffset LaunchDateUtc { get; set; }

        [JsonProperty("launch_date_local")]
        public DateTimeOffset LaunchDateLocal { get; set; }

        [JsonProperty("is_tentative")]
        public bool IsTentative { get; set; }

        [JsonProperty("tentative_max_precision")]
        public string TentativeMaxPrecision { get; set; }

        [JsonProperty("tbd")]
        public bool Tbd { get; set; }

        [JsonProperty("launch_window")]
        public object LaunchWindow { get; set; }

        [JsonProperty("rocket")]
        public Rocket Rocket { get; set; }

        [JsonProperty("ships")]
        public object[] Ships { get; set; }

        [JsonProperty("telemetry")]
        public Telemetry Telemetry { get; set; }

        [JsonProperty("launch_site")]
        public LaunchSite LaunchSite { get; set; }

        [JsonProperty("launch_success")]
        public object LaunchSuccess { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("upcoming")]
        public bool Upcoming { get; set; }

        [JsonProperty("static_fire_date_utc")]
        public object StaticFireDateUtc { get; set; }

        [JsonProperty("static_fire_date_unix")]
        public object StaticFireDateUnix { get; set; }

        [JsonProperty("timeline")]
        public object Timeline { get; set; }

        [JsonProperty("crew")]
        public object Crew { get; set; }

        [JsonProperty("last_date_update")]
        public DateTimeOffset LastDateUpdate { get; set; }

        [JsonProperty("last_ll_launch_date")]
        public object LastLlLaunchDate { get; set; }

        [JsonProperty("last_ll_update")]
        public object LastLlUpdate { get; set; }

        [JsonProperty("last_wiki_launch_date")]
        public DateTimeOffset LastWikiLaunchDate { get; set; }

        [JsonProperty("last_wiki_revision")]
        public Guid LastWikiRevision { get; set; }

        [JsonProperty("last_wiki_update")]
        public DateTimeOffset LastWikiUpdate { get; set; }

        [JsonProperty("launch_date_source")]
        public string LaunchDateSource { get; set; }

        Launch() { }

    }
}