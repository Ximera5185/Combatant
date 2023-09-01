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
            
        }

        public void ShowFighters()
        {
            foreach (KeyValuePair<int, string> fighter in _listOfFighters)
            {
                Console.WriteLine($"{fighter.Key} {fighter.Value}");
            }
        }

        public void LaunchCombat() 
        {
            int healtFighter1 = fighter1.Healt;
            int healtFighter2 = fighter2.Healt;
            int damageFighter1 = fighter1.Damage;
            int damageFighter2 = fighter2.Damage;

            while (healtFighter1 > 0 && healtFighter2 > 0)
            {

                Console.Clear();
                Console.WriteLine("<Бой\n" +
                $"Боец 1 {fighter1.Name} Здоровье {healtFighter1}%\n" +
                $"Боец 2 {fighter2.Name} Здоровье {healtFighter2}%");

                Console.WriteLine("Для старта раунда Нажмите клавишу пробел:");
                while (Console.ReadKey().Key != ConsoleKey.Spacebar)
                {
                
                }


                healtFighter2 -= damageFighter1;
                healtFighter1 -= damageFighter2;

                Console.WriteLine($" Игроки обменялись ударами\n") ;
            }


            Console.ReadKey();
        }
        public void StartArena()
        {
            Console.WriteLine($"Выберите 1-го бойца из списка");

            fighter1 = ChoiceFighters();

            Console.Clear();
            Console.WriteLine($"Выберите 2-го бойца из списка");

            fighter2 = ChoiceFighters();
        }


        private Fighter ChoiceFighters() 
        {
            ShowInfo();    

            int inputUserNumber = Convert.ToInt32(Console.ReadLine());

            Fighter fighter = null;

            for (int i = 0; i < fighters.Length; i++)
            {
                if (inputUserNumber == i+1)
                {   
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

        private void ShowInfo() 
        {
            for (int i = 0; i < fighters.Length; i++)
            {
                Console.WriteLine($"{fighters [i].ShowInfo}");
            }
        }
    }
}