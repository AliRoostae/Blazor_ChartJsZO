using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StructureChartJs.Hellper
{
    public class Arc : Border
        {
            [JsonProperty("angle")]
            public int? Angle { get; set; }
            [JsonProperty("circular")]
            public bool? Circular { get; set; }

            [JsonProperty("backgroundColor")]
            public string[]? BackgroundColor { get; set; }
        }

     
    }




