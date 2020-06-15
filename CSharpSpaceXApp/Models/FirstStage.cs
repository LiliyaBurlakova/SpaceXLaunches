using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpSpaceXApp.Models
{
    public class FirstStage
    {
        [JsonProperty("cores")]
        public Core[] Cores { get; set; }

        public override string ToString()
        {
            return String.Format("Cores = {0}", Cores);
        }
    }
}