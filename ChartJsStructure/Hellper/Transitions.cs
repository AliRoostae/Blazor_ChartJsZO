using Newtonsoft.Json;

namespace ChartJsStructure.Hellper
{
    public  class Transitions
        {
            [JsonProperty("show")]
            public Show? Show { get; set; }

            [JsonProperty("hide")]
            public Hide? Hide { get; set; }
        }

     
    }




