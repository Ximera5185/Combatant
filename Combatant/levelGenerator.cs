﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class levelGenerator
    {
       readonly Dictionary<int, string> _listOfFighters = new Dictionary<int, string>();

        public levelGenerator() 
        {
            AddFightersList();
        }

        public void ShowFighters() 
        {
            foreach (KeyValuePair<int,string> fighter in _listOfFighters)
            {
                Console.WriteLine($"{fighter.Key} {fighter.Value}");
            }
        }

        private void AddFightersList() 
        {
            _listOfFighters.Add(1, "Самурай // Супер сила : ");
            _listOfFighters.Add(2, "Военный // Супер сила : ");
            _listOfFighters.Add(3, "Леший // Супер сила : ");
            _listOfFighters.Add(4, "Баба-Яга // Супер сила : ");
            _listOfFighters.Add(5, "Колобок // Супер сила : ");
        }
    }
}
