using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Legend
        {
            [JsonProperty("position")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Position? Position { get; set; }
            [JsonProperty("display")]
            public bool? Display { get; set; }
            [JsonProperty("align")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Align? Align { get; set; }
            [JsonProperty("maxHeight")]
            public int? MaxHeight { get; set; }
            [JsonProperty("maxWidth")]
            public int? MaxWidth { get; set; }
            [JsonProperty("fullSize")]
            public bool? FullSize { get; set; }
            [JsonProperty("reverse")]
            public bool? Reverse { get; set; }
            [JsonProperty("rtl")]
            public bool? RTL { get; set; }

            [JsonProperty("textDirection")]
            [JsonConverter(typeof(StringEnumConverter))]
            public TextDirection? TextDirection { get; set; }

            [JsonProperty("labels")]
            public Labels? Labels { get; set; }
            [JsonProperty("title")]
            public Title? Title { get; set; }


        }

     
    }




