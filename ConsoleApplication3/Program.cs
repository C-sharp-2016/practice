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
            // Declare variables
            int num1;
            int num2;

            // Ask to input new integer
            Console.WriteLine("Type a number to be multiplied: ");

            // Read the user input and convert from string to integer 32 bit
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask to input second integer
            Console.WriteLine("Type another number: ");

            // Read the user input and convert from string to integer 32 bit
            num2 = Convert.ToInt32(Console.ReadLine());

            // Mutiply the 2 integer inputed
            Console.WriteLine("The result is :" + num1 * num2);  

            // Wait to press any key before console quit
            Console.ReadKey();
        }
    }
}
