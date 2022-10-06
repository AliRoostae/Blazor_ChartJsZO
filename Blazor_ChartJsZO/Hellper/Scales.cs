using Newtonsoft.Json;

namespace Blazor_ChartJsZO.Hellper
{
    public  class Scales
        {
            [JsonProperty("x")]
            public Rxy? X { get; set; }

            [JsonProperty("x1")]
            public Rxy? X1 { get; set; }

            [JsonProperty("y1")]
            public Rxy? Y1 { get; set; }

            [JsonProperty("y")]
            public Rxy? Y { get; set; }

            [JsonProperty("r")]
            public Rxy? R { get; set; }
        }

     
    }




