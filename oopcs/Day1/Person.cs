using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcs
{
    class Person
    {
        private int _age;

        public Person()
        {
            Age = 1;
            Name = "";
        }

        public Person(string name)
        {
            Age = 1;
            Name = name;
        }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return _age / 365;
            }
            set
            {
                if (value > 0)
                    _age = value * 365;
                else
                    Console.WriteLine("Age cannot be negative");
            }
        }
    }
}
