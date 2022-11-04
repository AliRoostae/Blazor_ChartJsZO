using ChartJsStructure.Hellper;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace Blazor_ChartJsZO
{
   public abstract class Base : ComponentBase
    {
       
        static int Id = 0;
       internal string ChatrID { get; set; } = $"chartZeroOne{++Id}";

       internal ChartBase ChartConfig { get; set; }

        internal string Init(ConfigChart argo)
        {
            ChartConfig = new ChartBase
            {
                Options = argo.Options,
                Type = argo.Type,
                Data = new DataChart()
            };
           return  JsonConvert.SerializeObject(ChartConfig, Formatting.None,
                        new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });
        }

        internal string UpdateDetasetInternal(Dataset argo, int index)
        {
            if (index < 0) index = 0;
            if (ChartConfig == null) return string.Empty;
            if (argo == null) return string.Empty;
            var dataset = ChartConfig.Data;
            if (dataset == null) dataset = new DataChart();
            if (index + 1 > dataset.Datasets?.Count()) return string.Empty;
            var select = dataset?.Datasets?[index];
            if (select == null) return string.Empty;
            select = argo;
            return JsonConvert.SerializeObject(argo, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
          

        }
        internal string UpdateDataChartInternal(DataChart argo)
        {
            if (argo == null) return string.Empty;
            if (ChartConfig == null) return string.Empty;
            if (ChartConfig.Data == null) ChartConfig.Data = new DataChart();
            ChartConfig.Data = argo;
            return JsonConvert.SerializeObject(argo, Formatting.None,
                        new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });
           

        }


    }
}
