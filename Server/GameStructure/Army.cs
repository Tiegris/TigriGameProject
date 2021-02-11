using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStructure
{
    public class Army
    {
        public readonly Dictionary<UnitType, int> Battalions;

        public Army() {
            Battalions = new Dictionary<UnitType, int>();
            foreach (UnitType key in Enum.GetValues(typeof(UnitType))) {
                if (key == UnitType.None)
                    continue;
                Battalions.Add(key, 0);
            }
        }

        public void AddUnit(UnitType unit) {
            Battalions[unit]++;
        }

        public void RemoveUnit(UnitType unit) {
            Battalions[unit]--;
        }

        public void RemoveRandom(int count) {
            for (int i = 0; i < count; i++) {
                int typeCount = Battalions.Count;
                UnitType selected;
                do {
                    selected = (UnitType)Game.Random.ContinuousInt(0, typeCount);
                } while (Battalions[selected] == 0);
                Battalions[selected]--;
            }
        }

        public void AddUnits(UnitType unit) {
            foreach (UnitType key in Enum.GetValues(typeof(UnitType))) {
                if (key == UnitType.None)
                    continue;
                if (unit.HasFlag(unit))
                    Battalions[key]++;
            }
        }

    }
}