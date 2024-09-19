using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TreningRPG
{
    internal class Greetings
    {
        internal void GreetingsText(string text)
        {
            int width = Console.WindowWidth;
            int left = (width - text.Length) / 2;
            Console.SetCursorPosition(left, Console.CursorTop);

            foreach (var item in text)
            {
                Console.Write(item);
                Thread.Sleep(50);
            }
        }
        internal void GreetingHero() => Console.WriteLine("Welcome hero!!");





    }
}
