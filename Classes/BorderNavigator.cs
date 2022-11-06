
using System.Windows;

namespace WPF
{
    public class BorderNavigator
    {
        public void MenuButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Menu());
        public void RestaurantButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Restaurant());
        public void ClassesButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Classes());
        public void BookButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Reservation());
    }
}
