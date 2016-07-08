using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Character
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int DMG { get; set; }

        public int Money { get; set; }
        public int maxWeight { get; set; }


        public List<object> myAddableList;
        public List<object> myTrophyList;

        // Enemy constructor
        public Character(string name, int hp, int dmg)
        {
            this.Name = name;
            this.HP = hp;
            this.DMG = dmg;
        }

        //Hero constructor
        public Character(string name, int hp, int dmg, int money, int maxWeight, 
            List<object> myAddableList, List<object> myTrophyList) : this(name, hp, dmg)
        {
            this.myAddableList = myAddableList;
            this.myTrophyList = myTrophyList;
            this.Money = money;
            this.maxWeight = maxWeight;
        }

        public void BuyStuff(Gear gear)
        {
            this.Money -= gear.Cost;
            myAddableList.Add(gear);
        }

        public void SellAll()
        {
            // set to default
            Money = 100;
            maxWeight = 15;
            // clear items list
            myAddableList.Clear();
        }



    }

}
