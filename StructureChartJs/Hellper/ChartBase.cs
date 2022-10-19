using Newtonsoft.Json;

namespace StructureChartJs.Hellper
{
    public class ChartBase : ConfigChart
        {

            [JsonProperty("data")]
            public DataChart Data { get; set; }=new DataChart();

        }
    }




