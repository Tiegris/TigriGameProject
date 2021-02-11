using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStructure
{
    public enum UnitType
    {
        None = 0,
        Footsoldier = 1 << 0,
        Halberdier = 1 << 1,
        Cavalry = 1 << 2,
        Support = 1 << 3
    }

    public static class UnitInfo
    {
        public static Materials Cost(this UnitType unit) =>
            unit switch {
                UnitType.Footsoldier => new Materials(food: 1),
                UnitType.Halberdier => new Materials(food: 1, wood: 1),
                UnitType.Cavalry => new Materials(food: 1, gold: 1),
                UnitType.Support => new Materials(wood: 1, gold: 1),
                _ => throw new NotImplementedException()
            };



    }
}