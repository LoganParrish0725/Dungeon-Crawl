using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeon_Crawl
{
    class Equipped
    {
        public int PrimaryWeapon { get; set; }
        public int HeadSlot { get; set; }
        public int BodySlot { get; set; }
        public int LegSlot { get; set; }

        public Equipped()
        {
            this.PrimaryWeapon = 5;
            this.HeadSlot = 0;
            this.BodySlot = 0;
            this.LegSlot = 0;
        }
    }
}
