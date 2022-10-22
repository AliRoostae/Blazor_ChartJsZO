using System;
using System.Collections.Generic;

using System.Globalization;
using ChartJsStructure.Hellper.Color;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChartJsStructure.Hellper
{

    public class Dataset : Border
        {
        

        string[]? backgroundColorSet { get; set; } 
            string[]? borderColorSet { get; set; } 

            [JsonProperty("hidden")]
            public bool? Hidden { get; set; }
            [JsonProperty("clip")]
            public int? Clip { get; set; }
            [JsonProperty("parsing")]
            public bool? Parsing { get; set; }

            [JsonProperty("type")]
            [JsonConverter(typeof(StringEnumConverter))]
            public TypChart? Type { get; set; }

            [JsonProperty("yAxisID")]
            public string? YAxisId { get; set; }

            [JsonProperty("hoverOffset")]
            public int? HoverOffset { get; set; }

            [JsonProperty("pointRadius")]
            public int? PointRadius { get; set; }

            [JsonProperty("pointStyle")]
            [JsonConverter(typeof(StringEnumConverter))]
            public PointStyle? PointStyle { get; set; }

            [JsonProperty("pointHoverRadius")]
            public int? PointHoverRadius { get; set; }

            [JsonProperty("fill")]
            public bool? Fill { get; set; }

            [JsonProperty("cubicInterpolationMode")]
            public string? CubicInterpolationMode { get; set; }

            [JsonProperty("tension")]
            public double? Tension { get; set; }

            [JsonProperty("spanGaps")]
            public bool? SpanGaps { get; set; }

            [JsonProperty("showLine")]
            public bool? ShowLine { get; set; }

            [JsonProperty("label")]
            public string? Label { get; set; }



            [JsonProperty("stack")]
            public string? Stack { get; set; }

            [JsonProperty("stepped")]
            public bool? Stepped { get; set; }



            [JsonProperty("order")]
            public int? Order { get; set; }

            [JsonProperty("data")]
            public List<string> Data { get; set; }=new List<string>();

            [JsonProperty("backgroundColor")]
            public string[]? BackgroundColor
            {

                get => RandomColor ? ColorRandomZo.RandomColor(Data?.Count??0) : backgroundColorSet;
                set
                {
                   
                    backgroundColorSet = value;
                }
            }

          
            public  override string[]? BorderColor
            {

                get => RandomColor ? ColorRandomZo.RandomColor(Data?.Count??0) : borderColorSet;
                set
                {
                  
                    borderColorSet = value;
                }
            }



            [JsonProperty("segment")]
            public Segment? Segment { get; set; }

            [JsonIgnore]
            public bool RandomColor { get;  set; }
    }

     
    }




