using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
     

namespace ConsoleApplication3
{
    class Program
    {
        delegate int CountIt(int x);

        static void Main(string[] args)
        {
            CountIt testDel = (int x) => x + 5;
            int result = testDel(5);
            Console.WriteLine(result);
        } 
    } 
}
