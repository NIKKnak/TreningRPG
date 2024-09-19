using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreningRPG.Mahanics;
using TreningRPG.VisualInterface;

namespace TreningRPG
{
    internal class MainClass
    {
        internal string name { get; set; }
        internal string classRPG { get; set; }
        internal int armor { get; set; }
        internal int damage { get; set; }
        internal int health { get; set; }

        internal MainClass(string Name, string ClassRPG, int Armor, int Damage, int Health)
        {

            this.name = Name;
            this.classRPG = ClassRPG;
            this.armor = Armor;
            this.damage = Damage;
            this.health = Health;
        }

        internal  void PrintCharacter()
        {
            Console.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.Write(name);
            Console.ResetColor(); 

            Console.Write(" Class: ");
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.Write(classRPG);
            Console.ResetColor(); 

            Console.Write(" Armor: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(armor);
            Console.ResetColor(); 

            Console.Write(" Damage: ");
            Console.ForegroundColor = ConsoleColor.DarkRed; 
            Console.Write(damage);
            Console.ResetColor(); 

            Console.Write(" Health: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(health);
            Console.ResetColor(); 

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
        }


    }
}