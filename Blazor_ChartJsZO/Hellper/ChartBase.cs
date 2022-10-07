using Newtonsoft.Json;

namespace Blazor_ChartJsZO.Hellper
{
    public class ChartBase : ConfigChart
        {

            [JsonProperty("data")]
            public DataChart Data { get; set; }=new DataChart();

        }
    }




