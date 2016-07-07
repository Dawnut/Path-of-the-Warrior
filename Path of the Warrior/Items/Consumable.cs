using System;

public class Consumable : Item
{
    private int hP;

    public Consumable(string Name, string Description, int HP) : base(Name, Description)
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
