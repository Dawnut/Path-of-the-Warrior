using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Battle : Nameable
    {
        public Character Enemy { get; set; }
        public Item itemFound { get; set; }

        public Battle(string name, Character enemy, Item item) : base(name)
        {
            this.Enemy = enemy;
            this.itemFound = item;
        }
    }
}
