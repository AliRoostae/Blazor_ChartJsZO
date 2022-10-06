﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Decimation
        {
            [JsonProperty("enabled")]
            public bool? Enabled { get; set; }
            [JsonProperty("algorithm")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Algorithm? Algorithm { get; set; }
            [JsonProperty("samples")]
            public int? Samples { get; set; }
            [JsonProperty("threshold")]
            public int? Threshold { get; set; }


        }

     
    }




