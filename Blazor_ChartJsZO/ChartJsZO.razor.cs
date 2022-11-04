


using ChartJsStructure.Hellper;
using ChartJsStructure.Hellper.Worker;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;

namespace Blazor_ChartJsZO
{
     partial class ChartJsZO: Base
    {

        internal DotNetObjectReference<ChartJsZO>? objRef;
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
        [Parameter]
        public EventCallback<EventClickChart> ChartClick { get; set; }
        [JSInvokable]
        public void ClickChartZo(string argo)
        {
            var result = JsonConvert.DeserializeObject<EventClickChart>(argo);
            ChartClick.InvokeAsync(result);
        }
        public void InitChart(ConfigChart argo)
        {
            JS.InvokeVoidAsync("SetConfigChart", ChatrID, Init(argo));
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
            var jspr = UpdateDetasetInternal(argo, index);
            if(string.IsNullOrEmpty(jspr))return;
            JS.InvokeVoidAsync("UpdateDetaset", ChatrID, jspr, index);
           
        }
      
      public void AddDataToDetaset(List<AddDataToDetasetChart> argo, int index)
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
            var dataAdd = argo.Select(i => i.Data);
            select.Data.AddRange(dataAdd);
            var count = select.Data.Count();
            var countlabel = dataset.Labels.Count();
            if (countlabel < count)
                dataset.Labels.AddRange(argo.Select(i=>i.Label));
             countlabel = dataset.Labels.Count();
            if(countlabel < count)
            {
                var dif =  count - countlabel;
                for (int i = 0; i < dif; i++)
                {
                    var setLab = i < argo.Count() - 1 ? argo[i].Data : "__NO__";
                    dataset.Labels.Add($"Not Label value {setLab}");
                }

               
            }
        UpdateLabel(dataset.Labels);
            var jspr = JsonConvert.SerializeObject(dataAdd, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
            JS.InvokeVoidAsync("AddDataToDetaset", ChatrID, jspr, index);
        }
         public void RemoveDataToDetaset(int indexData, int indexChart)
        {
            indexChart = indexChart < 0 ? 0 : indexChart;
            indexData = indexData < 0 ? 0 : indexData;
            if (ChartConfig == null) return;
            var dataset = ChartConfig.Data;
            if (dataset == null) dataset = new DataChart();
            if (indexChart + 1 > dataset.Datasets?.Count()) return;
       
            var select = dataset?.Datasets?[indexChart];
            if (select == null) return;
            if (indexData + 1 > select.Data?.Count()) return;
            select.Data.RemoveAt(indexData);

            JS.InvokeVoidAsync("RemoveDataToDetaset", ChatrID, indexData, indexChart);
        }

      public void UpdateDataChart(DataChart argo)
        {

            var jspr = UpdateDataChartInternal(argo);
            if (string.IsNullOrEmpty(jspr)) return;
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
