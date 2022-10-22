using Newtonsoft.Json;

namespace ChartJsStructure.Hellper
{
    public partial class ShowAnimations
        {
            [JsonProperty("x")]
            public FluffyX? X { get; set; }

            [JsonProperty("y")]
            public FluffyX? Y { get; set; }
        }

     
    }




