using Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Enemy : Character
    {
       public Item Loot { get; set; }

        public Enemy(string name, int hp, int dmg, Item loot) :base(name,hp,dmg)
        {
            this.Loot = loot;
        }
    }
}
