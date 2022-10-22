using Newtonsoft.Json;

namespace ChartJsStructure.Hellper
{
    public  class Padding
        {


            [JsonProperty("top")]
            public int? Top { get; set; }

            [JsonProperty("left")]
            public int? Left { get; set; }

            [JsonProperty("bottom")]
            public int? Bottom { get; set; }

            [JsonProperty("right")]
            public int? Right { get; set; }
        }

     
    }




