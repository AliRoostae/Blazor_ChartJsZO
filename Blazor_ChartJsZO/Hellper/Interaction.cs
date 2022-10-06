using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Interaction
        {
            [JsonProperty("mode")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Mode? Mode { get; set; }

            [JsonProperty("intersect")]
            public bool? Intersect { get; set; }
            [JsonProperty("includeInvisible")]
            public bool? IncludeInvisible { get; set; }

            [JsonProperty("axis")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Axis? Axis { get; set; }
        }

     
    }




