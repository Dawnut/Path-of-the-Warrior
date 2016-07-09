using Characters;
using Interfaces;
using System;

namespace Items
{

    public class Armor : Item, IHealthUp
    {
        private int hp;

        public Armor(string Name, string Description, int hp)
            : base(Name, Description)
        {
            this.BonusHealth = hp;
        }


        public int BonusHealth { get; set; }

        public void AddHealth(Character character)
        {
            character.HP += BonusHealth;
        }
    }

}