using Characters;
using Interfaces;
using System;
using System.Windows.Media;
namespace Items
{
    public class Weapon : Item, IDamageUp, IHasAvatar
    {
        public Weapon(string Name, string Description, int dmg)
            : base(Name, Description)
        {
            this.BonusDamage = dmg;
        }

        public Weapon(string Name, int dmg)
            : base(Name)
        {
            this.BonusDamage = dmg;
        }

        public Weapon() { }

        public int BonusDamage { get; set; }

        public void AddDamage(Character character)
        {
            character.DMG += BonusDamage;
        }
    }
}