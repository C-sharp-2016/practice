using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     

namespace ConsoleApplication3
{
    class Program
    { 

        interface Iitem
        {
            string name { get; set; }
            int goldVal { get; set; }

            void Equip();
            void Sell();  

        }

        interface IDamage
        {
            int damage { get; set; }
            string attakerName { get; set; } 
        }


        class Sword : Iitem, IDamage
        {
            public string name { get; set; }
            public int goldVal { get; set; }

            public int damage { get; set; }
            public string attakerName { get; set; }

            public void Equip()
            {
                Console.WriteLine(name + " Equip this sword");
                Console.WriteLine(" The {0} sword was damaged", name);
            }
            public void Sell()
            {
                Console.WriteLine(name + "Sell this sword");
            }   
        }
         
        static void Main(string[] args)
        {

            Sword sword = new Sword();

            sword.name = "danger";
            sword.attakerName = "Tiger";
            sword.damage = 1000;

            sword.Equip();
            sword.Sell();
        } 
    } 
}
