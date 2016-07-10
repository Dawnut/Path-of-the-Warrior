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
using Pages;
using Characters;
using Items;
using Path_of_the_Warrior.WPF.Pages;
using Path_of_the_Warrior.Skills;


namespace Path_of_the_Warrior
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StartPage startPage = new StartPage();
        HeroSelect heroSelect = new HeroSelect();
        ArmorSelect armorSelect = new ArmorSelect();
        SkillSelect skillSelect = new SkillSelect();
        Hero myHero = new Hero();
        Weapon mainWeapon = new Weapon();
        Armor armor = new Armor();
        Skill skill = new Heal(); // heal by default, can be changed when Player picks skill


        public MainWindow()
        {
            InitializeComponent();
            ApplyEventHandlers();
        }

        private void ApplyEventHandlers()
        {
            myHero.Inventory.Add(mainWeapon);
            myHero.Inventory.Add(armor);
            mainFrame.NavigationService.Navigate(startPage);
            startPage.startButton.Click += startButton_Click;
            heroSelect.swordsmanButton.Click += Swordsman_Click;
            heroSelect.spearmanButton.Click += Spearman_Click;
            heroSelect.archerButton.Click += Archer_Click;
            armorSelect.lightButton.Click += Light_Click;
            armorSelect.mediumButton.Click += Medium_Click;
            armorSelect.heavyButton.Click += Heavy_Click;
            skillSelect.mutilateButton.Click += Mutilate_Click;
            skillSelect.healButton.Click += Heal_Click;
            skillSelect.precisionButton.Click += PrecisionStrike_Click;
        }

        #region EventHandlers from all pages


        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(heroSelect);

        }

        private void Swordsman_Click(object sender, RoutedEventArgs e)
        {
            myHero.Avatar = new BitmapImage(new Uri("WPF/Images/swordsman.png", UriKind.RelativeOrAbsolute));
            mainWeapon.Avatar = new BitmapImage(new Uri("WPF/Images/sword.png", UriKind.RelativeOrAbsolute));
            mainFrame.NavigationService.Navigate(armorSelect);

        }

        private void Spearman_Click(object sender, RoutedEventArgs e)
        {
            myHero.Avatar = new BitmapImage(new Uri("WPF/Images/spearman.png", UriKind.RelativeOrAbsolute));
            mainWeapon.Avatar = new BitmapImage(new Uri("WPF/Images/spear.png", UriKind.RelativeOrAbsolute));
            mainFrame.NavigationService.Navigate(armorSelect);

        }

        private void Archer_Click(object sender, RoutedEventArgs e)
        {
            myHero.Avatar = new BitmapImage(new Uri("WPF/Images/archer.png", UriKind.RelativeOrAbsolute));
            mainWeapon.Avatar = new BitmapImage(new Uri("WPF/Images/bow.png", UriKind.RelativeOrAbsolute));
            mainFrame.NavigationService.Navigate(armorSelect);

        }

        private void Light_Click(object sender, RoutedEventArgs e)
        {
            armor.Avatar = new BitmapImage(new Uri("WPF/Images/lightArmor.png", UriKind.RelativeOrAbsolute));
            mainFrame.NavigationService.Navigate(skillSelect);
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            armor.Avatar = new BitmapImage(new Uri("WPF/Images/mediumArmor.png", UriKind.RelativeOrAbsolute));
            mainFrame.NavigationService.Navigate(skillSelect);
        }

        private void Heavy_Click(object sender, RoutedEventArgs e)
        {
            armor.Avatar = new BitmapImage(new Uri("WPF/Images/heavyArmor.png", UriKind.RelativeOrAbsolute));
            mainFrame.NavigationService.Navigate(skillSelect);
        }

        public void Mutilate_Click(object sender, RoutedEventArgs e)
        {
            skill = new Mutilate("Mutilate",50);
            skill.Avatar = new BitmapImage(new Uri("WPF/Images/mutilate.png", UriKind.RelativeOrAbsolute));
          //  mainFrame.NavigationService.Navigate(map);
        }

        public void PrecisionStrike_Click(object sender, RoutedEventArgs e)
        {
            skill = new Mutilate("Mutilate", 60);
            skill.Avatar = new BitmapImage(new Uri("WPF/Images/precisionStrike.png", UriKind.RelativeOrAbsolute));
           // mainFrame.NavigationService.Navigate(map);

        }

        public void Heal_Click(object sender, RoutedEventArgs e)
        {
            skill = new PrecisionStrike("Heal", 25);
            skill.Avatar = new BitmapImage(new Uri("WPF/Images/heal.png", UriKind.RelativeOrAbsolute));
          //  mainFrame.NavigationService.Navigate(map);

        }
        #endregion
    }
}
