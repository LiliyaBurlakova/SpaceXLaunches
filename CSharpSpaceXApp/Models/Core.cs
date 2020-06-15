using Newtonsoft.Json;
using System;

namespace CSharpSpaceXApp.Models
{
    public class Core
    {
        [JsonProperty("core_serial")]
        public string CoreSerial { get; set; }

        [JsonProperty("flight")]
        public long? Flight { get; set; }

        [JsonProperty("block")]
        public long? Block { get; set; }

        [JsonProperty("gridfins")]
        public bool? Gridfins { get; set; }

        [JsonProperty("legs")]
        public bool? Legs { get; set; }

        [JsonProperty("reused")]
        public bool? Reused { get; set; }

        [JsonProperty("land_success")]
        public object LandSuccess { get; set; }

        [JsonProperty("landing_intent")]
        public bool? LandingIntent { get; set; }

        [JsonProperty("landing_type")]
        public string LandingType { get; set; }

        [JsonProperty("landing_vehicle")]
        public string LandingVehicle { get; set; }

        public override string ToString()
        {
            return String.Format("CoreSerial = {0}\n" +
                "Flight = {1}\n" +
                "Block = {2}\n" +
                "Gridfins = {3}\n" +
                "Legs = {4}\n" +
                "Reused = {5}\n" +
                "LandSuccess = {6}\n" +
                "LandingIntent = {7}\n" +
                "LandingType = {8}\n" +
                "LandingVehicle = {9}", CoreSerial, Flight, Block, Gridfins, Legs, 
                Reused, LandSuccess, LandingIntent, LandingType, LandingVehicle);
        }
    }
}