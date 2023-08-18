using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class Goblin : Fighter 
    {
        public Goblin()
        {
            ShowInfo = "Леший // Супер сила : ";

            Name = "Леший";

            Healt = 100;

            Damage = 15;
        }
        public override Fighter CreateFighter()
        {
            return new Goblin();
        }
    }
}
