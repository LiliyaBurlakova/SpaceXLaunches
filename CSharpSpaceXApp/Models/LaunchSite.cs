using Newtonsoft.Json;
using System;
using System.Text;

namespace CSharpSpaceXApp.Models
{
    public class LaunchSite
    {
        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("site_name")]
        public string SiteName { get; set; }

        [JsonProperty("site_name_long")]
        public string SiteNameLong { get; set; }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (CheckPropertyValue(SiteId))
            {
                stringBuilder.Append(String.Format(" - SiteId = {0}\n", SiteId));
            }

            if (CheckPropertyValue(SiteName))
            {
                stringBuilder.Append(String.Format(" - SiteName = {0}\n", SiteName));
            }

            if (CheckPropertyValue(SiteNameLong))
            {
                stringBuilder.Append(String.Format(" - SiteNameLong = {0}\n", SiteNameLong));
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