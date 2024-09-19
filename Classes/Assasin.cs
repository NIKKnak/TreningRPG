using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreningRPG.Classes
{
    internal class Assasin : MainClass
    {

        internal Assasin(string Name, string ClassRPG, int Armor, int Damage, int Health) : base(Name, ClassRPG, Armor, Damage, Health)
        {
            

        }
        /*
        internal void PrintCharacter()
        {
            Console.WriteLine($"Name: {name} Class: {classRPG} Armor: {armor} Damage: {damage}");
        }
        */

    }
}
