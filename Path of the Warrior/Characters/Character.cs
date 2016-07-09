using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    /// <summary>
    /// Main user character.
    /// </summary>
    class Character : HeroCharacter
    {
        public HeroType HeroProfession;
        
        // Enemy constructor
        public Character(string name, int hp, int dmg)
        {
            base.CharName = name;
            base.HP = hp;
            base.DMG = dmg;
        }

        //Hero constructor
        public Character(string name, int hp, int dmg, int money, int maxWeight, 
            List<object> myAddableList, List<object> myTrophyList) : this(name, hp, dmg)
        {
            this.myAddableList = myAddableList;
            this.myTrophyList = myTrophyList;
            base.CharMoney = money;
            base.MaximumWeight = maxWeight;
        }

        //Constructor with hero type
        public Character(HeroType heroType, string name, int hp, int dmg, int money, int maxWeight,
            List<object> myAddableList, List<object> myTrophyList) 
            : this(name, hp, dmg, money, maxWeight, myAddableList, myTrophyList)
        {
            this.HeroProfession = heroType;
        }

        //public void BuyStuff(Gear gear)
        //{
        //    this.Money -= gear.Cost;
        //    myAddableList.Add(gear);
        //}

        //public void SellAll()
        //{
        //    // set to default
        //    Money = 100;
        //    maxWeight = 15;
        //    // clear items list
        //    myAddableList.Clear();
        //}



    }

}
