using Newtonsoft.Json;
using System;
using System.Text;


namespace CSharpSpaceXApp.Models
{
    public class FirstStage
    {
        [JsonProperty("cores")]
        public Core[] Cores { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (CheckPropertyValue(Cores))
            {
                stringBuilder.Append(String.Format("    > Cores: \n{0}", Cores));
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