using Interfaces;
using System;
using System.Windows.Media;

namespace Items
{
    public abstract class Item : Nameable, IHasAvatar
    {
        private string description;

        public ImageSource Avatar { get; set; }

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
