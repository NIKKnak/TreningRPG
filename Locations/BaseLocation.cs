using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TreningRPG.Locations
{
    internal class BaseLocation
    {
        public void Location()
        {
            Console.Clear();

            Console.WriteLine($"Вы стоите на центральной улице в вашей родной деревне");
            Console.WriteLine();
            Console.WriteLine($"Здесь нечего не меняется, старик Генри варит свои зелья");
            Console.WriteLine($"Эдди кует мечи и доспехи на заказ");
            Console.WriteLine($"А трактирщик Джо предлагает работенку");
            Console.WriteLine();

            Console.WriteLine($"1 - Купить зейлье\n" +
                              $"2 - Купить снаряжение\n" +
                              $"3 - узнать про работенку\n" +
                              $"4 - Отправиться в путешествие\n");


            try
            {
                int selectNumber = Convert.ToInt32(Console.ReadLine());

                switch (selectNumber)
                {
                    case 1:
                        Potion();
                        break;

                    case 2:
                        ArmorAndWeapon();
                        break;

                    case 3:
                        Quest();
                        break;

                    case 4:
                        ChoiceOfLocation choiceOfLocation = new ChoiceOfLocation();
                        choiceOfLocation.ListOfLocations();
                        break;

                }
            }
            catch (Exception)
            {
                ErrorsUsers errorsUsers = new ErrorsUsers();
                errorsUsers.ErrorInputUser();
                Location();
            }
        }

        public void Potion()
        {
            Console.WriteLine($"Привет Генри!");
        }

        public void ArmorAndWeapon()
        {
            Console.WriteLine($"Привет Эдди");
        }

        public void Quest()
        {
            Console.WriteLine($"Привет Джо!");
        }


    }
}
