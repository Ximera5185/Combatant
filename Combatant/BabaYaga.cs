using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class BabaYaga : Fighter
    {
        public BabaYaga()
        {
            ShowInfo = "Баба-Яга // Супер сила : ";
        }
        public override Fighter CreateFighter()
        {
            return new BabaYaga();
        }
    }
}
