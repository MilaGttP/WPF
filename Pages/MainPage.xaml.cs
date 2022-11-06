
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage() => InitializeComponent();
        private void MenuButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Menu());
        private void RestaurantButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Restaurant());
        private void ClassesButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Classes());
        private void BookButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Reservation());
    }
}
