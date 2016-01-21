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
            Testing testing = new Testing();
            testing.X = 12; 
            Console.WriteLine("total {0}", testing.X);
            testing.X = 60;
            testing.DisplayX(); 
            Console.WriteLine("This amega");
        }

        public static void print()
        {
            Console.WriteLine("test");
        }

    }


    class Testing : Program
    {
        private int xval;
        public int X
        {
            get
            {
                return xval;
            }
            set
            {
                if (value < 100)
                    xval = value + 200;
            }
        }

        public void DisplayX()
        {
            Console.WriteLine("The stored value is: {0}", xval);
            print();
        }

         
    }
}
