using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class Arena
    {
       readonly Dictionary<int, string> _listOfFighters = new Dictionary<int, string>();

        

        public Arena() 
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

        public void StartMenu() 
        {
            bool isProgramWork = true;

            string inputUserCommand = "";

            while (isProgramWork)
            {
                const string CaseCreateKashchei = "1";
                const string CaseCreateDragon = "2";
                const string CaseCreateGoblin = "3";
                const string CaseCreateBabaYaga = "4";
                const string CaseCreateWaterMan = "5";

                Kashchei kashchei = null;
                Dragon dragon = null;
                Goblin goblin = null;
                BabaYaga babaYaga = null;
                WaterMan waterMan = null; 

                Console.WriteLine($"Выберите  бойца из списка");
                ShowFighters();
                
                inputUserCommand = Console.ReadLine();

                switch (inputUserCommand)
                {
                    case CaseCreateKashchei: CreateKashchei(kashchei);
                        break;
                    case CaseCreateDragon: CreateDragon(dragon);
                        break;
                    case CaseCreateGoblin: CreateGoblin(goblin);
                        break;
                    case CaseCreateBabaYaga: CreateBabaYaga(babaYaga);
                        break;
                    case CaseCreateWaterMan: CreateWaterMan(waterMan);
                        break;
                }
            }
        }

        private void CreateKashchei(Kashchei kashchei) 
        {
            kashchei = new Kashchei();
        }

        private void CreateDragon(Dragon dragon)
        { 
            dragon = new Dragon();
        }

        private void CreateGoblin(Goblin goblin) 
        {
            goblin = new Goblin();
        }

        private void CreateBabaYaga(BabaYaga babaYaga) 
        {
            babaYaga = new BabaYaga();
        }

        private void CreateWaterMan(WaterMan waterMan) 
        {
            waterMan = new WaterMan();
        }
    }
}
