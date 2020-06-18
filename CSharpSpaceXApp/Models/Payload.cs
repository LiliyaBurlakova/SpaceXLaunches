using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CSharpSpaceXApp.Models
{
    public class Payload
    {
        [JsonProperty("payload_id")]
        public string PayloadId { get; set; }

        [JsonProperty("norad_id")]
        public object[] NoradId { get; set; }

        [JsonProperty("reused")]
        public bool? Reused { get; set; }

        [JsonProperty("customers")]
        public string[] Customers { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("payload_type")]
        public string PayloadType { get; set; }

        [JsonProperty("payload_mass_kg")]
        public long? PayloadMassKg { get; set; }

        [JsonProperty("payload_mass_lbs")]
        public double? PayloadMassLbs { get; set; }

        [JsonProperty("orbit")]
        public string Orbit { get; set; }

        [JsonProperty("orbit_params")]
        public OrbitParams OrbitParams { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (CheckPropertyValue(PayloadId))
            {
                stringBuilder.Append(String.Format("     *PayloadId = {0}\n", PayloadId));
            }

            if (CheckPropertyValue(NoradId))
            {
                stringBuilder.Append(String.Format("     *NoradId = \n"));
                foreach(object o in NoradId)
                {
                    stringBuilder.Append(String.Format("      o\n"));
                }
            }

            if (CheckPropertyValue(Reused))
            {
                stringBuilder.Append(String.Format("     *Reused = {0}\n", Reused));
            }

            if (CheckPropertyValue(Customers))
            {
                stringBuilder.Append(String.Format("     *Customers = \n"));
                foreach (string customer in Customers)
                {
                    stringBuilder.Append(String.Format("      customer\n"));
                }
            }

            if (CheckPropertyValue(Nationality))
            {
                stringBuilder.Append(String.Format("     *Nationality = {0}\n", Nationality));
            }

            if (CheckPropertyValue(Manufacturer))
            {
                stringBuilder.Append(String.Format("     *Manufacturer = {0}\n", Manufacturer));
            }

            if (CheckPropertyValue(PayloadType))
            {
                stringBuilder.Append(String.Format("     *PayloadType = {0}\n", PayloadType));
            }

            if (CheckPropertyValue(PayloadMassKg))
            {
                stringBuilder.Append(String.Format("     *PayloadMassKg = {0}\n", PayloadMassKg));
            }

            if (CheckPropertyValue(PayloadMassLbs))
            {
                stringBuilder.Append(String.Format("     *PayloadMassLbs = {0}\n", PayloadMassLbs));
            }

            if (CheckPropertyValue(Orbit))
            {
                stringBuilder.Append(String.Format("     *Orbit = {0}\n", Orbit));
            }

            if (CheckPropertyValue(OrbitParams))
            {
                stringBuilder.Append(String.Format("     *OrbitParams: \n{0}", OrbitParams));
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