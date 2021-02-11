using System.Collections.Generic;
using GameStructure;

namespace GameController
{
    public class TrainCommand : Command
    {
        public TrainCommand(Army units, Region region, int slotID) : base(CommandType.Train) {
            Army = units.Battalions;
            Region = region.Id;
            Slot = slotID;
        }

        public readonly Dictionary<UnitType, int> Army;
        public readonly string Region;
        public readonly int Slot;
    }
}
