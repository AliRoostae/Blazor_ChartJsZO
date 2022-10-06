using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Blazor_ChartJsZO.Hellper
{
    public  class Tooltip
        {
            [JsonProperty("mode")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Mode? Mode { get; set; }

            [JsonProperty("enabled")]
            public bool? Enabled { get; set; }
            [JsonProperty("intersect")]
            public bool? Intersect { get; set; }

            [JsonProperty("position")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Position? Position { get; set; }
            [JsonProperty("backgroundColor")]
            public string[]? BackgroundColor { get; set; }



            [JsonProperty("titleColor")]
            public string[]? TitleColor { get; set; }
            [JsonProperty("titleFont")]
            public FontChart? TitleFont { get; set; }
            [JsonProperty("titleAlign")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Align? TitleAlign { get; set; }
            [JsonProperty("titleSpacing")]
            public int? TitleSpacing { get; set; }

            [JsonProperty("titleMarginBottom")]
            public int? TitleMarginBottom { get; set; }

            [JsonProperty("bodyColor")]
            public string[]? BodyColor { get; set; }

            [JsonProperty("bodyFont")]
            public FontChart? BodyFont { get; set; }

            [JsonProperty("bodyAlign")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Align? BodyAlign { get; set; }
            [JsonProperty("bodySpacing")]
            public int? BodySpacing { get; set; }
            [JsonProperty("footerColor")]
            public string[]? FooterColor { get; set; }

            [JsonProperty("footerFont")]
            public FontChart? FooterFont { get; set; }

            [JsonProperty("footerAlign")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Align? FooterAlign { get; set; }

            [JsonProperty("footerSpacing")]
            public int? FooterSpacing { get; set; }

            [JsonProperty("footerMarginTop")]
            public int? FooterMarginTop { get; set; }


            [JsonProperty("padding")]
            public Padding? Padding { get; set; }

            [JsonProperty("caretPadding")]
            public int? CaretPadding { get; set; }

            [JsonProperty("caretSize")]
            public int? CaretSize { get; set; }

            [JsonProperty("cornerRadius")]
            public int? CornerRadius { get; set; }

            [JsonProperty("multiKeyBackground")]
            public string[]? MultiKeyBackground { get; set; }
            [JsonProperty("displayColors")]
            public bool? DisplayColors { get; set; }

            [JsonProperty("boxWidth")]
            public int? BoxWidth { get; set; }

            [JsonProperty("boxHeight")]
            public int? BoxHeight { get; set; }

            [JsonProperty("boxPadding")]
            public Padding? BoxPadding { get; set; }

            [JsonProperty("usePointStyle")]
            public bool? UsePointStyle { get; set; }

            [JsonProperty("borderColor")]
            public string[]? BorderColor { get; set; }

            [JsonProperty("borderWidth")]
            public int? BorderWidth { get; set; }

            [JsonProperty("rtl")]
            public bool? RTL { get; set; }

            [JsonProperty("textDirection")]
        [JsonConverter(typeof(StringEnumConverter))]
            public TextDirection? TextDirection { get; set; }

            [JsonProperty("xAlign")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Xalign? Xalign { get; set; }

            [JsonProperty("yAlign")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Yalign? Yalign { get; set; }





        }

     
    }




