using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class ChocolateBar: Confection
    {
        private string _type;

        public ChocolateBar()
        {
            _weight = 100;
            _name = "Alenka";
            _type = "milk";
        }

        public ChocolateBar(int weight, string name, string type)
        {
            _weight = weight;
            _name = name;
            _type = type;
        }
    }
}
