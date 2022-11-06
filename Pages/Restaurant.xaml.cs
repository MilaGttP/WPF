
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для Restaurant.xaml
    /// </summary>
    public partial class Restaurant : UserControl
    {
        public Restaurant() => InitializeComponent();
        private void MenuButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Menu());
        private void RestaurantButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Restaurant());
        private void ClassesButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Classes());
        private void BookButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Reservation());

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            scrollviewer1.LineRight();
            Left.Visibility = Visibility.Visible;
        }
        private void Left_Click(object sender, RoutedEventArgs e) => scrollviewer1.LineLeft();
    }
}
