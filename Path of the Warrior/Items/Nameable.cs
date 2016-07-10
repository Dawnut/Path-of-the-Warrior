using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public abstract class Nameable
    {
        private string name;

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
                    throw new NullReferenceException("The name cannot be null or empty");
                }
                name = value;
            }
        }

        public Nameable(string name)
        {
            this.Name = name;
        }

        public Nameable() { }
    }

}
