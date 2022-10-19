using Newtonsoft.Json;

namespace StructureChartJs.Hellper
{
    public  class Transitions
        {
            [JsonProperty("show")]
            public Show? Show { get; set; }

            [JsonProperty("hide")]
            public Hide? Hide { get; set; }
        }

     
    }




