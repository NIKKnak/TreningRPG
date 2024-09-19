using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreningRPG.Classes;
using TreningRPG.Mahanics;
using TreningRPG.VisualInterface;

namespace TreningRPG
{
    internal class Fight
    {


        internal void StartBattle(MainClass hero, MainClass enemy)
        {


            EnemyPanel enemyPanel = new EnemyPanel();
            
            HeroPanel heroPanel = new HeroPanel();
            

            DamageHero damageHero = new DamageHero();
            Console.WriteLine($"Hero Health: {hero.health}, Enemy Health: {enemy.health}");
            while (hero.health > 0 && enemy.health > 0)
            {

                Console.WriteLine("\n\nSelect an action");
                Console.WriteLine($"1: Attack \t 2:Defend");

                int select = Convert.ToInt32(Console.ReadLine());

                if (select == 1)
                {

                    enemy.health = damageHero.Damage(hero.damage, enemy.armor, enemy.health);
                    

                }
                else if (select == 2)
                {
                    hero.armor += 30;
                }


                if (enemy.health <= 0) break;

                hero.health = damageHero.Damage(enemy.damage, hero.armor, hero.health);
                

                if (select == 2)
                {
                    hero.armor -= 30;
                }

                Console.Clear();

                heroPanel.UpPanel();
                hero.PrintCharacter();
                enemyPanel.UpPanel();
                enemy.PrintCharacter();


            }

            if (hero.health > 0)
            {
                Console.WriteLine("Победа!");
            }
            else
            {
                Console.WriteLine("Вы пали в бою...");
            }


        }
    }
}
