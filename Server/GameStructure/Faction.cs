using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStructure
{
    public class Faction
    {
        public Faction() {
            PlayerId = Guid.NewGuid().ToString();
        }

        public string BrushString { get; set; }
        public string PlayerId { get; }


    }
}