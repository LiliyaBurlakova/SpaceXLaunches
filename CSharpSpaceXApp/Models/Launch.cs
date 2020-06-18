using Newtonsoft.Json;
using System;
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

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(String.Format("FlightNumber: {0} \n", FlightNumber));

            if (CheckPropertyValue(MissionName))
            {
                stringBuilder.Append(String.Format("MissionName: {0} \n", MissionName));
            }
            if (CheckPropertyValue(MissionId))
            {
                if (MissionId.Length != 0)
                {
                    stringBuilder.Append(String.Format("MissionId: \n"));
                    foreach (string mission in MissionId)
                    {
                        stringBuilder.Append(String.Format("{0} ", mission));
                    }
                } else
                {
                    stringBuilder.Append(String.Format("MissionId: not provided\n"));
                }
            }
            stringBuilder.Append(String.Format("LaunchYear: {0}\n", LaunchYear));
            stringBuilder.Append(String.Format("LaunchDateUnix: {0}\n", LaunchDateUnix));
            if (CheckPropertyValue(LaunchDateUtc))
            {
                stringBuilder.Append(String.Format("LaunchDateUtc: {0}\n", LaunchDateUtc));
            }
            if (CheckPropertyValue(LaunchDateLocal))
            {
                stringBuilder.Append(String.Format("LaunchDateLocal: {0}\n", LaunchDateLocal));
            }
            stringBuilder.Append(String.Format("IsTentative: {0}\n", IsTentative));
            if (CheckPropertyValue(TentativeMaxPrecision))
            {
                stringBuilder.Append(String.Format("TentativeMaxPrecision: {0}\n", TentativeMaxPrecision));
            }
            stringBuilder.Append(String.Format("Tbd: {0}\n", Tbd));
            if (CheckPropertyValue(LaunchWindow))
            {
                stringBuilder.Append(String.Format("LaunchWindow: {0}\n", LaunchWindow));
            }
            if (CheckPropertyValue(Rocket))
            {
                stringBuilder.Append(String.Format("Rocket: \n{0}", Rocket));
            }

            if (CheckPropertyValue(Ships))
            {
                stringBuilder.Append(String.Format("Ships: {0}\n", FlightNumber));
            }

            if (CheckPropertyValue(Telemetry))
            {
                stringBuilder.Append(String.Format("Telemetry: \n{0}", Telemetry));
            }

            if (CheckPropertyValue(LaunchSite))
            {
                stringBuilder.Append(String.Format("LaunchSite: \n{0}", LaunchSite));
            }

            if (CheckPropertyValue(LaunchSuccess))
            {
                stringBuilder.Append(String.Format("LaunchSuccess: {0}\n", LaunchSuccess));
            }

            if (CheckPropertyValue(Links))
            {
                stringBuilder.Append(String.Format("Links: \n{0}", Links));
            }

            if (CheckPropertyValue(Details))
            {
                stringBuilder.Append(String.Format("Details: {0}\n", Details));
            }

            stringBuilder.Append(String.Format("Upcoming: {0}\n", Upcoming));

            if (CheckPropertyValue(StaticFireDateUtc))
            {
                stringBuilder.Append(String.Format("StaticFireDateUtc: {0}\n", StaticFireDateUtc));
            }

            if (CheckPropertyValue(StaticFireDateUnix))
            {
                stringBuilder.Append(String.Format("StaticFireDateUnix: {0}\n", StaticFireDateUnix));
            }

            if (CheckPropertyValue(Crew))
            {
                stringBuilder.Append(String.Format("Crew: {0}\n", Crew));
            }

            if (CheckPropertyValue(LastDateUpdate))
            {
                stringBuilder.Append(String.Format("LastDateUpdate: {0}\n", LastDateUpdate));
            }

            if (CheckPropertyValue(LastLlLaunchDate))
            {
                stringBuilder.Append(String.Format("LastLlLaunchDate: {0}\n", LastLlLaunchDate));
            }

            if (CheckPropertyValue(LastLlUpdate))
            {
                stringBuilder.Append(String.Format("LastLlUpdate: {0}\n", LastLlUpdate));
            }

            if (CheckPropertyValue(LastWikiLaunchDate))
            {
                stringBuilder.Append(String.Format("LastLlLaunchDate: {0}\n", LastWikiLaunchDate));
            }

            if (CheckPropertyValue(LastWikiRevision))
            {
                stringBuilder.Append(String.Format("LastWikiRevision: {0}\n", LastWikiRevision));
            }

            if (CheckPropertyValue(LastWikiUpdate))
            {
                stringBuilder.Append(String.Format("LastWikiUpdate: {0}\n", LastWikiUpdate));
            }

            if (CheckPropertyValue(LaunchDateSource))
            {
                stringBuilder.Append(String.Format("LaunchDateSource: {0}\n", LaunchDateSource));
            }
            
            return stringBuilder.ToString();
        }


        public bool CheckPropertyValue<T>(T element)
        {

            if (element != null)
            {
                return true;
            }
            return false;
        }

    }
}