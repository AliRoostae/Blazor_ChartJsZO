using System.Runtime.Serialization;

namespace ChartJsStructure.Hellper
{
    public enum BorderSkipped
        {
            start, end, middle, bottom, top, left, right,
            [EnumMember(Value = "false")]
            FalseSet
        }
    }




