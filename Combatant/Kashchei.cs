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
           ShowInfo = "Кащей // Супер сила : Восстанавливается здоровье на 10% при получении урона";

            Name = "Кащей";

            Healt = 100;

            Damage = 20;
        }
        public override Fighter CreateFighter()
        {
            return new Kashchei();
        }
    }
}
