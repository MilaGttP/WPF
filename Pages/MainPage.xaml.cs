
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            Style style = new Style(this);
            CloseButton.Click += style.Close_Click;
            MinimizeButton.Click += style.Minimize_Click;
            MaximizeButton.Click += style.Maximize_Click;
        }
        private void MenuButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Menu());
        private void RestaurantButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Restaurant());
        private void ClassesButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Classes());
        private void BookButton_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Reservation());
    }
}
