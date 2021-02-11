using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameController
{

    public abstract class Command
    {
        public Command(CommandType type) {
            Type = type;
        }

        CommandType Type;
    }
}
