﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class Dragon : Fighter
    {
        public override Fighter CreateFighter()
        {
            return new Dragon();
        }
    }
}
