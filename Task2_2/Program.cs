using System;
using System.Collections;
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
            Hashtable table = new Hashtable();
            var sw = new Stopwatch();
            int qty = 1000000;

            Console.WriteLine("Dictionary:\n");

            sw.Start();
            AddElementsToDict(dict, qty);
            sw.Stop();
            Console.WriteLine("Time taken to add {0} elements to dictionary - {1}", qty, sw.Elapsed.ToString());
            sw.Restart();
            RemoveElementsFromDict(dict, qty);
            sw.Stop();
            Console.WriteLine("Time taken to remove {0} elements from dictionary - {1}", qty, sw.Elapsed.ToString());
            Random rnd = new Random();
            sw.Restart();
            FindElementByKey(dict, rnd.Next(qty));
            sw.Stop();
            Console.WriteLine("Time taken to go through {0} elements in the dictionary and find a necessary element - {1}\n", qty, sw.Elapsed.ToString());

            Console.WriteLine("HashTable:\n");
            sw.Restart();
            AddElementsToHashTable(table, qty);
            sw.Stop();
            Console.WriteLine("Time taken to add {0} elements to hashtable - {1}", qty, sw.Elapsed.ToString());
            sw.Restart();
            RemoveElementsFromHashTable(table, qty);
            sw.Stop();
            Console.WriteLine("Time taken to remove {0} elements from hashtable - {1}", qty, sw.Elapsed.ToString());
            sw.Restart();
            FindElementInHashTable(table, "key" + rnd.Next(qty));
            sw.Stop();
            Console.WriteLine("Time taken to go through {0} elements in the hashtable and find a necessary element - {1}\n", qty, sw.Elapsed.ToString());
            Console.ReadKey();
        }

        #region Dictoinary related methods
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

        private static void FindElementByKey(Dictionary<int,string> dict, int key)
        {
            string str = "";
            foreach (var item in dict)
                if (item.Key == key)
                    str = item.Value;
        }
        #endregion

        #region Hashtable related methods
        private static void AddElementsToHashTable(Hashtable table, int qty)
        {
            for (int i = 0; i < qty; i++)
                table.Add("key" + i, "value" + i);
        }

        private static void RemoveElementsFromHashTable(Hashtable table, int qty)
        {
            for (int i = 0; i < qty; i++)
                table.Remove("key" + i);
        }

        private static void FindElementInHashTable(Hashtable table, object key)
        {
            string str = "";
            foreach (DictionaryEntry item in table)
                if (item.Key == key)
                    str = (string)item.Value;
        }
        #endregion
    }
}
