using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Dog : Animal
    {
        public Dog() :base ()
        {
            Console.WriteLine("This is a dog");
        }

        public override string Name(string name)
        {
            return " Dog name " + name;
        }

        public string Color(string color)
        {
            return color;
        }

        public string Skills(string skills)
        {
            return skills;
        }

    }
}
