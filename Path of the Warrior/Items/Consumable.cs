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

        private int bonusStat;
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
        public abstract virtual void DrinkPotion(ICharacter character)
        {
                    
        }

    }
}