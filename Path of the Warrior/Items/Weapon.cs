using System;
namespace DungeonProject
{


public class Weapon : Gear
{
    private int dMG;

        public Weapon(string Name, string Description, int Cost, int Weight, int DMG) : base(Name, Description, Cost, Weight)
    {
        this.dMG = DMG;
    }

    public int DMG
    {
        get
        {
            return dMG;
        }
        private set
        {
            dMG = value;
        }
    }


}

}
