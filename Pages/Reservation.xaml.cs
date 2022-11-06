
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для Reservation.xaml
    /// </summary>
    public partial class Reservation : UserControl
    {
        public Reservation()
        {
            InitializeComponent();
            Style style = new Style(this);
            CloseButton.Click += style.Close_Click;
            MinimizeButton.Click += style.Minimize_Click;
            MaximizeButton.Click += style.Maximize_Click;

            BorderNavigator borderNavigator = new BorderNavigator();
            menu.Click += borderNavigator.MenuButton_Click;
            restaurant.Click += borderNavigator.RestaurantButton_Click;
            classes.Click += borderNavigator.ClassesButton_Click;
            booking.Click += borderNavigator.BookButton_Click;
        }

        private void OpenContactPage_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Contact());
    }
}
