using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpSpaceXApp.Models
{
    public class OrbitParams
    {
        [JsonProperty("reference_system")]
        public string ReferenceSystem { get; set; }

        [JsonProperty("regime")]
        public string Regime { get; set; }

        [JsonProperty("longitude")]
        public object Longitude { get; set; }

        [JsonProperty("semi_major_axis_km")]
        public object SemiMajorAxisKm { get; set; }

        [JsonProperty("eccentricity")]
        public object Eccentricity { get; set; }

        [JsonProperty("periapsis_km")]
        public object PeriapsisKm { get; set; }

        [JsonProperty("apoapsis_km")]
        public object ApoapsisKm { get; set; }

        [JsonProperty("inclination_deg")]
        public object InclinationDeg { get; set; }

        [JsonProperty("period_min")]
        public object PeriodMin { get; set; }

        [JsonProperty("lifespan_years")]
        public object LifespanYears { get; set; }

        [JsonProperty("epoch")]
        public object Epoch { get; set; }

        [JsonProperty("mean_motion")]
        public object MeanMotion { get; set; }

        [JsonProperty("raan")]
        public object Raan { get; set; }

        [JsonProperty("arg_of_pericenter")]
        public object ArgOfPericenter { get; set; }

        [JsonProperty("mean_anomaly")]
        public object MeanAnomaly { get; set; }
    }
}