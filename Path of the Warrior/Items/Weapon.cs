using Characters;
using Interfaces;
using System;
namespace Items
{
    public class Weapon : Item, IDamageUp
    {
        private int dmg;

        public Weapon(string Name, string Description, int dmg)
            : base(Name, Description)
        {
            this.BonusDamage = dmg;
        }

        public int BonusDamage { get; set; }

        public void AddDamage(Character character)
        {
            character.DMG += BonusDamage;
        }
    }
}