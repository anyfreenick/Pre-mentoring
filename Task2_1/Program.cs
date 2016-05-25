using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2.1: Спроектировать объектную модель для заданной предметной области
//Новогодний подарок:
//Новогодний подарок.Определить иерархию конфет и прочих сладостей.
//Создать несколько объектов-конфет.Собрать детский подарок с определением его веса.
//Провести сортировку конфет в подарке на основе одного из параметров.
//Найти конфету в подарке, соответствующую заданному диапазону параметров.

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gift gift = new Gift();

            gift.Add(new Candy(10, "MishkaNaSevere", "chocolate"));
            gift.Add(new Candy(30, "CupaChups", "lolipop"));

            gift.Add(new ChocolateBar(200, "Alenka", "Milk"));
            gift.Add(new ChocolateBar(90, "AlpenGold", "Friut"));

            gift.ShowGiftInfo();
            Console.ReadKey();
        }
    }
}
