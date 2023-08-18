using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class Dragon : Fighter
    {
        public Dragon()
        {
            ShowInfo = "Змей-Горыныч // Супер сила : ";

            Name = "Змей - Горыныч";

            Healt = 100;

            Damage = 20;
        }
        public override Fighter CreateFighter()
        {
            return new Dragon();
        }
    }
}
