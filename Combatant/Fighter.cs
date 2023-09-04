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
        public string Name { get; protected set; }
        public int Healt { get; protected set; }  
        public int Damage { get; protected set; }

        public string ShowInfo { get; protected set; }
        public virtual Fighter CreateFighter()
        {
            return new Fighter();
        }

        public void GetDamage(Fighter fighterDamage)
        {
            Healt -= fighterDamage.Damage;
        }
        public void Attack(Fighter fighter,Fighter fighterDamage)
        {
            fighter.GetDamage(fighterDamage);
        }
    }

}
