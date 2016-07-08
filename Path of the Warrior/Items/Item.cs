using System;

namespace DungeonProject
{

    public abstract class Item : Nameable
    {
        private string description;

        protected Item(string name, string Description) : base(name)
        {
            description = Description;
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


}
