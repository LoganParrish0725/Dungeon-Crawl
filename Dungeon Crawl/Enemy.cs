using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeon_Crawl
{
    class Enemy
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHealth { get; set; }
        public int PoisonCount { get; set; }
        public int damage = 0;
        int MaxDamage = 0;
        public bool IsAlive
        {
            get
            {
                return HP > 0;
            }
        }

        public Enemy(string Name, int HP, int MaxDamage)
        {
            this.MaxDamage = MaxDamage;
            this.MaxHealth = HP;
            this.HP = HP;
            this.PoisonCount = 0;
        }
        public int DoAttack(Player Player)
        {
            Random rng = new Random();


            //poisoning

            if (this.PoisonCount > 0)
            {
                Player.HP -= PoisonCount;
            }

            //regular hit
            if (rng.Next(0, 101) < 80)
            {
                damage = rng.Next(1, MaxDamage + 1);
                Console.WriteLine("Your foe hits you for " + damage + " damage.");
            }
            //they miss
            else
            {
                damage = 0;
                Console.WriteLine("Your foe misses you.");
            }
            Player.HP -= damage;
            return 0;
        }
    }
}
