using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class WaterMan : Fighter
    {

        
        public WaterMan()
        {
            ShowInfo = "Водяной // Супер сила :";

            Name = "Водяной";

            Healt = 100;

            Damage = 10;
        }
        public override Fighter CreateFighter()
        {
            return new WaterMan();
        }



       
    }
}
