using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject

{
    class Start
    {
        static void Main()
        {


            #region Building lists with the game elements

            var armorList = new List<Gear> { new Armor("shield", "a wooden board", 25, 4, 30)};

            var trophyList = new List<Item> { new Trophy("OMGBall", "old football ball") };

            var weaponList = new List<Gear> {new Weapon("sword", "it might be still sharp, idk", 30, 5, 20) };

            var consumableList = new List<Item> { new Consumable("vodka", "russian power", 25) };

            var enemyList = new List<Character> { new Character( "Black Ork", 140, 25 ), new Character ( "Terrorist kamikaze", 30, 70 ) };

            #endregion


            #region Character creation menu

            var myHero = new Character("Abdul", 100, 10, 499, 15, new List<object>(), new List<object>());


            // click of different button gives differnet index value, synced with the lists
            int indexOfItem = 0;


            // on click of button for eding character creation menu => endOfItemMenu = true
            bool endOfItemMenu = false;


            while(endOfItemMenu == false)
            {

                //waiting input (item picker)

                switch (indexOfItem)
                {
                    case 0:
                        // add item with button index 0
                        myHero.BuyStuff(weaponList[0]);
                        break;
                    case 1:
                        myHero.BuyStuff(armorList[0]);
                        break;
                    case 2:
                        // select to clear current selected items
                        myHero.SellAll();
                        break;
                    case 3:
                        // select end of char. creation and go to the quest
                        endOfItemMenu = true;
                        break;
                }

                if(myHero.Money < 0)
                {
                    endOfItemMenu = false;
                    Console.WriteLine("Gold needed!");
                }
                else if (myHero.maxWeight < 0)
                {
                    endOfItemMenu = false;
                    Console.WriteLine("Too heavy, damn!");
                }

            }

            #endregion


            #region Building battles

            int enemyCount = enemyList.Count;

            var rnd = new Random();

            var battleList = new List<Battle> { new Battle("Mighty sequoia forest", enemyList[rnd.Next(enemyCount - 1)], trophyList[0], false, true),
                new Battle("Slamp", enemyList[rnd.Next(enemyCount - 1)], trophyList[0], true, false),
                new Battle("Desert", enemyList[rnd.Next(enemyCount - 1)], trophyList[0], true, false),
                new Battle("Castle", enemyList[rnd.Next(enemyCount - 1)], trophyList[0], false, false),
                new Battle("Dungeon", enemyList[rnd.Next(enemyCount - 1)], trophyList[0], false, false),
                new Battle("Cave", enemyList[rnd.Next(enemyCount - 1)], trophyList[0], false, false), };


            #endregion


            #region Battle cycle
            //waiting input

            // Character fighting method()
                // function for combining item's powers and Hero's hp and dmg
                //func for comparing Enemy's and Hero's hp, dmg 
                //result of figth

            #endregion


            #region End game and summary

            // print result and trophey

            #endregion


        }




    }

}
