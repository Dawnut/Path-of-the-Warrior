using System;

public abstract class Item
{
    private string name;
    private string description;

    protected Item(string Name, string Description)
    {
        name = Name;
        description = Description;
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NullReferenceException("The name cannot be null or empty");
            }
            name = value;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
        private set
        {
            description = value;
        }
    }
}
