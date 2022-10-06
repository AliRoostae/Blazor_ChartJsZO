using Newtonsoft.Json;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Plugins
        {
            [JsonProperty("tooltip")]
            public Tooltip? Tooltip { get; set; }

            [JsonProperty("spanGaps")]
            public bool? SpanGaps { get; set; }

            [JsonProperty("legend")]
            public Legend? Legend { get; set; }

            [JsonProperty("title")]
            public Title? Title { get; set; }
            [JsonProperty("subtitle")]
            public Title? Subtitle { get; set; }

            [JsonProperty("filler")]
            public Filler? Filler { get; set; }

            [JsonProperty("decimation")]
            public Decimation? Decimation { get; set; }
        }

     
    }




