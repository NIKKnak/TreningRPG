using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningRPG.Locations
{
    internal class ChoiceOfLocation
    {
        public void ListOfLocations()
        {
            Console.Clear();

            Console.WriteLine($"Куда мы отправимся ?");
            Console.WriteLine();
            Console.WriteLine($"1 - Родная деревня");
            Console.WriteLine($"2 - Лес");



            try
            {
                int selectLocation = Convert.ToInt32(Console.ReadLine());

                switch (selectLocation)
                {
                    case 1:
                        BaseLocation baseLocation = new BaseLocation();
                        baseLocation.Location();
                        break;

                    case 2:
                        Forest forest = new Forest();
                        forest.Location();
                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                }

            }
            catch (Exception)
            {
                ErrorsUsers errorsUsers = new ErrorsUsers();
                errorsUsers.ErrorInputUser();
                ListOfLocations();
            }




            



        }


    }
}
