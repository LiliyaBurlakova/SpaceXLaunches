using Newtonsoft.Json;
using System;


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
            return String.Format("RocketId = {0}\n" +
                "RocketName = {1}\n" +
                "RocketType = {2}\n" +
                "FirstStage = {3}\n" +
                "SecondStage = {4}\n" +
                "Fairings = {5}", RocketId, RocketName, RocketType, FirstStage, SecondStage, Fairings);
        }
    }
}