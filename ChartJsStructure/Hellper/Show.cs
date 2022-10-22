using Newtonsoft.Json;

namespace ChartJsStructure.Hellper
{
    public partial class Show
        {
            [JsonProperty("animations")]
            public ShowAnimations? Animations { get; set; }
        }

     
    }




