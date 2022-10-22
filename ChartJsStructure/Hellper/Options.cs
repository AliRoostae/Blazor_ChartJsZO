using Newtonsoft.Json;

namespace ChartJsStructure.Hellper
{
    public partial class Options
        {
            [JsonProperty("pointBackgroundColor")]
            public string? PointBackgroundColor { get; set; }
            [JsonProperty("devicePixelRatio")]
            public int? DevicePixelRatio { get; set; }

            [JsonProperty("fill")]
            public bool? Fill { get; set; }

            [JsonProperty("radius")]
            public int? Radius { get; set; }

            [JsonProperty("indexAxis")]
            public string? IndexAxis { get; set; }

            [JsonProperty("responsive")]
            public bool? Responsive { get; set; }

            [JsonProperty("maintainAspectRatio")]
            public bool? MaintainAspectRatio { get; set; }

            [JsonProperty("aspectRatio")]
            public int? AspectRatio { get; set; }
            [JsonProperty("resizeDelay")]
            public int? ResizeDelay { get; set; }



            [JsonProperty("showLine")]
            public bool? ShowLine { get; set; }

            [JsonProperty("stacked")]
            public bool? Stacked { get; set; }

            [JsonProperty("animation")]
            public OptionsAnimation? Animation { get; set; }

            [JsonProperty("animations")]
            public OptionsAnimations? Animations { get; set; }

            [JsonProperty("interaction")]
            public Interaction? Interaction { get; set; }

            [JsonProperty("datasets")]
            public Datasets? Datasets { get; set; }

            [JsonProperty("elements")]
            public Elements? Elements { get; set; }

            [JsonProperty("layout")]
            public Layout? Layout { get; set; }

            [JsonProperty("plugins")]
            public Plugins? Plugins { get; set; }

            [JsonProperty("scales")]
            public Scales? Scales { get; set; }

            [JsonProperty("transitions")]
            public Transitions? Transitions { get; set; }

        [JsonProperty("onClick")]
        public string OnClick => ""; 
        [JsonProperty("events")]
        public string[] Events => new[] { "click" } ;
        }

     
    }




