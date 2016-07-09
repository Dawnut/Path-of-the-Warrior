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
using PathOfTheWarrior;
using Characters;
using Items;
using Path_of_the_Warrior.WPF.Pages;


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
        Hero myHero = new Hero();
        Weapon mainWeapon = new Weapon();
        Armor armor = new Armor();


        public MainWindow()
        {
            InitializeComponent();

            

            InitializeProgram();
        }

        private void InitializeProgram()
        {
            myHero.Inventory.Add(mainWeapon);
            myHero.Inventory.Add(armor);
            mainFrame.NavigationService.Navigate(startPage);
            startPage.startButton.Click += startButton_Click;
            heroSelect.swordsmanButton.Click += Swordsman_Click;
            heroSelect.spearmanButton.Click += Spearman_Click;
            heroSelect.archerButton.Click += Archer_Click;
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
           // mainFrame.NavigationService.Navigate(spellSelect);
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            armor.Avatar = new BitmapImage(new Uri("WPF/Images/mediumArmor.png", UriKind.RelativeOrAbsolute));
            // mainFrame.NavigationService.Navigate(spellSelect);
        }

        private void Heavy_Click(object sender, RoutedEventArgs e)
        {
            armor.Avatar = new BitmapImage(new Uri("WPF/Images/heavyArmor.png", UriKind.RelativeOrAbsolute));
            // mainFrame.NavigationService.Navigate(spellSelect);
        }

        #endregion
    }
}
