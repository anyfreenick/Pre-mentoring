using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1.2: Sort list or array by string length (Отсортировать список по длине строк)
namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = GenStringArray(20);
            Console.WriteLine("Unsorted array of randomly generated strings:\n");
            foreach (string val in values)
                Console.WriteLine(val);
            Console.WriteLine("-------------------------------------------------");
            IEnumerable<string> sortedValues = values.OrderBy(str => str.Length);
            foreach (var val in sortedValues)
                Console.WriteLine(val);
            Console.ReadKey();
        }

        private static List<string> GenStringArray(int quantity)
        {
            string abc = "qwertyuiopasdfghjklzxcvbnm";
            Random rnd = new Random();
            string result = "";
            char temp;
            List<string> values = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                result = "";
                int stringLength = rnd.Next(3, 25);
                for (int j = 0; j < stringLength; j++)
                {
                    temp = abc[rnd.Next(abc.Length)];
                    if (rnd.Next(0, 2) == 1)
                        temp = char.ToUpper(temp);
                    result += temp;                    
                }
                values.Add(result);
            }

            return values;
        }
    }
}
