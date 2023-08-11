using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class Arena
    {
        private const int _PositionOneCase = 1;
        private const int _PositionTwoCase = 2;
        private const int _PositionThreeCase = 3;
        private const int _PositionFourCase = 4;
        private const int _PositionFiveCase = 5;

        readonly Dictionary<int, string> _listOfFighters = new Dictionary<int, string>();

        Fighter [] fighters = new Fighter [5] ;

        

        Fighter fighter1;
        Fighter fighter2;


        public Arena()
        {
            AddFightersList();
            AddFightersArray();
        }

        public void ShowFighters()
        {
            foreach (KeyValuePair<int, string> fighter in _listOfFighters)
            {
                Console.WriteLine($"{fighter.Key} {fighter.Value}");
            }
        }

        private void AddFightersArray() 
        {
            fighters [0] = new Kashchei();
            fighters [1] = new Dragon();
            fighters [2] = new Goblin();
            fighters [3] = new BabaYaga();
            fighters [4] = new WaterMan();
        }
        private void AddFightersList()
        {
            _listOfFighters.Add(_PositionOneCase, "Кащей // Супер сила : Восстанавливается здоровье на 10% при получении урона ");
            _listOfFighters.Add(_PositionTwoCase, "Змей-Горыныч // Супер сила : ");
            _listOfFighters.Add(_PositionThreeCase, "Леший // Супер сила : ");
            _listOfFighters.Add(_PositionFourCase, "Баба-Яга // Супер сила : ");
            _listOfFighters.Add(_PositionFiveCase, "Водяной // Супер сила : ");
        }

        public void StartArena()
        {

            Console.WriteLine($"Выберите 1-го бойца из списка");

            fighter1 = ChoiceArray(fighter1,fighters);

            Console.Clear();
            Console.WriteLine($"Выберите 2-го бойца из списка");

            fighter2 = ChoiceArray(fighter2,fighters);

            if (object.ReferenceEquals(fighter1, fighter2))
            {
                Console.WriteLine("Объекты имеют одну и ту же ссылку");
            }
            else
            {
                Console.WriteLine("Объекты имеют разные ссылки");
            }

            Console.ReadKey();
        }

        /*private Fighter ChoiceOfTheFirstFighter(Fighter fighter)
        {
            bool isProgramWork = true;

            int inputUserCommand;

            while (isProgramWork)
            {
                ShowFighters();

                inputUserCommand = Convert.ToInt32(Console.ReadLine());


                switch (inputUserCommand)
                {
                    case _PositionOneCase:
                        fighter = new Kashchei();
                        break;
                    case _PositionTwoCase:
                        fighter = new Dragon();
                        break;
                    case _PositionThreeCase:
                        fighter = new Goblin();
                        break;
                    case _PositionFourCase:
                        fighter = new BabaYaga();
                        break;
                    case _PositionFiveCase:
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
        }*/

        private Fighter ChoiceArray(Fighter fighter, Fighter [] fighters) 
        {
            int inputUserNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < fighters.Length; i++)
            {
                if (inputUserNumber == i+1)
                {
                    fighter = fighters[i];

                    return fighter;
                }
                else
                {
                    fighter = null;
                }
            }

            return fighter;
        }
    }
}