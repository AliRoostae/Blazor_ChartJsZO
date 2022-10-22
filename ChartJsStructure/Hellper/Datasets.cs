using Newtonsoft.Json;

namespace ChartJsStructure.Hellper
{
    public partial class Datasets
        {
            [JsonProperty("line")]
            public Line? Line { get; set; }
        }

     
    }




