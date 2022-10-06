using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Blazor_ChartJsZO.Hellper
{
    public  class Rxy
        {
            [JsonProperty("display")]
            public bool? Display { get; set; }

            [JsonProperty("stacked")]
            public bool? Stacked { get; set; }

            [JsonProperty("beginAtZero")]
            public bool? BeginAtZero { get; set; }

            [JsonProperty("position")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Position? Position { get; set; }

            [JsonProperty("type")]
            [JsonConverter(typeof(StringEnumConverter))]
            public TypChart? Type { get; set; }

            [JsonProperty("min")]
            public int? Min { get; set; }

            [JsonProperty("reverse")]
            public bool? Reverse { get; set; }

            [JsonProperty("max")]
            public int? Max { get; set; }

            [JsonProperty("title")]
            public Title? Title { get; set; }

            [JsonProperty("suggestedMin")]
            public int? SuggestedMin { get; set; }

            [JsonProperty("suggestedMax")]
            public int? SuggestedMax { get; set; }

            [JsonProperty("grid")]
            public Grid? Grid { get; set; }

            [JsonProperty("ticks")]
            public Ticks? Ticks { get; set; }

            [JsonProperty("pointLabels")]
            public PointLabels? PointLabels { get; set; }
        }

     
    }




