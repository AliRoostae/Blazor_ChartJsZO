using Newtonsoft.Json;

namespace ChartJsStructure.Hellper
{
    public class ChartBase : ConfigChart
        {

            [JsonProperty("data")]
            public DataChart Data { get; set; }=new DataChart();

        }
    }




