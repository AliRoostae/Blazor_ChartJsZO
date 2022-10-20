using System.Globalization;

namespace Blazor_ChartJs_Sample.TestData
{
    public class TestData
    {
        static Random rnd = new Random();
        static int _min = 10;
        static int _max = 1000;
        public List<string> LabelMonth = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
        public List<string> DataForMonth = Enumerable.Repeat(0, 12).Select(i => rnd.Next(_min, _max).ToString()).ToList();
    }
}
