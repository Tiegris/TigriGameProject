using System.Collections.Generic;
using GameStructure;

namespace GameController
{
    public class MoveCommand : Command
    {
        public MoveCommand(Army units, Region from, Region to) : base(CommandType.Move) {
            Army = units.Battalions;
            From = from.Id;
            To = to.Id;
        }

        public readonly Dictionary<UnitType, int> Army;
        public readonly string From;
        public readonly string To;
    }
}
