using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TreningRPG
{
    internal class RandomName
    {
        public string[] rndName = { "Skeleton Nik", "Skeleton Jack", "Skeleton Rik", "Skeleton Morty", "Skeleton Frank", "Skeleton Lui", "Skeleton Bob" };
        public string GetName()
        {

            Random rnd = new Random();
            int index = rnd.Next(rndName.Length);
            string name = rndName[index];
            return name;
        }
    }

}





