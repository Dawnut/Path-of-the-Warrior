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
        private int spellCounter = 0;
        private int battleCounter = 0;
        public Point heroInitial = new Point(0, 0);
        public Point mattInitial = new Point(0, 0);
        public readonly List<Point> Locations = new List<Point>
        {
             new Point(564,480),
             new Point(526,297),
             new Point(105,144)
        };

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
            this.Enemy1 = new Enemy("Ork", 25, 23, new Trophy("Amulet", "Ancient Amulet",
                new BitmapImage(new Uri("../Images/amulet.png", UriKind.RelativeOrAbsolute))),
                new BitmapImage(new Uri("../Images/ork.png", UriKind.RelativeOrAbsolute)));

            this.Enemy2 = new Enemy("Wolf", 25, 32, new Trophy("HP Potion", "Magic potion",
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
            ActualHP.Text = Myhero.HP.ToString();

        }

        private async void locationButton1_Click(object sender, RoutedEventArgs e)
        {
            combatHero.Source = Myhero.Avatar;
            combatEnemy.Source = Enemy1.Avatar;

            MoveTo(HeroImage, Locations[0].X, Locations[0].Y);
            MoveTo(Matt, Locations[0].X, Locations[0].Y);
            await Wait(2000);

            RevealNewLocation(locationButton1, Matt2, locationButton2, Matt3);
            ResolveEncounter(Myhero, Enemy1, battleCounter);

            Combat.Visibility = Visibility.Visible;

        }

        private async void locationButton2_Click(object sender, RoutedEventArgs e)
        {
            combatEnemy.Source = Enemy2.Avatar;

            MoveTo(HeroImage, Locations[1].X, Locations[1].Y);
            MoveTo(Matt, Locations[1].X, Locations[1].Y);
            await Wait(2000);

            RevealNewLocation(locationButton2, Matt3, locationButton3, Matt4);
            ResolveEncounter(Myhero, Enemy2, battleCounter);

            Combat.Visibility = Visibility.Visible;
        }

        private async void locationButton3_Click(object sender, RoutedEventArgs e)
        {
            MoveTo(HeroImage, Locations[2].X, Locations[2].Y);
            MoveTo(Matt, Locations[2].X, Locations[2].Y);
            await Wait(2000);
            award.Source = Treasure.Avatar;
            GameOver.Visibility = Visibility.Visible;

        }

        public void ResolveEncounter(Hero hero, Enemy enemy, int battleCounter)
        {
            lostHP.Text = " " + (enemy.DMG).ToString();
            ActualHP.Text = (hero.HP - enemy.DMG).ToString();
            hero.HP -= enemy.DMG;
            hero.Inventory.Add(enemy.Loot);
            LootImg.Source = hero.Inventory[2 + battleCounter].Avatar;
            LootImage1.Source = hero.Inventory[2 + battleCounter].Avatar;
            battleCounter++;
        }

        public void RevealNewLocation(Button oldButton, Image oldMatt, Button newButton, Image newMatt)
        {
            oldButton.Visibility = Visibility.Hidden;
            oldMatt.Visibility = Visibility.Hidden;
            newButton.Visibility = Visibility.Visible;
            newMatt.Visibility = Visibility.Visible;
        }

        public void MoveTo(Image target, double newX, double newY)
        {
            Vector offset = VisualTreeHelper.GetOffset(target);

            double oldY = 0;
            double oldX = 0;
            var top = offset.Y;
            var left = offset.X;

            if (target == HeroImage)
            {
                oldX = heroInitial.X;
                oldY = heroInitial.Y;
            }
            else
            {
                oldX = mattInitial.X;
                oldY = mattInitial.Y;
            }

            TranslateTransform trans = new TranslateTransform();
            target.RenderTransform = trans;
            DoubleAnimation anim1 = new DoubleAnimation(oldY, newY - top, TimeSpan.FromSeconds(2));
            DoubleAnimation anim2 = new DoubleAnimation(oldX, newX - left, TimeSpan.FromSeconds(2));
            trans.BeginAnimation(TranslateTransform.YProperty, anim1);
            trans.BeginAnimation(TranslateTransform.XProperty, anim2);
            if (target == HeroImage)
            {
                heroInitial.X = newX - left;
                heroInitial.Y = newY - top;
            }
            else
            {
                mattInitial.X = newX - left;
                mattInitial.Y = newY - top;
            }
        }

        private void backToMapButton_Click(object sender, RoutedEventArgs e)
        {
            Combat.Visibility = Visibility.Hidden;

        }

        public async Task Wait(int time)
        {
            await Task.Delay(time);
        }

        private void spellButton_Click(object sender, RoutedEventArgs e)
        {

            if (Skill.Name == "Heal" && spellCounter < 3)
            {
                Myhero.HP += 20;
                ActualHP.Text = Myhero.HP.ToString();
                spellCounter++;
            }
        }

        private void chestButton_Click(object sender, RoutedEventArgs e)
        {
            newCrocs.Visibility = Visibility.Visible;
            chestButton.Visibility = Visibility.Hidden;
        }
    }
}
