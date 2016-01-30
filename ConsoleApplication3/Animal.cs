using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Animal
    {
        public Animal()
        {    
            Console.WriteLine("Animal started");
        }

        public int Age()
        {
            return 20;
        }

        public virtual string Name(string name)
        {
            return name;
        }
    }
}
