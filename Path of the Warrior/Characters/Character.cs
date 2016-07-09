using Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Characters
{
    public class Character :Nameable
    {
        public int HP { get; set; }
        public int DMG { get; set; }

        public Character() { }

        public Character(int hp, int dmg)
        {
            this.HP = hp;
            this.DMG = dmg;
        }

        public Character(string name, int hp, int dmg) :base(name)
        {
            this.Name = name;
            this.HP = hp;
            this.DMG = dmg;
        }


    }

}
