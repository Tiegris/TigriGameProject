using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStructure
{
    public struct Materials
    {
        public int Wood;
        public int Gold;
        public int Food;

        public Materials(int wood = 0, int gold = 0, int food = 0) {
            Wood = wood;
            Gold = gold;
            Food = food;
        }
    }
}