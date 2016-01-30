using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     

namespace ConsoleApplication3
{ 

    class Program
    {
        static void Main(string[] args)
        { 
            Dog dog = new Dog(); 
            Console.WriteLine("The dog is {0} years old and his name {1} and he loved to {2} and his color is {3}.", dog.Age(), dog.Name("Molly"), dog.Skills("dance"), dog.Color("brown"));


        }
    }

    
}
