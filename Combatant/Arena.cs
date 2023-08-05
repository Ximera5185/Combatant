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

        Fighter fighter1;
        Fighter fighter2;

        public Arena()
        {
            AddFightersList();

        }

        public void ShowFighters()
        {
            foreach (KeyValuePair<int, string> fighter in _listOfFighters)
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

        public void StartArena()
        {
            ChoiceOfTheFirstFighter();
            ChoiceOfTheSecondFighter();
        }

        private void ChoiceOfTheFirstFighter() 
        {
            bool isProgramWork = true;

            int inputUserCommand;

            while (isProgramWork)
            {

                Console.WriteLine($"Выберите 1-го бойца из списка");

                ShowFighters();

                inputUserCommand = Convert.ToInt32(Console.ReadLine());

                if (_listOfFighters.ContainsKey(inputUserCommand))
                {
                    switch (inputUserCommand)
                    {
                        case 1:
                            fighter1 = new Kashchei();
                            break;
                        case 2:
                            fighter1 = new Dragon();
                            break;
                        case 3:
                            fighter1 = new Goblin();
                            break;
                        case 4:
                            fighter1 = new BabaYaga();
                            break;
                        case 5:
                            fighter1 = new WaterMan();
                            break;
                    }

                    isProgramWork = false;
                }
                else
                {
                    Console.WriteLine("Бойца под таким номером нет в списке");
                }
            }
        }

        private void ChoiceOfTheSecondFighter() 
        {
            bool isProgramWork = true;

            int inputUserCommand;

            while (isProgramWork)
            {

                Console.WriteLine($"Выберите 2-го бойца из списка");

                ShowFighters();

                inputUserCommand = Convert.ToInt32(Console.ReadLine());

                if (_listOfFighters.ContainsKey(inputUserCommand))
                {
                    switch (inputUserCommand)
                    {
                        case 1:
                            fighter2 = new Kashchei();
                            break;
                        case 2:
                            fighter2 = new Dragon();
                            break;
                        case 3:
                            fighter2 = new Goblin();
                            break;
                        case 4:
                            fighter2 = new BabaYaga();
                            break;
                        case 5:
                            fighter2 = new WaterMan();
                            break;
                    }

                    isProgramWork = false;
                }
                else
                {
                    Console.WriteLine("Бойца под таким номером нет в списке");
                }
            }
        }
    }
}
