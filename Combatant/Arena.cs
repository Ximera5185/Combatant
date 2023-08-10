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
 
            Console.WriteLine($"Выберите 1-го бойца из списка");

            fighter1 = ChoiceOfTheFirstFighter(fighter1);

            Console.Clear();
            Console.WriteLine($"Выберите 2-го бойца из списка");

            fighter2 = ChoiceOfTheFirstFighter(fighter2);
        }

        private Fighter ChoiceOfTheFirstFighter(Fighter fighter)
        {
            bool isProgramWork = true;

            int inputUserCommand;

            while (isProgramWork)
            {
                ShowFighters();

                inputUserCommand = Convert.ToInt32(Console.ReadLine());


                switch (inputUserCommand)
                {
                    case 1:
                        fighter = new Kashchei();
                        break;
                    case 2:
                        fighter = new Dragon();
                        break;
                    case 3:
                        fighter = new Goblin();
                        break;
                    case 4:
                        fighter = new BabaYaga();
                        break;
                    case 5:
                        fighter = new WaterMan();
                        break;
                }

                isProgramWork = false;

                if (_listOfFighters.ContainsKey(inputUserCommand) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Бойца под таким номером нет в списке");

                    fighter = null;

                    isProgramWork = true;
                }

            }

            return fighter;
        }
    }
}


