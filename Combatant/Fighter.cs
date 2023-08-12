using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Combatant
{
    internal class Fighter
    {
        public string Name { get; private set; }
        public int Healt { get; private set; }  
        public string Damage { get; private set; }
        public virtual Fighter CreateFighter()
        {
            return new Fighter();
        }
    }

}
