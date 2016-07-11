namespace PathOfTheWarrior.Interfaces
{
    public interface IFreeWinTiccket

    {
        int OneFreeWin { get; set; }
        //increase maximum DMG
        void PermaAddDMG(ICharacter character);
    }
}
