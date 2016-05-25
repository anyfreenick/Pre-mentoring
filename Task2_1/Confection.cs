using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public abstract class Confection: IGetWeight
    {
        protected int _weight;
        protected string _name;
                
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public override string ToString()
        {
            Console.WriteLine("Название - " + Name + ", Вес - " + Weight);
            return null;
        }
    }
}
