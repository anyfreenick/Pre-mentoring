using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Gift
    {
        private int _totalWeight;
        private int _confectionQuantity;
        private List<Confection> _giftComposition;

        public Gift()
        {
            _totalWeight = 0;
            _confectionQuantity = 0;
            _giftComposition = new List<Confection>();
        }

        public void Add(Confection conf)
        {
            _giftComposition.Add(conf);
            _confectionQuantity++;
            _totalWeight += conf.Weight;
        }

        public void ShowGiftInfo()
        {
            Console.WriteLine("В подарке содержатся следующие конфеты:\n");
            foreach (var conf in _giftComposition)
            {
                if (conf is Candy)
                    conf.ToString();
            }

            Console.WriteLine("");
            Console.WriteLine("В подарке содержатся следующие шоколадки:\n");
            foreach (var conf in _giftComposition)
            {
                if (conf is ChocolateBar)
                    conf.ToString();
            }
            Console.WriteLine("");
            Console.WriteLine("Общий вес подарка - " + _totalWeight);
        }
    }
}
