using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreningRPG.Classes;

namespace TreningRPG.Mahanics
{
    internal class TakingDamage
    {

        public int Damage(int heroDamage ,  int enemyArmor, int enemyHealt)
        {
            int damage = heroDamage - enemyArmor;

            if (enemyArmor > heroDamage)
                damage = 1;

            enemyHealt -= damage;

            return enemyHealt;
        }



    }
}
