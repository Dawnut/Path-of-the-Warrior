namespace PathOfTheWarrior.Characters
{
    using Interfaces;
    using Items;

    public class Enemy : Character, INameable, IHasAvatar, ICharacter
    {
        private Item loot;
        public Item Loot { get { return loot; } set { this.loot = value; } }

        public Enemy(string name, int hp, int dmg, Item loot) :base(hp,dmg)
        {
            this.Loot = loot;
        }
    }
}
