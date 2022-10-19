using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StructureChartJs.Hellper
{
    public partial class Line : Border
        {
            [JsonProperty("tension")]
            public int? Tension { get; set; }
            [JsonProperty("backgroundColor")]
            public string[]? BackgroundColor { get; set; }
          
          
            [JsonProperty("capBezierPoints")]
            public bool? CapBezierPoints { get; set; }
            [JsonProperty("cubicInterpolationMode")]
            public string? CubicInterpolationMode { get; set; }
            [JsonProperty("fill")]
            public string? Fill { get; set; }
            [JsonProperty("stepped")]
            public bool? Stepped { get; set; }


        }

     
    }




