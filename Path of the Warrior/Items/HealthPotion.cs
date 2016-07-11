using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathOfTheWarrior.Items
{
    class HealthPotion : Consumable
    {
        private int bonusHealth;
        public int BonusHealth { 
            get 
            {
                return bonusHealth = BonusStat; 
            } 
            set 
            { 
                this.bonusHealth = value;
            } 
        }
        public abstract override int DrinkPotion(ICharacter character)
        {
            return character.HP += bonusHealth;
        }

    }
}
