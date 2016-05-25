using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Candy: Confection
    {
        private string _type;

        public Candy(int weight, string name, string type)
        {
            _weight = weight;
            _name = name;
            _type = type;
        }
    }
}
