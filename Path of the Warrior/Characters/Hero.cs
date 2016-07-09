using Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Characters
{
    public class Hero :Character
    {
        public List<Item> Inventory {get; set;}
        public ImageSource Avatar { get; set; }

        public Hero() 
        {
            this.Inventory = new List<Item>();
        }

        public Hero(int hp, int dmg, List<Item> inventory) :base(hp,dmg)
        {
            this.Inventory = new List<Item>();
        }

    }
}
