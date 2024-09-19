using System.Runtime.CompilerServices;
using System.Threading.Channels;
using TreningRPG.Classes;
using TreningRPG.Locations;
using TreningRPG.Mahanics;

namespace TreningRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // приветственный текст
            Greetings greetings = new Greetings();
            greetings.GreetingsText("Эта истооия о приключениях и подземельях");

            Console.WriteLine();

            // меню
            Menu menu = new Menu();
            menu.MenuText();

            //создаем персонажа
            SelectClass selectClass = new SelectClass();
            MainClass myHero = selectClass.EnterClass() as MainClass;
            myHero.PrintCharacter();

            ChoiceOfLocation choiceOfLocation = new ChoiceOfLocation();
            choiceOfLocation.ListOfLocations();





            // базовая локация
            /*BaseLocation baseLocation = new BaseLocation();
            baseLocation.Location();*/




            /*SkeletonVarior skeletonVarior = new SkeletonVarior();
            skeletonVarior.PrintCharacter();



            Fight fight = new Fight();
            fight.StartBattle((MainClass)myHero, skeletonVarior);*/




        }

    }
}