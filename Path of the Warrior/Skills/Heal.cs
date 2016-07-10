using Characters;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_of_the_Warrior.Skills
{
    class Heal : Skill, IHasAvatar
    {
        public Heal(string name, int hp)
        {
            this.Name = name;
            this.HP = hp;
        }

        public Heal() { }
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
