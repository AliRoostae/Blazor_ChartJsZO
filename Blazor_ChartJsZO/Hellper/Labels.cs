using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Labels
        {
            [JsonProperty("font")]
            public FontChart? Font { get; set; }

            [JsonProperty("boxWidth")]
            public int? BoxWidth { get; set; }

            [JsonProperty("boxHeight")]
            public int? BoxHeight { get; set; }

            [JsonProperty("pointStyleWidth")]
            public int? PointStyleWidth { get; set; }

            [JsonProperty("color")]
            public string[]? Color { get; set; }

            [JsonProperty("padding")]
            public Padding? Padding { get; set; }

            [JsonProperty("pointStyle")]
            [JsonConverter(typeof(StringEnumConverter))]
            public PointStyle? PointStyle { get; set; }

            [JsonProperty("textAlign")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Align? TextAlign { get; set; }

            [JsonProperty("usePointStyle")]
            public bool? UsePointStyle { get; set; }


        }

     
    }




