using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class Goblin : Fighter 
    {
        public override Fighter CreateFighter()
        {
            return new Goblin();
        }
    }
}
