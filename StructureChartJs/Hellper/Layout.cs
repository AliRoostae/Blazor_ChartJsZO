using Newtonsoft.Json;

namespace StructureChartJs.Hellper
{
    public partial class Layout
        {
            [JsonProperty("padding")]
            public Padding? Padding { get; set; } 
    
           [JsonProperty("autoPadding")]
            public bool? AutoPadding { get; set; }
        }

     
    }




