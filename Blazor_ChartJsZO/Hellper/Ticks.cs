﻿using Newtonsoft.Json;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Ticks
        {
            [JsonProperty("color")]
            public string? Color { get; set; }

            [JsonProperty("stepSize")]
            public double? StepSize { get; set; }

            [JsonProperty("backdropPadding")]
            public BackdropPadding? BackdropPadding { get; set; }
        }
    }




