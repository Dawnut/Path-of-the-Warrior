using PathOfTheWarrior.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PathOfTheWarrior.Items
{
    public abstract class Consumable : Item, IHasAvatar
    {

        private int bonusStat;

        protected Consumable(string name, int bonusStat)
            : base(name)
        {
            this.BonusStat = bonusStat;
        }

        protected Consumable(int bonusStat)
        {
            this.BonusStat = bonusStat;
        }

        public int BonusStat
        {
            get
            {
                return bonusStat;
            }
            set
            {
                this.bonusStat = value;
            }
        }
        public abstract void DrinkPotion(ICharacter character);

    }
}