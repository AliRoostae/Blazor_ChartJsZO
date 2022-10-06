using System.Globalization;

namespace test.Data
{
    public class DataTest
    {
       static Random rnd = new Random();
       static int _min = 10;
       static int _max = 1000;
        public  List<string> LabelMonth = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
        public  List<string> DataForMonth = Enumerable.Repeat(0,12).Select(i=> rnd.Next(_min,_max).ToString()).ToList();
    }
}
