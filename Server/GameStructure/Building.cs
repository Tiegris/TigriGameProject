using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStructure
{
    public class Building
    {
        public bool Persistent {
            get => default;
            set {
            }
        }

        public BuildingType Type {
            get => default;
            set {
            }
        }

        public Materials Cost {
            get => default;
            set {
            }
        }

        public Materials Production {
            get => default;
            set {
            }
        }

        public BattleBonuses BattleBonus {
            get => default;
            set {
            }
        }

        public UnitType CanTrain {
            get => default;
            set {
            }
        }
    }
}