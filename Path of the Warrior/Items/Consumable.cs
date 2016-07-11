﻿using Items;
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
        public virtual void DrinkPotion(ICharacter character)
        {
                    
        }

    }
}