using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    interface MyInterface
    {
        string Type { get; set; }  

        int Iq(int iq);
    }
    class Dog : Animal, MyInterface
    {
        private string type;
        public string Type {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        } 
         
         
        public Dog() :base ()
        {
            Console.WriteLine("This is a dog");
        }

         
        public int Iq(int iq)
        {
            return iq;
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
