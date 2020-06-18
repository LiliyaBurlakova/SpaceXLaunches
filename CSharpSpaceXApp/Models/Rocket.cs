using Newtonsoft.Json;
using System;
using System.Text;

namespace CSharpSpaceXApp.Models
{
    public class Rocket
    {
        [JsonProperty("rocket_id")]
        public string RocketId { get; set; }

        [JsonProperty("rocket_name")]
        public string RocketName { get; set; }

        [JsonProperty("rocket_type")]
        public string RocketType { get; set; }

        [JsonProperty("first_stage")]
        public FirstStage FirstStage { get; set; }

        [JsonProperty("second_stage")]
        public SecondStage SecondStage { get; set; }

        [JsonProperty("fairings")]
        public Fairings Fairings { get; set; }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (CheckPropertyValue(RocketId))
            {
                stringBuilder.Append(String.Format("  - RocketId = {0}\n", RocketId));
            }

            if (CheckPropertyValue(RocketName))
            {
                stringBuilder.Append(String.Format("  - RocketName = {0}\n", RocketName));
            }

            if (CheckPropertyValue(RocketType))
            {
                stringBuilder.Append(String.Format("  - RocketType = {0}\n", RocketType));
            }

            if (CheckPropertyValue(FirstStage))
            {
                stringBuilder.Append(String.Format("  - FirstStage: \n{0}", FirstStage));
            }

            if (CheckPropertyValue(SecondStage))
            {
                stringBuilder.Append(String.Format("  - SecondStage: \n{0}", SecondStage));
            }

            if (CheckPropertyValue(Fairings))
            {
                stringBuilder.Append(String.Format("  - Fairings: \n{0}", Fairings));
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