using Newtonsoft.Json;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Layout
        {
            [JsonProperty("padding")]
            public Padding? Padding { get; set; } 
    
           [JsonProperty("autoPadding")]
            public bool? AutoPadding { get; set; }
        }

     
    }




