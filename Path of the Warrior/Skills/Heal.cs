using Characters;
using Path_of_the_Warrior.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_of_the_Warrior.Skills
{
    class Heal : Skill, ISkill
    {
        public Heal(string name, int hp)
        {
            this.Name = name;
            this.HP = hp;
        }
        public override int Calculate()
        {
            return HP;
        }
        public Character RestoreHealth(Character character)
        {
            character.HP += this.Calculate();
            return character;
        }
    }
}
