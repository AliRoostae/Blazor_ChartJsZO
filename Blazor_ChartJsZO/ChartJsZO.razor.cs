using Blazor_ChartJsZO.Hellper;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;


namespace Blazor_ChartJsZO
{
    partial class ChartJsZO
    {
   
        private DotNetObjectReference<ChartJsZO>? objRef;
        public void Dispose()
        {
            objRef?.Dispose();
        }
        protected override void OnInitialized()
        {
            objRef = DotNetObjectReference.Create(this);
            JS.InvokeAsync<string>("SetAssemblyName", objRef);
            
        }

        [JSInvokable]
        public  void ClickChartZo(string argo)
        {
            var result = JsonConvert.DeserializeObject<EventClickChart>(argo);
            ChartClick.InvokeAsync(result);
        }
        static int Id = 0;
        string ChatrID { get; set; } = $"chartZeroOne{++Id}";
        //ChartBase _configChart =new ChartBase();
        [Parameter]
        public ChartBase ChartConfig { get; set; }
       
         [Parameter]
        public EventCallback<EventClickChart> ChartClick { get; set; }

       
        protected override void OnAfterRender(bool firstRender)
        {
            if (!firstRender) return;
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
            var jspr = JsonConvert.SerializeObject(dataset, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
            JS.InvokeVoidAsync("SetDataChart", ChatrID, jspr);
            StateHasChanged();
        }
      

       



    }
}
