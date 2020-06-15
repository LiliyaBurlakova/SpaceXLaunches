using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            return String.Format("SiteId = {0}\n" +
                "SiteName = {1}\n" +
                "SiteNameLong = {2}", SiteId, SiteName, SiteNameLong);
        }
    }
}