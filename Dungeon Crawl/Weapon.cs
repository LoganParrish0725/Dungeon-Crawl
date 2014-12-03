using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeon_Crawl
{
    class Weapon
    {
        public string Name { get; set; }
        public int InventorySpace { get; set; }
        public int WeaponDamage { get; set; }

        public Weapon(string Name, int InventorySpace, int WeaponDamage)
        {
            this.Name = Name;
            this.InventorySpace = InventorySpace;
            this.WeaponDamage = WeaponDamage;
        }
        
    }
}
