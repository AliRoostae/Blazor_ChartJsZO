﻿using System.Runtime.Serialization;

namespace Blazor_ChartJsZO.Hellper
{
    public enum BorderSkipped
        {
            start, end, middle, bottom, top, left, right,
            [EnumMember(Value = "false")]
            FalseSet
        }
    }




