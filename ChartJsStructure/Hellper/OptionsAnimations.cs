using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChartJsStructure.Hellper
{
    public partial class OptionsAnimations
        {
            [JsonProperty("type")]
            [JsonConverter(typeof(StringEnumConverter))]
            public TypChart? Type { get; set; }

            [JsonProperty("properties")]
            public string[]? Properties { get; set; }

            [JsonProperty("from")]
            public string[]? From { get; set; }

            [JsonProperty("to")]
            public string[]? To { get; set; }

            [JsonProperty("fn")]
            public string[]? Fn { get; set; }

 


        }

     
    }




