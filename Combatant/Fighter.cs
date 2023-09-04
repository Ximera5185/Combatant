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

        public void GetDamage(int damage)
        {
            Healt -= damage;
        }
        public void Attack(Fighter enemy)
        {
            enemy.GetDamage(Damage);
        }
    }

}
