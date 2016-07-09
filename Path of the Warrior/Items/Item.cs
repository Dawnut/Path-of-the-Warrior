using System;

namespace Items
{
    public abstract class Item : Nameable
    {
        private string description;

        protected Item(string name, string Description) : base(name)
        {
            description = Description;
        }

        protected Item(string name)
            : base(name)
        {
        }

        protected Item() { }


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
