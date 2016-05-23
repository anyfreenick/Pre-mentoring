using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1.1: Calculator
namespace Pre_mentoring_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            showMenu();
            int choise = int.Parse(Console.ReadLine());
            if (choise > 4)
                return;
            Console.WriteLine("Введите число a");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            decimal b = decimal.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Сумма чисел a и b равна " + plus(a, b));
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Разница чисел a и b равна " + minus(a, b));
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Произведение числел a и b равно " + multiply(a, b));
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Частное чисел a и b равно " + divide(a, b));
                    Console.ReadKey();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4 or 5.");
                    break;
            }
        }

        private static void showMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Выход");
        }

        private static decimal plus(decimal a, decimal b)
        {
            return a + b;
        }

        private static decimal minus(decimal a, decimal b)
        {
            return a - b;
        }

        private static decimal multiply(decimal a, decimal b)
        {
            return a * b;
        }

        private static decimal divide(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
