using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeon_Crawl
{
    class Player
    {
        public enum AttackType { Primary = 1, Block, Heal }

        Equipped Equipped = new Equipped();

        public string Name { get; set; }
        public int HP { get; set; }
        public int Keys { get; set; }
        public int Accuracy { get; set; }
        public int Ammo { get; set; }
        public int Mana { get; set; }
        public int Healing { get; set; }
        public int MaxHealth { get; set; }
        int damage = 0;
        public bool IsAlive
        {
            get
            {
                return HP > 0;
            }
        }
        public Player(string Name, int HP)
        {
            this.Keys = 1;
            this.MaxHealth = HP;
            this.HP = HP;
            this.Accuracy = 70;
            this.Ammo = 10;
            this.Mana = 30;
        }
        public int DoAttack(Enemy Enemy)
        {
            Random rng = new Random();

            string attack = Console.ReadLine();

            int trueAttack = int.Parse(attack);

            var Type = (AttackType)trueAttack;


            //if user inputs a number that the system does not recognize

            if (trueAttack != 1 && trueAttack != 2 && trueAttack != 3)
            {
                Console.Clear();
                damage = 0;
                Console.WriteLine("You try using something you don't have in your posession. You miss and your foe gets a free shot.");
            }

            switch (Type)
            {

                case AttackType.Primary:
                    
                    if (rng.Next(0,101) <= Accuracy)
                    {
                       Console.Clear();
                       damage = Equipped.PrimaryWeapon;
                       Enemy.HP -= damage;
                       Console.WriteLine("You succeed and deal " + Equipped.PrimaryWeapon + " damage.");
                    }
                    else
                    {
                        Console.Clear();
                        damage = 0;
                        Console.WriteLine("You miss.");
                    }
                    break;

                case AttackType.Block:

                    if (rng.Next(0,31) <= 21)
                    {
                        Console.Clear();
                        Console.WriteLine("Your block was successful and negates all of the damage.");
                        this.HP = this.HP + Enemy.damage;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Your block failed, and your enemies attack makes it past your flimsy arms.");
                    }
                    break;

                case AttackType.Heal:

                    if (this.Mana >= 10)
	                {
                        Console.Clear();
                        var currentHeal = rng.Next(0, this.MaxHealth / 2);
		                this.HP = this.HP + currentHeal;
                        this.Mana = this.Mana - 10;
                        Console.WriteLine("You successfully heal for " + currentHeal + " HP.");
                        break;
	                }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You didn't have enough Mana! Your foe gets a free shot.");
                    }

                   

                           break;
                     default:
                           break;

                   }
            return damage;
            
        }
        public void EquipPrimary(Equipped EquippedPrimary)
        {
            
        }
    }
}
