using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiegrisUtil.Graphics2D;

namespace GameStructure.Interfaces
{
    public interface IClickable
    {
        Hitbox Hitbox { get; }
    }
}
