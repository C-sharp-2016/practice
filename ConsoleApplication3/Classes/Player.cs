using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Player
    {

        private static int _MyVar = 0;
        public static int MyVar
        {
            get { return _MyVar; }
            set { _MyVar = value; }
        }

        public string testc()
        {
            return "asdasd";
        }
    }
}
