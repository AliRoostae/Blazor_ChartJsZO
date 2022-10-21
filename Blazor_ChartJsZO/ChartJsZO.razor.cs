
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using StructureChartJs.Hellper;

namespace Blazor_ChartJsZO
{
    partial class ChartJsZO
    {
   
        private DotNetObjectReference<ChartJsZO>? objRef;
        public void Dispose()
        {
            objRef?.Dispose();
            JS.InvokeAsync<string>("DisposAssemblyName", ChatrID);
        }
        protected override void OnInitialized()
        {
            objRef = DotNetObjectReference.Create(this);
            JS.InvokeAsync<string>("SetAssemblyName", objRef, ChatrID);
            
        }

        [JSInvokable]
        public  void ClickChartZo(string argo)
        {
            var result = JsonConvert.DeserializeObject<EventClickChart>(argo);
            ChartClick.InvokeAsync(result);
        }
        static int Id = 0;
        string ChatrID { get; set; } = $"chartZeroOne{++Id}";

         ChartBase ChartConfig { get; set; }
       
         [Parameter]
        public EventCallback<EventClickChart> ChartClick { get; set; }

        public void InitChart(ConfigChart argo)
        {
            ChartConfig = new ChartBase
            {
                Options = argo.Options,
                Type = argo.Type,
                Data = new DataChart()
            };
           var jspr = JsonConvert.SerializeObject(ChartConfig, Formatting.None,
                       new JsonSerializerSettings
                       {
                           NullValueHandling = NullValueHandling.Ignore
                       });
            JS.InvokeVoidAsync("SetConfigChart", ChatrID, jspr);
        }

       public  void AddDetaset(Dataset argo)
        {
            if(ChartConfig == null) return;
            if (argo == null) return;
            var dataset = ChartConfig.Data;
            if (dataset == null) dataset = new DataChart();
            dataset.Datasets.Add(argo);
            var jspr = JsonConvert.SerializeObject(argo, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
            JS.InvokeVoidAsync("SetDataChart", ChatrID, jspr);
    
        }
       
          public  void UpdateDetaset(Dataset argo,int index)
        { 
            if(index < 0) index = 0;
            if(ChartConfig == null) return;
            if (argo == null) return;
            var dataset = ChartConfig.Data;
            if (dataset == null) dataset = new DataChart();
            if ( index+1  > dataset.Datasets?.Count()) return;
            var select = dataset?.Datasets?[index];
            if (select==null) return;
            select = argo;
            var jspr = JsonConvert.SerializeObject(argo, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
            JS.InvokeVoidAsync("UpdateDetaset", ChatrID, jspr, index);
           
        }
      
          public void AddDataToDetaset(string[] argo, int index)
        {
            if (argo == null || !argo.Any()) return;
            if (index < 0) index = 0;
            if (ChartConfig == null) return;
            if (argo == null) return;
            var dataset = ChartConfig.Data;
            if (dataset == null) dataset = new DataChart();
            if (index + 1 > dataset.Datasets?.Count()) return;
            var select = dataset?.Datasets?[index];
            if (select == null) return;
           
            select.Data.AddRange(argo);

            var count = select.Data.Count();
            var countlabel = dataset.Labels.Count();
            if(countlabel < count)
            {
                var dif =  count - countlabel;
                for (int i = 0; i < dif; i++)
                {
                    dataset.Labels.Add($"Not Label value {argo[i]}");
                }

                UpdateLabel(dataset.Labels);
            }

            var jspr = JsonConvert.SerializeObject(argo, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
            JS.InvokeVoidAsync("AddDataToDetaset", ChatrID, jspr, index);
        }

          public void UpdateDataChart(DataChart argo)
        {
            if(argo == null) return;
            if (ChartConfig == null) return;
            if (ChartConfig.Data == null) ChartConfig.Data=new DataChart();
            ChartConfig.Data = argo;
            var jspr = JsonConvert.SerializeObject(argo, Formatting.None,
                        new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });
            JS.InvokeVoidAsync("UpdateDataChart", ChatrID, jspr);

        }

         public  void UpdateLabel(List<string> argo)
        {
            if(ChartConfig == null) return;
            if (argo == null) return;
            if(!argo.Any()) return;
            var dataset = ChartConfig.Data;
            if (dataset == null) dataset = new DataChart();
            dataset.Labels =argo;
            var jspr = JsonConvert.SerializeObject(argo, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
            JS.InvokeVoidAsync("UpdateLabelChart", ChatrID, jspr);
     
        }
      

         public  void UpdateType(TypChart argo)
        {
            if(ChartConfig == null) return;
            ChartConfig.Type =argo;
            var nam = argo.ToString();
            JS.InvokeVoidAsync("UpdateTypeChart", ChatrID, nam);
    
        }
      


       



    }
}
