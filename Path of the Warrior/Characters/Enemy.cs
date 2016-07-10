using Interfaces;
using Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Enemy : Character, IHasAvatar
    {
       public Item Loot { get; set; }

        public Enemy(string name, int hp, int dmg, Item loot) :base(hp,dmg)
        {
            this.Loot = loot;
        }
    }
}
