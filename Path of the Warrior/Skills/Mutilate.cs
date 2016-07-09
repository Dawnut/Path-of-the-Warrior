using Path_of_the_Warrior.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_of_the_Warrior.Skills
{
    class Mutilate : Skill, ISkill
    {

        public Mutilate()
        {
        }
        public Mutilate(string name, int damage)
        {
            this.Name = name;
            this.HP = damage;
        }
        public override int Calculate()
        {
            Random rnd = new Random();
            int chance = rnd.Next(1, 100);
            if (chance < 50)
            {
                return 0;
            }
            else
            {
                return HP;
            }
        }
    }
}
