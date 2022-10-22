using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsStructure.Hellper.Color
{
    public class RGBA
    {
        public RGBA(byte r, byte g, byte b, float o)
        {
            red = r;
            green = g;
            blue = b;
            opacity = o;
        }
        public override string ToString()
        {
            return $"rgb({red},{green},{blue},{opacity})";
        }

        byte red { get; set; }
        public byte Red => red;
        byte green { get; set; }
        public byte Green => green;

        byte blue { get; set; }
        public byte Blue => blue;

        float opacity { get; set; }
        public float Opacity => opacity;



    }
}
