using Newtonsoft.Json;
using System;
using System.Text;

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

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (CheckPropertyValue(ReferenceSystem))
            {
                stringBuilder.Append(String.Format("       --ReferenceSystem = {0}\n", ReferenceSystem));
            }

            if (CheckPropertyValue(Regime))
            {
                stringBuilder.Append(String.Format("       --Regime = {0}\n", Regime));
            }

            if (CheckPropertyValue(Longitude))
            {
                stringBuilder.Append(String.Format("       --Longitude = {0}\n", Longitude));
            }

            if (CheckPropertyValue(SemiMajorAxisKm))
            {
                stringBuilder.Append(String.Format("       --SemiMajorAxisKm = {0}\n", SemiMajorAxisKm));
            }

            if (CheckPropertyValue(Eccentricity))
            {
                stringBuilder.Append(String.Format("       --Eccentricity = {0}\n", Eccentricity));
            }

            if (CheckPropertyValue(PeriapsisKm))
            {
                stringBuilder.Append(String.Format("       --PeriapsisKm = {0}\n", PeriapsisKm));
            }

            if (CheckPropertyValue(ApoapsisKm))
            {
                stringBuilder.Append(String.Format("       --ApoapsisKm = {0}\n", ApoapsisKm));
            }

            if (CheckPropertyValue(PeriodMin))
            {
                stringBuilder.Append(String.Format("       --PeriodMin = {0}\n", PeriodMin));
            }

            if (CheckPropertyValue(LifespanYears))
            {
                stringBuilder.Append(String.Format("       --LifespanYears = {0}\n", LifespanYears));
            }

            if (CheckPropertyValue(Epoch))
            {
                stringBuilder.Append(String.Format("       --Epoch = {0}\n", Epoch));
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