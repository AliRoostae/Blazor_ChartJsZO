using System.Runtime.Serialization;

namespace ChartJsStructure.Hellper;

public enum Algorithm
    {
        lttb,
        [EnumMember(Value = "min-max")]
        minmax
    }

 




