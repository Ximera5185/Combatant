using System;
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
            _listOfFighters.Add(1, "Кащей // Супер сила : Восстанавливается здоровье на 10% при получении урона ");
            _listOfFighters.Add(2, "Змей-Горыныч // Супер сила : ");
            _listOfFighters.Add(3, "Леший // Супер сила : ");
            _listOfFighters.Add(4, "Баба-Яга // Супер сила : ");
            _listOfFighters.Add(5, "Водяной // Супер сила : ");
        }

        private void StartMenu() 
        {
            bool isProgramWork = true;

            string inputUserCommand = "";

            while (isProgramWork)
            {
                switch (inputUserCommand)
                {
                    
                }
            }
        }

        private Kashchei CreateKashchei(Kashchei kashchei) 
        {
            kashchei = new Kashchei();

            return kashchei;
        }

        private Dragon CreateDragon(Dragon dragon)
        { 
            dragon = new Dragon();

            return dragon;
        }

        private Goblin CreateGoblin(Goblin goblin) 
        {
            goblin = new Goblin();

            return goblin;
        }

        private BabaYaga CreateBabaYaga(BabaYaga babaYaga) 
        {
            babaYaga = new BabaYaga();

            return babaYaga;
        }

        private WaterMan CreateWaterMan(WaterMan waterMan) 
        {
            waterMan = new WaterMan();

            return waterMan;
        }
    }
}
