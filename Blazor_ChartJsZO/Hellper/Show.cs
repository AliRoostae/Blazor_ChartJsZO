using Newtonsoft.Json;

namespace Blazor_ChartJsZO.Hellper
{
    public partial class Show
        {
            [JsonProperty("animations")]
            public ShowAnimations? Animations { get; set; }
        }

     
    }




