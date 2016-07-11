namespace PathOfTheWarrior.Interfaces
{
    public interface IBonusDMGPotion

    {
        int UpperDMG { get; set; }
        //increase maximum DMG
        void PermaAddDMG(ICharacter character);
    }
}
