using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Player
    {
        public int rest = 0;

        public Player()
        {
            Console.WriteLine("game pocket started");
        }

        public void Jump()
        {
            Console.WriteLine("Jumping....");
        }
        public void Walk()
        {
            Console.WriteLine("Walking...."); 
            Game_Pocket game_pocket =  new Game_Pocket();
            game_pocket.Playing(); 
        }

        public void Swimming()
        {
            Console.WriteLine("Swimming....");
        }
    }
}
