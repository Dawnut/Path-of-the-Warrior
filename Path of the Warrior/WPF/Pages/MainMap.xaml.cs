using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PathOfTheWarrior.WPF;
using PathOfTheWarrior.Characters;
using PathOfTheWarrior.Items;
using PathOfTheWarrior.Skills;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace PathOfTheWarrior.WPF.Pages
{
    /// <summary>
    /// Interaction logic for MainMap.xaml
    /// </summary>
    public partial class MainMap : Page
    {
        
        public Hero Myhero { get; set; }
        public Weapon MainWeapon { get; set; }
        public Armor Armor { get; set; }
        public Skill Skill { get; set; }
        public Enemy Enemy1 { get; set; }
        public Enemy Enemy2 { get; set; }
        public Trophy Treasure { get; set; }

        public MainMap() { }

        public MainMap(Hero myHero,
            Weapon mainWeapon,
            Armor armor,
            Skill skill)
        {
            this.Myhero = myHero;
            this.MainWeapon = mainWeapon;
            this.Armor = armor;
            this.Skill = skill;
            this.Enemy1 = new Enemy("Ork", 25, 30, new Trophy("Amulet", "Ancient Amulet", 
                new BitmapImage(new Uri("../Images/amulet.png", UriKind.RelativeOrAbsolute))), 
                new BitmapImage(new Uri("../Images/ork.png", UriKind.RelativeOrAbsolute)));

            this.Enemy2 = new Enemy("Wolf", 25, 30, new Trophy("HP Potion", "Magic potion", 
                new BitmapImage(new Uri("../Images/HPpotion.png", UriKind.RelativeOrAbsolute))), 
                new BitmapImage(new Uri("../Images/shadow.png", UriKind.RelativeOrAbsolute)));

            this.Treasure = new Trophy("Crocs", "Ugly Shoes", new BitmapImage(new Uri("../Images/crocs.png", UriKind.RelativeOrAbsolute)));
            this.DataContext = this;
            InitializeComponent();
            SetAvatars();
        }

        public void SetAvatars()
        {
            HeroImage.Source = Myhero.Avatar;
            WeaponImage.Source = MainWeapon.Avatar;
            ArmorImage.Source = Armor.Avatar;
            SkillImage.Source = Skill.Avatar;

        }

        private void locationButton2_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void locationButton1_Click(object sender, RoutedEventArgs e)
        {
            combatHero.Source = Myhero.Avatar;
            combatEnemy.Source = Enemy1.Avatar;
            MoveTo(HeroImage, 564, 480);
            MoveTo(Matt, 564, 480);
            await Wait();
            locationButton1.Visibility = Visibility.Hidden;
            Matt2.Visibility = Visibility.Hidden;
            locationButton2.Visibility = Visibility.Visible;
            Matt3.Visibility = Visibility.Visible;
            lostHP.Text = " " + (Enemy1.DMG).ToString();
            Myhero.Inventory.Add(Enemy1.Loot);
            LootImg.Source = Myhero.Inventory[2].Avatar; ;
            LootImage1.Source = Enemy1.Loot.Avatar;
            Combat.Visibility = Visibility.Visible;

        }

        private void locationButton3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void heroButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public void MoveTo(Image target, double newX, double newY)
        {
            Vector offset = VisualTreeHelper.GetOffset(target);
            var top = offset.Y;
            var left = offset.X;
            TranslateTransform trans = new TranslateTransform();
            target.RenderTransform = trans;
            DoubleAnimation anim1 = new DoubleAnimation(0, newY - top, TimeSpan.FromSeconds(2));
            DoubleAnimation anim2 = new DoubleAnimation(0, newX - left, TimeSpan.FromSeconds(2));
            trans.BeginAnimation(TranslateTransform.YProperty, anim1);
            trans.BeginAnimation(TranslateTransform.XProperty, anim2);

        }

        private void backToMapButton_Click(object sender, RoutedEventArgs e)
        {
            Combat.Visibility = Visibility.Hidden;

        }

        public async Task Wait()
        {
            await Task.Delay(2000);
        }
    }
}
