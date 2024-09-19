using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TreningRPG
{
    internal class Menu
    {
        internal void MenuText()
        {
            string menutext = $"1: Start \t 2:Exit";

            int width = Console.WindowWidth;
            int left = (width - menutext.Length) / 2;
            Console.SetCursorPosition(left, Console.CursorTop);
            Console.WriteLine(menutext);


            try
            {
                int enteredNumber = Convert.ToInt32(Console.ReadLine());

                switch (enteredNumber)
                {
                    case 1:
                        Console.WriteLine("GO!");
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Bye");
                        Environment.Exit(0); // исправить и сделать новую игру
                        break;
                }
            }
            catch (Exception)
            {
                ErrorsUsers errorsUsers = new ErrorsUsers();
                errorsUsers.ErrorInputUser();
                MenuText();
            }


            



        }




    }
}
