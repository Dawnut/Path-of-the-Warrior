using Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Hero :Character
    {
        public List<Item> inventory {get; set;}

        public Hero(string name, int hp, int dmg, List<Item> inventory) :base(name,hp,dmg)
        {
            this.inventory = new List<Item>();
        }

        public class Singleton
        {
            private static Singleton instance;

            private Singleton() { }

            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}
