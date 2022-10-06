using Blazor_ChartJsZO.Hellper;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;


namespace Blazor_ChartJsZO
{
    partial class ChartJsZO
    {

        static int Id = 0;
        string ChatrID { get; set; } = $"chartZeroOne{++Id}";
        ChartBase _configChart =new ChartBase();
        [Parameter]
        public ConfigChart? ChartConfig
        {
            get => new ConfigChart
            {
                Options =_configChart.Options,
                Type = _configChart.Type
            }; 
            
            set
            {
                if(value == null) value = new ConfigChart();
                _configChart.Options = value.Options;
                _configChart.Type = value.Type;
                SetChart();
            }
        }
        DataChart _dataChart =new();
        [Parameter]
        public DataChart? DataChart
        {
            get => _dataChart;


            set
            {
                if(value == null) value = new DataChart();
                _configChart.Data = value;
                _dataChart = value;
                SetData();
            }
        }

        void SetData()
        {
            if (DataChart == null) return;
            var jspr = JsonConvert.SerializeObject(DataChart, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
            JSRuntime.InvokeVoidAsync("SetDataChart", ChatrID, jspr);
        }
        void SetChart()
        {
            if (ChartConfig == null) return;
            var jspr = JsonConvert.SerializeObject(ChartConfig, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
            JSRuntime.InvokeVoidAsync("SetConfigChart", ChatrID, jspr);
        }

    }
}
