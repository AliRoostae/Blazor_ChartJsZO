using Newtonsoft.Json;
using System.Collections.Generic;

namespace StructureChartJs.Hellper
{
    public class DataChart
        {
            [JsonProperty("labels")]
            public List<string> Labels { get; set; }= new List<string>();

            [JsonProperty("datasets")]
            public List<Dataset> Datasets { get; set; } =new List<Dataset>();
        }
    }




