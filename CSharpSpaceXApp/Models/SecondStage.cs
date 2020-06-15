using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpSpaceXApp.Models
{
    public class SecondStage
    {
        [JsonProperty("block")]
        public long? Block { get; set; }

        [JsonProperty("payloads")]
        public Payload[] Payloads { get; set; }
    }
}