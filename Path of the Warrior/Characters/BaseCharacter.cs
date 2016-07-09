namespace DungeonProject
{
    using System;

    /// <summary>
    /// Base character class.
    /// </summary>
    public /* abstract */ class BaseCharacter 
    {
        private string Name;
        private int HitPoints;
        private int DamagePoints;

        public int HP
        {
            get
            {
                return this.HitPoints;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Initial hit points cannot be negative.");
                }
                DamagePoints = value;
            }
        }
        public int DMG
        {
            get
            {
                return this.DamagePoints;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Initial damage points cannot be negative.");
                }
                DamagePoints = value;
            }
        }
        public string CharName
        {
            get { return this.Name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                this.Name = value;
            }
        }
    }
}