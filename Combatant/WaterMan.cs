using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class WaterMan : Fighter
    {
        public override Fighter CreateFighter()
        {
            return new WaterMan();
        }
    }
}
