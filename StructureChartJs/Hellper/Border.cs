using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StructureChartJs.Hellper
{
    public abstract class Border
        {
            [JsonProperty("borderWidth")]
            public int? BorderWidth { get; set; }


            [JsonProperty("borderColor")]
            public virtual string[]? BorderColor { get; set; }

            [JsonProperty("borderCapStyle")]
            public string? BorderCapStyle { get; set; }
            [JsonProperty("borderDash")]
            public int[]? BorderDash { get; set; }
            [JsonProperty("borderDashOffset")]
            public float? BorderDashOffset { get; set; }
            [JsonProperty("borderJoinStyle")]
            [JsonConverter(typeof(StringEnumConverter))]
            public BorderJoinStyle? BorderJoinStyle { get; set; }
            [JsonProperty("borderSkipped")]
            [JsonConverter(typeof(StringEnumConverter))]
            public BorderSkipped? BorderSkipped { get; set; }
            [JsonProperty("borderRadius")]
            public int? BorderRadius { get; set; }

        }
    }




