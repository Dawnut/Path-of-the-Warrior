namespace PathOfTheWarrior.Items
{
    using Interfaces;
    using System.Windows.Media;

    public abstract class Item : INameable, IHasAvatar
    {
        private ImageSource avatar;
        private string name;

        public ImageSource Avatar { get; set; }
        public string Name { get; set; }

        protected Item() { }
        protected Item(string name) { this.Name = name; }
     
    }


}
