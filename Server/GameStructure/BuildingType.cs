using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStructure
{
    public enum BuildingType
    {
        None = 0,
        Farm = 1 << 0,
        Fort = 1 << 1,
        Barack = 1 << 2
    }
}