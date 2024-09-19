using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TreningRPG.Classes;
using TreningRPG.VisualInterface;

namespace TreningRPG
{
    internal class SelectClass
    {

        internal object EnterClass()
        {
            Console.WriteLine("Enter name");

            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Select class\n1: Warior\t2: Assasin");

            int selectClass = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            Greetings greetings = new Greetings();

            Console.Clear();
            greetings.GreetingHero();
            Console.WriteLine();
            switch (selectClass)
            {
                case 1:
                    Warior warior = new Warior(name, "Warior", random.Next(25, 35), random.Next(15, 25), 150);
                    return warior;

                case 2:
                    Assasin assasin = new Assasin(name, "Assasin", random.Next(25, 35), random.Next(15, 20), 100);
                    return assasin;
                default: return null;
            }

        }

    }
}
