using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningRPG.Locations
{
    internal class Forest
    {
        public void Location()
        {
            Console.Clear();

            Console.WriteLine($"Вы заходите в густой лес в котором полно опасных тварей.");
            Console.WriteLine();
            Console.WriteLine($"Исследовать лес в поиске предметов");
            Console.WriteLine($"Пойти на охоту");
            Console.WriteLine();

            Console.WriteLine($"1 - Исследовать лес в поиске предметов\n" +
                              $"2 - Пойти на охоту\n" +
                              $"3 - Отправиться в путешествие\n");

            try
            {
                int selectLocation = Convert.ToInt32(Console.ReadLine());

                switch (selectLocation)
                {
                    case 1:
                        
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        ChoiceOfLocation choiceOfLocation = new ChoiceOfLocation();
                        choiceOfLocation.ListOfLocations();
                        break;

                }

            }
            catch (Exception)
            {
                ErrorsUsers errorsUsers = new ErrorsUsers();
                errorsUsers.ErrorInputUser();
                Location()
            }


        }
    }
}
