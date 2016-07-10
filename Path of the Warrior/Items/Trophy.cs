using Interfaces;
using System;
using System.Windows.Media;

namespace Items
{
    public class Trophy : Item, IHasAvatar
    {

        public Trophy(string Name, string Description) : base(Name, Description) { }

    }

}