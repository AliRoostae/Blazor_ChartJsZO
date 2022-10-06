using Newtonsoft.Json;

namespace Blazor_ChartJsZO.Hellper
{
    internal class ChartBase : ConfigChart
        {

            [JsonProperty("data")]
            public DataChart Data { get; set; }=new DataChart();

        }
    }




