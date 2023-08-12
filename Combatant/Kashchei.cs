using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class Kashchei : Fighter
    {

        public Kashchei()
        {
            // поле описание
        }
        public override Fighter CreateFighter()
        {
            return new Kashchei();
        }
    }
}
