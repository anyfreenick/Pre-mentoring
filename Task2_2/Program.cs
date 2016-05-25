using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Проверить скорость работы(добавление, поиск элемента, удаление) следующих коллекций:
//  Словари (HashTable vs Dictionary).
namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            var sw = new Stopwatch();
            int qty = 100000;
            sw.Start();
            AddElementsToDict(dict, qty);
            sw.Stop();
            Console.WriteLine("Time taken to add {0} elements to dictionary - {1}", qty, sw.Elapsed.ToString());
            sw.Restart();
            RemoveElementsFromDict(dict, qty);
            sw.Stop();
            Console.WriteLine("Time taken to remove {0} elements from dictionary - {1}", qty, sw.Elapsed.ToString());
            Console.ReadKey();
        }

        private static void AddElementsToDict(Dictionary<int, string> dict, int qty)
        {
            for (int i = 0; i < qty; i++)
                dict.Add(i, "Value - " + i);
        }

        private static void RemoveElementsFromDict(Dictionary<int,string> dict, int qty)
        {
            for (int i = 0; i < qty; i++)
                dict.Remove(i);
        }
    }
}
