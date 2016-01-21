using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Game_Pocket
    {
        public Game_Pocket()
        {
            Console.WriteLine("Game Pocket initialized");
        }

        public void Connecting()
        {
            Console.WriteLine("Connecting to the game...");
        }

        public void Playing()
        {
            Console.WriteLine("playing....");
        }

        public int Sit()
        {
            Console.WriteLine("sitting");
            Player player = new Player();
            player.rest = 123; 
            return player.rest; 
        }
    }
}
