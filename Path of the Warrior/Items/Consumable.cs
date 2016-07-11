using PathOfTheWarrior.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  PathOfTheWarrior.Items
{
    public abstract class Consumable : Item
    {

        private int bonusHealth;
        public int BonusHealth { 
            get 
        { 
            return bonusHealth; 
        }
            set 
        { 
            this.bonusHealth = value; 
        } 
        }
        public abstract virtual void DrinkPotion(ICharacter character)
        {
                    
        }

    }
}
