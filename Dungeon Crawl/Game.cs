using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeon_Crawl
{
    class Game
    {
        public Player Player { get; set; }
        public Enemy Enemy { get; set; }

        public Game()
        {
            this.Player = Player;
            this.Enemy = Enemy;
        }
        public void DisplayCombatInfo()
        {
            //Player HUD showing current accuracy, poison damage per turn, and HP.
            Console.WriteLine("\n\n\n\n\n____________________________________________________________________________________________");
            Console.WriteLine("Health Meter : " + Player.HP + " / " + Player.MaxHealth + "                                          " + "Enemy Health : " + Enemy.HP + " / " + Enemy.MaxHealth);
            Console.WriteLine("                             Current mainhand accuracy : " + Player.Accuracy + "%");
            Console.WriteLine("                                     Mana remaining : " + Player.Mana);

            //handy conditional counter if you're poisoned
            if (Enemy.PoisonCount > 0)
            {
                Console.WriteLine("              \n               ================ Poison Damage Per Turn: " + Enemy.PoisonCount + "================");
            }

        }
        public void OverworldHUD()
        {
            //HUD showing equipped items, Number of Keys, Health, and Mana.
        }
        public void PlayGame()
        {
            //Where it all begins

            Equipped PlayerEquipped = new Equipped();


            this.Enemy = new Enemy("Mavis", 15, 2);
            this.Player = new Player("Dan",15);

            while (this.Player.IsAlive && this.Enemy.IsAlive)
            {
                DisplayCombatInfo();
                this.Player.DoAttack(Enemy);
                this.Enemy.DoAttack(Player);
            }
        }
        public void StandardLootFind()
        {
            //Code to run when enemy is killed / chest is opened
        }
    }
}
