using Newtonsoft.Json;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Tension
        {
            [JsonProperty("duration")]
            public int? Duration { get; set; }

            [JsonProperty("easing")]
            public string? Easing { get; set; }

            [JsonProperty("from")]
            public int? From { get; set; }

            [JsonProperty("to")]
            public int? To { get; set; }

            [JsonProperty("loop")]
            public int? Loop { get; set; }
        }

     
    }




