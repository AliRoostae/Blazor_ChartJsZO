using Newtonsoft.Json;

namespace StructureChartJs.Hellper
{
    public partial class Show
        {
            [JsonProperty("animations")]
            public ShowAnimations? Animations { get; set; }
        }

     
    }




