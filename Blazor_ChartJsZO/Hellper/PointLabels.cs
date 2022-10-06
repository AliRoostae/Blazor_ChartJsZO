﻿using Newtonsoft.Json;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class PointLabels
        {
            [JsonProperty("display")]
            public bool? Display { get; set; }

            [JsonProperty("centerPointLabels")]
            public bool? CenterPointLabels { get; set; }

            [JsonProperty("font")]
            public FontChart? Font { get; set; }
        }

     
    }




