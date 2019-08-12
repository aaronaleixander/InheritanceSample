using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            p1.Attack = 100;
            p1.Name = "Link";
            p1.Health = 20.75;
            p1.Stamina = 9.99;

            Enemy e = new Enemy();
            e.EnemyId = 1;
            e.Defense = 100;

            Creature c = new Creature();

            Creature c2 = new Player();

            // How can we set stamina when we know the creature is a player
            

            

        }
    }
}
