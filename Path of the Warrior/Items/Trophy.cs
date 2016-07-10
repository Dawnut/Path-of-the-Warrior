namespace PathOfTheWarrior.Items
{
    using Interfaces;

    public class Trophy : Item, IHasAvatar, INameable
    {

        private string description;
        public string Description { get { return description; } private set { this.description = value; } }

        public Trophy(string name, string description) : base(name) { this.Description = description; }

    }

}