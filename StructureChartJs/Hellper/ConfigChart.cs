using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StructureChartJs.Hellper
{
    public class ConfigChart
        {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TypChart Type { get; set; } = TypChart.bar;



            [JsonProperty("options")]
            public Options Options { get; set; }= new Options();
        }
    }




