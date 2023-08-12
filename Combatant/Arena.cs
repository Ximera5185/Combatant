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

        Fighter [] fighters = new Fighter [5] { new Kashchei(), new Dragon(), new Goblin(), new BabaYaga(), new WaterMan()} ;

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

       /* private void AddFightersList()
        {
            _listOfFighters.Add(_PositionOneCase, "Кащей // Супер сила : Восстанавливается здоровье на 10% при получении урона ");
            _listOfFighters.Add(_PositionTwoCase, "Змей-Горыныч // Супер сила : ");
            _listOfFighters.Add(_PositionThreeCase, "Леший // Супер сила : ");
            _listOfFighters.Add(_PositionFourCase, "Баба-Яга // Супер сила : ");
            _listOfFighters.Add(_PositionFiveCase, "Водяной // Супер сила : ");
        }*/

        public void StartArena()
        {
            Console.WriteLine($"Выберите 1-го бойца из списка");

            fighter1 = ChoiceArray(fighter1);

            Console.Clear();
            Console.WriteLine($"Выберите 2-го бойца из списка");

            fighter2 = ChoiceArray(fighter2);

          
            Console.ReadKey();
        }


        private Fighter ChoiceArray() 
        {
            int inputUserNumber = Convert.ToInt32(Console.ReadLine());

            Fighter fighter = null;

            for (int i = 0; i < fighters.Length; i++)
            {
                if (inputUserNumber == i+1)
                {
                // реализация вывода инфы о бойце
                    Console.WriteLine($"{fighters[i].??}");
                    fighter = fighters[i].CreateFighter();

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