using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Windows.Media;

namespace Path_of_the_Warrior.Skills
{
    public abstract class Skill: ISkill, IHasAvatar
    {
        public ImageSource Avatar { get; set; }


        protected string name;
        protected int hp;
        public string Name { get; set; }
        public int HP { get; set; }

        public abstract int Calculate();

    }
}
