using ChartJsStructure.Hellper;
using ChartJsStructure.Hellper.Color;
using ChartJsStructure.Hellper.Worker;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_ChartJsZO
{
    partial class ChartJsZOMonitor:Base
    {
       

        public void InitChart(MonitorSet argo)
        {
            
            var cnf = new ConfigChart
            {
                Type = TypChart.line,
                Options = new Options
                {
                    Responsive = true,
                    Fill = true,

                }
            };
            string[] data = new string[argo.Part] ;
            var labe =new string[argo.Part] ;
            for (int i = 0; i < data.Length; i++)   data[i]= "1";
            for (int i = 0; i < labe.Length; i++) labe[i]=string.Empty;
            List<Dataset> dataSet = new List<Dataset>();
            foreach (var item in argo.DataSet)
            {
                dataSet.Add(new Dataset
                {
                    Data = data.ToList(),
                    Fill = item.Fill,
                    BorderWidth = 1,
                    Label = item.NameDataSet,
                    BackgroundColor = new[] { item.BackgroundColor },
                    BorderColor = !item.Fill==true ?new[] { item.BackgroundColor }:null,
                    PointRadius=0,
                    Tension = 0.4
                });
            }

            JS.InvokeVoidAsync("SetConfigChart", ChatrID, Init(cnf));
            var jspr = UpdateDataChartInternal(new DataChart
            {
                Labels = labe.ToList(),
                Datasets = dataSet
            });
            Thread.Sleep(1000);
            JS.InvokeVoidAsync("UpdateDataChart", ChatrID, jspr);

        }

        public void AddData(int idDataset,int data)
        {
            if (idDataset < 0) idDataset = 0;
            if (ChartConfig == null) return;
            var dataset = ChartConfig.Data;
            if (idDataset + 1 > dataset.Datasets?.Count()) return;
            var select = dataset?.Datasets?[idDataset];
            if (select == null) return;

            JS.InvokeVoidAsync("RemoveDataToDetaset", ChatrID, 0, idDataset);
            int[] sendData = new[] { data }; 
            var datach = JsonConvert.SerializeObject(sendData);
            JS.InvokeVoidAsync("AddDataToDetaset", ChatrID, datach, idDataset);
        }


    }
}
