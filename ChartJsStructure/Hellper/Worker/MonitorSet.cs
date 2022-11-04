using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJsStructure.Hellper.Worker
{

    public class MointorBase
    {
        public string NameDataSet { get; set; }
        public string BackgroundColor { get; set; }
        public bool? Fill { get; set; }
    }
    public class MonitorSet
    {
        public    byte Part { get; private set; }
        public   MointorBase[] DataSet { get; private set; } 
        public MonitorSet(byte part, MointorBase[] dataSet)
        {
            Part = part;
            DataSet = dataSet;
        }
  
      
        

       

    }
}
