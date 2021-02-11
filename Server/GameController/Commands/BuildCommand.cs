using GameStructure;

namespace GameController
{
    public class BuildCommand : Command
    {
        public BuildCommand(BuildingType building, Region region, int slotID) : base(CommandType.Build) {
            Building = building;
            Region = region.Id;
            Slot = slotID;
        }

        public readonly BuildingType Building;
        public readonly string Region;
        public readonly int Slot;
    }
}
