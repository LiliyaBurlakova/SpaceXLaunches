using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            StringBuilder stringBuilder = new StringBuilder();

            if (CheckPropertyValue(Reused))
            {
                stringBuilder.Append(String.Format("    > Reused = {0}\n", Reused));
            }

            if (CheckPropertyValue(RecoveryAttempt))
            {
                stringBuilder.Append(String.Format("    > RecoveryAttempt = {0}\n", RecoveryAttempt));
            }

            if (CheckPropertyValue(Recovered))
            {
                stringBuilder.Append(String.Format("    > Recovered = {0}\n", Recovered));
            }

            if (CheckPropertyValue(Ship))
            {
                stringBuilder.Append(String.Format("    > Ship = {0}\n", Ship));
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