using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStructure
{
    public class Region
    {
        public string Id { get; }
        public string Name { get; }

        public Region(string name) {
            this.Name = name;
            this.Id = Guid.NewGuid().ToString();
        }

        private List<Slot> slots;
        private Forces forces;

        public List<Region> Neighbours {
            get => default;
            set {
            }
        }

        public Faction OwnerFaction {
            get => default;
            set {
            }
        }
    }
}