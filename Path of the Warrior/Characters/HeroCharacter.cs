namespace DungeonProject
{
    using System.Collections.Generic;
    /// <summary>
    /// User character, derived from base character.
    /// </summary>
    class HeroCharacter : BaseCharacter
    {
        public List<Item> inventory;
        public List<object> myAddableList;
        public List<object> myTrophyList;
        private int MaxWeight;
        private int Money;

        public int CharMoney
        {
            get { return this.Money; }
            set
            {
                MaxWeight = value;
            }
        }
        public int MaximumWeight {
            get { return this.Money; }
            set
            {
                MaxWeight = value;
            }
        }
    }
}
