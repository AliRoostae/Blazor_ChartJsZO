using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StructureChartJs.Hellper
{
    public partial class FontChart
        {
            [JsonProperty("size")]
            public int? Size { get; set; }

            [JsonProperty("family")]
            public string? Family { get; set; }

            [JsonProperty("style")]
            public string? Style { get; set; }

            [JsonProperty("weight")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WeightFont? Weight { get; set; }

            [JsonProperty("lineHeight")]
            public double? LineHeight { get; set; }
        }



    }




