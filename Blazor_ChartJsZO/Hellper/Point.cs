using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Point : Border
        {
           
            [JsonProperty("radius")]
            public int? Radius { get; set; }
            [JsonProperty("rotation")]
            public int? Rotation { get; set; }
            [JsonProperty("pointStyle")]
            [JsonConverter(typeof(StringEnumConverter))]
            public PointStyle? PointStyle { get; set; }
            [JsonProperty("backgroundColor")]
            public string[]? BackgroundColor { get; set; }


            [JsonProperty("hitRadius")]
            public int? HitRadius { get; set; }
            [JsonProperty("hoverRadius")]
            public int? HoverRadius { get; set; }
            [JsonProperty("hoverBorderWidth")]
            public int? HoverBorderWidth { get; set; }



        }

     
    }




