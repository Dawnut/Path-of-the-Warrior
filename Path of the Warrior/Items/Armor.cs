using System;

public class Armor : Gear
{
    private int hP;

    public Armor(string Name, string Description, int Cost, int Weight, int HP) : base(Name, Description, Cost, Weight)
    {
        this.hP = HP;
    }

    public int HP
    {
        get
        {
            return hP;
        }
        private set
        {
            hP = value;
        }
    }
}
