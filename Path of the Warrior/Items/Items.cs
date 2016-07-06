namespace DungeonProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class  Item
    {
        private string name;
        private string description;

        protected Item(string Name, string Description)
        {
            name = Name;
            description = Description;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("no no no");
                }
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            private set
            {
                description = value;
            }
        }
    }

    public abstract class Gear : Item
    {
        private int cost;
        private int weight;

        public Gear(string Name, string Description, int Cost, int Weight) 
            : base(Name, Description)
        {
            this.weight = Weight;
            this.cost = Cost;
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                weight = value;
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }
            private set
            {
                cost = value;
            }
        }
    }

    public class Consumable : Item
    {
        private int hP;

        public Consumable(string Name, string Description, int HP) : base(Name, Description)
        {
            this.hP = HP;
        }

        public int HP
        {
            get
            {
                return hP;
            }
            private set
            {
                hP = value;
            }
        }
    }

    public class Trophy : Item
    {
        public Trophy(string Name, string Description) : base(Name, Description)
        { }
    }

    public class Weapon : Gear
    {
        private int dMG;

        public Weapon(string Name, string Description, int Cost, int Weight, int DMG) : base(Name, Description, Cost, Weight)
        {
            this.dMG = DMG;
        }

        public int DMG
        {
            get
            {
                return dMG;
            }
            private set
            {
                dMG = value;
            }
        }
    }

    public class Armor : Gear
    {
        private int hP;

        public Armor(string Name, string Description, int Cost, int Weight, int HP) : base(Name, Description, Cost, Weight)
        {
            this.hP = HP;
        }

        public int HP
        {
            get
            {
                return hP;
            }
            private set
            {
                hP = value;
            }
        }
    }
}