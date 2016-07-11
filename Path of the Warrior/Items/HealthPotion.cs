using PathOfTheWarrior.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PathOfTheWarrior.Items
{
    class HealthPotion : Consumable, IHasAvatar
    {
        public ImageSource Avatar { get; set; }

        public HealthPotion(int bonusStat)
            : base(bonusStat) { }

        public override void DrinkPotion(ICharacter character)
        {
            character.HP += this.BonusStat;
        }

    }
}
