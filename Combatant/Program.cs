using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatant
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int inputOneNumber;
            int inputTwoNumber;

            levelGenerator levelGenerator = new levelGenerator();

            Console.WriteLine("Выберите 1-го бойца");

            levelGenerator.ShowFighters();

            Console.WriteLine("Введите номер первого бойца");
            
            inputOneNumber = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Выберите 2-го бойца");

            levelGenerator.ShowFighters();

            Console.WriteLine("Введите номер второго бойца");

            inputTwoNumber = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
/*
Создать 5 бойцов, пользователь выбирает 2 бойцов и они сражаются друг с другом до смерти. 
У каждого бойца могут быть свои статы.
Каждый игрок должен иметь особую способность для атаки, которая свойственна только его классу!
Если можно выбрать одинаковых бойцов, то это не должна быть одна и та же ссылка на одного бойца,
чтобы он не атаковал сам себя.
Пример, что может быть уникальное у бойцов. Кто-то каждый 3 удар наносит удвоенный урон, 
другой имеет 30% увернуться от полученного урона, кто-то при получении урона немного себя лечит.
Будут новые поля у наследников. У кого-то может быть мана и это только его особенность.*/