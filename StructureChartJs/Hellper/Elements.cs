using Newtonsoft.Json;

namespace StructureChartJs.Hellper
{
    public partial class Elements
        {
            [JsonProperty("point")]
            public Point? Point { get; set; }
            [JsonProperty("line")]
            public Line? Line { get; set; }

            [JsonProperty("bar")]
            public Bar? Bar { get; set; }

            [JsonProperty("arc")]
            public Arc? Arc { get; set; }
        }

     
    }




