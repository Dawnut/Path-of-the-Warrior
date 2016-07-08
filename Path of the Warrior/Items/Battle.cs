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

        public bool isSelectable { get; set; }
        public bool isActive { get; set; }


        public Battle(string name, Character enemy, Item item, bool selectable, bool active) : base(name)
        {
            this.Enemy = enemy;
            this.itemFound = item;
            this.isSelectable = selectable;
            this.isActive = active;
        }
    }
}
