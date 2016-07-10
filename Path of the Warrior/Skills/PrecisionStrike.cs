using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_of_the_Warrior.Skills
{
    class PrecisionStrike : Skill, IHasAvatar
    {
        public PrecisionStrike(string name, int damage)
        {
            this.Name = name;
            this.HP = damage;
        }

        public PrecisionStrike() { }

        public override int Calculate()
        {
            return HP;
        }
    }
}
