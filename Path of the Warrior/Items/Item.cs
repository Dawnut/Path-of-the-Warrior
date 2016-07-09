using System;

namespace Items
{
    public abstract class Item : Nameable
    {
        private string description;

        protected Item(string name, string Description = null) : base(name)
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
