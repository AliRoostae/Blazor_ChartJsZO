using System;
using System.Linq;
using System.Reflection;


namespace StructureChartJs.Hellper.Color
{
    internal static class ColorRandomZo
    {

        static Type typ = typeof(ColorChartZo);
        static MethodInfo[] methodInfos = typ.GetMethods().Where(i => i.DeclaringType == typ).ToArray();
        static Random random = new Random();

        public static string[] RandomColor(this int CoutLabel)
        {
            string[] result = new string[CoutLabel];
            for (int i = 0; i < CoutLabel; i++)
            {
                int value = random.Next(0, methodInfos?.Length ?? 0);
                MethodInfo? metod = methodInfos?[value];
                if (metod != null)
                {
                    var valueResult = metod.Invoke(null, new object[] { 0.5F });
                    result[i] = valueResult?.ToString() ?? string.Empty;
                }
                else result[i] = ColorChartZo.red();


            }
            return result;
        }



    }

}
