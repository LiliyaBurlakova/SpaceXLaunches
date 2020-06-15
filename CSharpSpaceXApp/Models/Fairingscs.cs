using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpSpaceXApp.Models
{
    public class Fairings
    {

        [JsonProperty("reused")]
        public bool? Reused { get; set; }

        [JsonProperty("recovery_attempt")]
        public bool? RecoveryAttempt { get; set; }

        [JsonProperty("recovered")]
        public bool? Recovered { get; set; }

        [JsonProperty("ship")]
        public string Ship { get; set; }

        public override string ToString()
        {
            return String.Format("Reused = {0}\n" +
                "RecoveryAttempt = {1}\n" +
                "Recovered = {2}\n" +
                "Ship = {3}", Reused, RecoveryAttempt, Recovered, Ship);
        }
    }
}