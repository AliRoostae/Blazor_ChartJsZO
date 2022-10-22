using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChartJsStructure.Hellper
{
    public class OptionsAnimation
        {
            [JsonProperty("duration")]
            public int? Duration { get; set; }

            [JsonProperty("easing")]
            [JsonConverter(typeof(StringEnumConverter))]
            public EasingEnum? Easing { get; set; }

            [JsonProperty("delay")]
            public int? Delay { get; set; }

            [JsonProperty("loop")]
            public bool? Loop { get; set; }
        }

     
    }




