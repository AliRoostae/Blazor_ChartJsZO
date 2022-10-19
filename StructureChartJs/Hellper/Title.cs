using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StructureChartJs.Hellper
{
    public  class Title
        {

            [JsonProperty("display")]
            public bool? Display { get; set; }

            [JsonProperty("fullSize")]
            public bool? FullSize { get; set; }
            [JsonProperty("position")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Position? Position { get; set; }
            [JsonProperty("padding")]
            public Padding? Padding { get; set; }

            [JsonProperty("align")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Align? Align { get; set; }

            [JsonProperty("text")]
            public string? Text { get; set; }
            [JsonProperty("color")]
            public string[]? Color { get; set; }
            [JsonProperty("font")]
            public FontChart? Font { get; set; }




        }

     
    }




