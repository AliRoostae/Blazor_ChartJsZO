using Newtonsoft.Json;

namespace Blazor_ChartJsZO.Hellper
{
    public  class Transitions
        {
            [JsonProperty("show")]
            public Show? Show { get; set; }

            [JsonProperty("hide")]
            public Hide? Hide { get; set; }
        }

     
    }




