﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Bar :  Border
        {
            
            [JsonProperty("inflateAmount")]
            public int? InflateAmount { get; set; }
            [JsonProperty("backgroundColor")]
            public string[]? BackgroundColor { get; set; }
            [JsonProperty("pointStyle")]
            public PointStyle? PointStyle { get; set; }

        }

     
    }




