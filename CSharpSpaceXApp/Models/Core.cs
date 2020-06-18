using Newtonsoft.Json;
using System;
using System.Text;


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
            StringBuilder stringBuilder = new StringBuilder();

            if (CheckPropertyValue(CoreSerial))
            {
                stringBuilder.Append(String.Format("     *CoreSerial = {0}\n", CoreSerial));
            }

            if (CheckPropertyValue(Flight))
            {
                stringBuilder.Append(String.Format("     *Flight = {0}\n", Flight));
            }

            if (CheckPropertyValue(Block))
            {
                stringBuilder.Append(String.Format("     *Block = {0}\n", Block));
            }

            if (CheckPropertyValue(Gridfins))
            {
                stringBuilder.Append(String.Format("     *Gridfins = {0}\n", Gridfins));
            }

            if (CheckPropertyValue(Legs))
            {
                stringBuilder.Append(String.Format("     *Legs = {0}\n", Legs));
            }

            if (CheckPropertyValue(Reused))
            {
                stringBuilder.Append(String.Format("     *Reused = {0}\n", Reused));
            }

            if (CheckPropertyValue(LandSuccess))
            {
                stringBuilder.Append(String.Format("     *LandSuccess = {0}\n", LandSuccess));
            }

            if (CheckPropertyValue(LandingIntent))
            {
                stringBuilder.Append(String.Format("     *LandingIntent = {0}\n", LandingIntent));
            }

            if (CheckPropertyValue(LandingType))
            {
                stringBuilder.Append(String.Format("     *LandingType = {0}\n", LandingType));
            }

            if (CheckPropertyValue(LandingVehicle))
            {
                stringBuilder.Append(String.Format("     *LandingVehicle = {0}\n", LandingVehicle));
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