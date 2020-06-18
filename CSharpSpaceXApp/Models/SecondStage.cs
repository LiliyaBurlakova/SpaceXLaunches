using Newtonsoft.Json;
using System;
using System.Text;

namespace CSharpSpaceXApp.Models
{
    public class SecondStage
    {
        [JsonProperty("block")]
        public long? Block { get; set; }

        [JsonProperty("payloads")]
        public Payload[] Payloads { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (CheckPropertyValue(Block))
            {
                stringBuilder.Append(String.Format("    > Block: {0}\n", Block));
            }

            if (CheckPropertyValue(Payloads))
            {
                stringBuilder.Append(String.Format("    > Payloads: \n{0}", Payloads));
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