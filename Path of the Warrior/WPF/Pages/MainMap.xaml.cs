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
        int spellCounter = 0;
        double HeroOldY = 0;
        double HeroOldX = 0;
        double MattOldY = 0;
        double MattOldX = 0;

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
            MoveTo(HeroImage, 564, 480);
            MoveTo(Matt, 564, 480);
            await Wait(2000);
            locationButton1.Visibility = Visibility.Hidden;
            Matt2.Visibility = Visibility.Hidden;
            locationButton2.Visibility = Visibility.Visible;
            Matt3.Visibility = Visibility.Visible;
            lostHP.Text = " " + (Enemy1.DMG).ToString();
            ActualHP.Text = (Myhero.HP - Enemy1.DMG).ToString();
            Myhero.HP -= Enemy1.DMG;
            Myhero.Inventory.Add(Enemy1.Loot);
            LootImg.Source = Myhero.Inventory[2].Avatar; ;
            LootImage1.Source = Enemy1.Loot.Avatar;
            Combat.Visibility = Visibility.Visible;

        }

        private async void locationButton2_Click(object sender, RoutedEventArgs e)
        {
            combatEnemy.Source = Enemy2.Avatar;
            MoveTo(HeroImage, 526, 297);
            MoveTo(Matt, 526, 297);
            await Wait(2000);
            locationButton2.Visibility = Visibility.Hidden;
            Matt3.Visibility = Visibility.Hidden;
            locationButton3.Visibility = Visibility.Visible;
            Matt4.Visibility = Visibility.Visible;
            lostHP.Text = " " + (Enemy2.DMG).ToString();
            ActualHP.Text = (Myhero.HP - Enemy2.DMG).ToString();
            Myhero.HP -= Enemy2.DMG;
            Myhero.Inventory.Add(Enemy2.Loot);
            LootImg.Source = Myhero.Inventory[3].Avatar; ;
            LootImage2.Source = Enemy2.Loot.Avatar;
            Combat.Visibility = Visibility.Visible;
        }

        private async void locationButton3_Click(object sender, RoutedEventArgs e)
        {
            MoveTo(HeroImage, 105, 144);
            MoveTo(Matt, 105, 144);
            await Wait(2100);
            award.Source = Treasure.Avatar;
            GameOver.Visibility = Visibility.Visible;
           
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
                oldX = HeroOldX;
                oldY = HeroOldY;
            }
            else
            {
                oldX = MattOldX;
                oldY = MattOldY;
            }

            TranslateTransform trans = new TranslateTransform();
            target.RenderTransform = trans;
            DoubleAnimation anim1 = new DoubleAnimation(oldY, newY - top, TimeSpan.FromSeconds(2));
            DoubleAnimation anim2 = new DoubleAnimation(oldX, newX - left, TimeSpan.FromSeconds(2));
            trans.BeginAnimation(TranslateTransform.YProperty, anim1);
            trans.BeginAnimation(TranslateTransform.XProperty, anim2);
            if (target == HeroImage)
            {
                HeroOldX = newX - left;
                HeroOldY = newY - top;
            }
            else
            {
                MattOldX = newX - left;
                MattOldY = newY - top;
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
