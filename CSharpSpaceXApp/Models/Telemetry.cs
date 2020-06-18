using Newtonsoft.Json;
using System;
using System.Text;


namespace CSharpSpaceXApp.Models
{
    public class Telemetry
    {
        [JsonProperty("flight_club")]
        public object FlightClub { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (CheckPropertyValue(FlightClub))
            {
                stringBuilder.Append(String.Format("  - FlightClub = \n{0}", FlightClub));
            } else
            {
                stringBuilder.Append(String.Format("  - FlightClub = not provided\n"));
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