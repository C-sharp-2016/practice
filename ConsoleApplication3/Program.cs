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
            call(); 
            Console.WriteLine("test");
        }

        public static void call()
        {
            Game_Pocket game_pocket = new Game_Pocket();
            Player player = new Player(); 
            game_pocket.Connecting(); 
            player.Walk();
            player.Jump();
            player.Swimming(); 
             
            Console.WriteLine("sit {0}", game_pocket.Sit());
        }
    }
}
