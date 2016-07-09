using Path_of_the_Warrior.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_of_the_Warrior.Skills
{
    class PrecisionStrike : Skill, ISkill
    {
        public PrecisionStrike(string name, int damage)
        {
            this.Name = name;
            this.HP = damage;
        }

        public override int Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
