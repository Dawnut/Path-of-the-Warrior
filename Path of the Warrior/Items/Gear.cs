using System;
namespace DungeonProject
{


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

}