using Newtonsoft.Json;

namespace ChartJsStructure.Hellper
{
    public  class BackdropPadding
        {
            [JsonProperty("x")]
            public int? X { get; set; }

            [JsonProperty("y")]
            public int? Y { get; set; }
        }
    }




