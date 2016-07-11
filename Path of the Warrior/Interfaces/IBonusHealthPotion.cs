namespace PathOfTheWarrior.Interfaces
{
    public interface IBonusHealthPotion

    {
        int UpperHealth { get; set; }
        //increase maximum health
        void PermaAddHealth(ICharacter character);
    }
}
